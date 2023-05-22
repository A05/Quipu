using Sx.Vx.Quipu.Domain;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Sx.Vx.Quipu.WinUI
{
    // TODO: (NU) Implement IXmlSerializable for the encapsulation.

    [XmlRoot(ElementName = "Limits")]
    public class LimitRepository
    {
        public static LimitRepository Load()
        {
            LimitRepository repository;

            var s = new XmlSerializer(typeof(LimitRepository));
            using (var file = File.OpenRead(Path.Combine(Environment.CurrentDirectory, "Limits.xml")))
                repository = (LimitRepository)s.Deserialize(file);

            repository.EnsureDefaultLimitIsSet();

            return repository;
        }

        private Limit _defaultLimit;

        [XmlElement(ElementName = "Limit")]
        public Limit[] __limits; // For internal use only.

        private LimitRepository() {}

        public Limit Get(Currency currency)
        {
            Debug.Assert(_defaultLimit != null);

            var limit = __limits.FirstOrDefault(i => i.CurrencyAlphabeticCode == currency.AlphabeticCode);
                       
            return limit ?? _defaultLimit;
        }

        public override string ToString()
        {
            return $"Limits: {__limits.Length}";
        }

        private void EnsureDefaultLimitIsSet()
        {
            Debug.Assert(_defaultLimit == null);

            _defaultLimit = __limits.FirstOrDefault(i => string.IsNullOrEmpty(i.CurrencyAlphabeticCode));
            if (_defaultLimit == null)
                throw new ApplicationException("Failed to find the default limit.");
        }
    }
}
