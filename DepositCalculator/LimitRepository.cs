using Sx.Vx.Quipu.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;

namespace Sx.Vx.Quipu.WinUI
{
    internal class LimitRepository : ILimitRepository
    {
        private class Loader : IDisposable
        {
            private class State
            {
                public string Value;
                public string CurrencyAlphabeticCode;
                public int MinAmount, MaxAmount;
                public int MinTerm, MaxTerm;
                public int MinInterestRate, MaxInterestRate;

                public Limit CreateLimit()
                {
                    return new Limit(
                        MinAmount, MaxAmount,
                        MinTerm, MaxTerm,
                        MinInterestRate, MaxInterestRate);
                }

                public void Reset()
                {
                    Value = CurrencyAlphabeticCode = null;
                    MinAmount = MaxAmount = -1;
                    MinTerm = MaxTerm = -1;
                    MinInterestRate = MaxInterestRate = -1;
                }
            }

            private readonly string _xmlFilePath;
            private State _state;
            private LimitRepository _repository;
            private FileStream _stream;

            public Loader(string xmlFilePath)
            {
                Debug.Assert(!string.IsNullOrWhiteSpace(xmlFilePath));

                _xmlFilePath = xmlFilePath;
            }

            public LimitRepository Load()
            {
                Debug.Assert(_state == null && _repository == null && _stream == null);

                _state = new State();
                _repository = new LimitRepository { _limits = new Dictionary<Currency, Limit>(capacity: 10) };

                _stream = File.OpenRead(Path.Combine(Environment.CurrentDirectory, _xmlFilePath));
    
                using (var reader = XmlReader.Create(_stream))
                    while (reader.Read())
                        ProcessNode(reader);

                if (_repository._defaultLimit == null)
                    throw new ApplicationException("The default limit must be set.");

                return _repository;
            }

            public void Dispose()
            {
                _stream?.Dispose();
            }

            private void ProcessNode(XmlReader reader)
            {
                Debug.Assert(reader != null && _state != null && _repository != null);

                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name.Equals("Limit", StringComparison.InvariantCultureIgnoreCase))
                            if (reader.HasAttributes)
                                _state.CurrencyAlphabeticCode = reader.GetAttribute("currency");
                        break;
                    case XmlNodeType.Text:
                        _state.Value = reader.Value;
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name.Equals("MinAmount", StringComparison.InvariantCultureIgnoreCase))
                            _state.MinAmount = ToInt(reader.Name, _state.Value);
                        else if (reader.Name.Equals("MaxAmount", StringComparison.InvariantCultureIgnoreCase))
                            _state.MaxAmount = ToInt(reader.Name, _state.Value);
                        else if (reader.Name.Equals("MinTerm", StringComparison.InvariantCultureIgnoreCase))
                            _state.MinTerm = ToInt(reader.Name, _state.Value);
                        else if (reader.Name.Equals("MaxTerm", StringComparison.InvariantCultureIgnoreCase))
                            _state.MaxTerm = ToInt(reader.Name, _state.Value);
                        else if (reader.Name.Equals("MinInterestRate", StringComparison.InvariantCultureIgnoreCase))
                            _state.MinInterestRate = ToInt(reader.Name, _state.Value);
                        else if (reader.Name.Equals("MaxInterestRate", StringComparison.InvariantCultureIgnoreCase))
                            _state.MaxInterestRate = ToInt(reader.Name, _state.Value);
                        else if (reader.Name.Equals("Limit", StringComparison.InvariantCultureIgnoreCase))
                        {
                            var limit = _state.CreateLimit();

                            if (_state.CurrencyAlphabeticCode == null)
                            {
                                if (_repository._defaultLimit != null)
                                    throw new ApplicationException("The default limit is already set.");

                                _repository._defaultLimit = limit;
                            }
                            else
                            {
                                var currency = Currency.Currencies.FirstOrDefault(i => i.AlphabeticCode == _state.CurrencyAlphabeticCode);
                                if (currency == Currency.Empty)
                                    throw new NotSupportedException($"The {_state.CurrencyAlphabeticCode} currency is not supported yet.");

                                _repository._limits.Add(currency, limit);
                            }

                            _state.Reset();
                        }

                        break;
                }
            }

            private int ToInt(string propertyName, string value)
            {
                Debug.Assert(!string.IsNullOrEmpty(propertyName));

                if (!int.TryParse(value, out var result))
                    throw new ApplicationException($"Value of the {propertyName} property must be integer, but it is {value}.");

                if (result <= 0)
                    throw new ApplicationException($"Value of the {propertyName} property must be greater then zero, but it is {result}.");

                return result;
            }
        }

        public static LimitRepository Load(string xmlFilePath = "Limits.xml", bool fallbackOnError = false)
        {
            if (string.IsNullOrWhiteSpace(xmlFilePath))
                throw new ArgumentException("File path must be specified.", nameof(xmlFilePath));

            try
            {
                using (var loader = new Loader(xmlFilePath))
                    return loader.Load();
            }
            catch
            {
                if (fallbackOnError)
                    return new LimitRepository
                    {
                        _defaultLimit = new Limit(10, 1000, 3, 36, 2, 26),
                        _limits = new Dictionary<Currency, Limit>()
                    };

                throw;
            }
        }

        private Limit _defaultLimit;
        private Dictionary<Currency, Limit> _limits;

        private LimitRepository() {}

        public Limit Get(Currency currency)
        {
            Debug.Assert(_defaultLimit != null && _limits != null);

            return _limits.TryGetValue(currency, out var limit) ? limit : _defaultLimit;
        }

        public override string ToString()
        {
            return $"Limits: {_limits?.Count ?? 0}";
        }
    }
}
