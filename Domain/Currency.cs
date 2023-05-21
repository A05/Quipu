using System;
using System.Collections.Generic;

namespace Sx.Vx.Quipu.Domain
{
    public struct Currency : IEquatable<Currency>, IComparable<Currency>
    {
        public static readonly Currency Empty = new Currency();

        public static readonly Currency AED = new Currency("AED", 784, 2, "United Arab Emirates dirham");
        public static readonly Currency AFN = new Currency("AFN", 971, 2, "Afghan afghani");
        public static readonly Currency ALL = new Currency("ALL", 8, 2, "Albanian lek");
        public static readonly Currency AMD = new Currency("AMD", 51, 2, "Armenian dram");
        public static readonly Currency ANG = new Currency("ANG", 532, 2, "Netherlands Antillean guilder");
        public static readonly Currency AOA = new Currency("AOA", 973, 2, "Angolan kwanza");
        public static readonly Currency ARS = new Currency("ARS", 32, 2, "Argentine peso");
        public static readonly Currency AUD = new Currency("AUD", 36, 2, "Australian dollar");
        public static readonly Currency AWG = new Currency("AWG", 533, 2, "Aruban florin");
        public static readonly Currency AZN = new Currency("AZN", 944, 2, "Azerbaijani manat");
        public static readonly Currency BAM = new Currency("BAM", 977, 2, "Bosnia and Herzegovina convertible mark");
        public static readonly Currency BBD = new Currency("BBD", 52, 2, "Barbados dollar");
        public static readonly Currency BDT = new Currency("BDT", 50, 2, "Bangladeshi taka");
        public static readonly Currency BGN = new Currency("BGN", 975, 2, "Bulgarian lev");
        public static readonly Currency BHD = new Currency("BHD", 48, 3, "Bahraini dinar");
        public static readonly Currency BIF = new Currency("BIF", 108, 0, "Burundian franc");
        public static readonly Currency BMD = new Currency("BMD", 60, 2, "Bermudian dollar");
        public static readonly Currency BND = new Currency("BND", 96, 2, "Brunei dollar");
        public static readonly Currency BOB = new Currency("BOB", 68, 2, "Boliviano");
        public static readonly Currency BRL = new Currency("BRL", 986, 2, "Brazilian real");
        public static readonly Currency BSD = new Currency("BSD", 44, 2, "Bahamian dollar");
        public static readonly Currency BTN = new Currency("BTN", 64, 2, "Bhutanese ngultrum");
        public static readonly Currency BWP = new Currency("BWP", 72, 2, "Botswana pula");
        public static readonly Currency BYN = new Currency("BYN", 933, 2, "Belarusian ruble");
        public static readonly Currency BZD = new Currency("BZD", 84, 2, "Belize dollar");
        public static readonly Currency CAD = new Currency("CAD", 124, 2, "Canadian dollar");
        public static readonly Currency CDF = new Currency("CDF", 976, 2, "Congolese franc");
        public static readonly Currency CHF = new Currency("CHF", 756, 2, "Swiss franc");
        public static readonly Currency CLP = new Currency("CLP", 152, 0, "Chilean peso");
        public static readonly Currency COP = new Currency("COP", 170, 2, "Colombian peso");
        public static readonly Currency CRC = new Currency("CRC", 188, 2, "Costa Rican colon");
        public static readonly Currency CUC = new Currency("CUC", 931, 2, "Cuban convertible peso");
        public static readonly Currency CUP = new Currency("CUP", 192, 2, "Cuban peso");
        public static readonly Currency CVE = new Currency("CVE", 132, 2, "Cape Verdean escudo");
        public static readonly Currency CZK = new Currency("CZK", 203, 2, "Czech koruna");
        public static readonly Currency DJF = new Currency("DJF", 262, 0, "Djiboutian franc");
        public static readonly Currency DKK = new Currency("DKK", 208, 2, "Danish krone");
        public static readonly Currency DOP = new Currency("DOP", 214, 2, "Dominican peso");
        public static readonly Currency DZD = new Currency("DZD", 12, 2, "Algerian dinar");
        public static readonly Currency EGP = new Currency("EGP", 818, 2, "Egyptian pound");
        public static readonly Currency ERN = new Currency("ERN", 232, 2, "Eritrean nakfa");
        public static readonly Currency ETB = new Currency("ETB", 230, 2, "Ethiopian birr");
        public static readonly Currency EUR = new Currency("EUR", 978, 2, "Euro");
        public static readonly Currency FJD = new Currency("FJD", 242, 2, "Fiji dollar");
        public static readonly Currency FKP = new Currency("FKP", 238, 2, "Falkland Islands pound");
        public static readonly Currency GBP = new Currency("GBP", 826, 2, "Pound sterling");
        public static readonly Currency GEL = new Currency("GEL", 981, 2, "Georgian lari");
        public static readonly Currency GHS = new Currency("GHS", 936, 2, "Ghanaian cedi");
        public static readonly Currency GIP = new Currency("GIP", 292, 2, "Gibraltar pound");
        public static readonly Currency GMD = new Currency("GMD", 270, 2, "Gambian dalasi");
        public static readonly Currency GNF = new Currency("GNF", 324, 0, "Guinean franc");
        public static readonly Currency GTQ = new Currency("GTQ", 320, 2, "Guatemalan quetzal");
        public static readonly Currency GYD = new Currency("GYD", 328, 2, "Guyanese dollar");
        public static readonly Currency HKD = new Currency("HKD", 344, 2, "Hong Kong dollar");
        public static readonly Currency HNL = new Currency("HNL", 340, 2, "Honduran lempira");
        public static readonly Currency HTG = new Currency("HTG", 332, 2, "Haitian gourde");
        public static readonly Currency HUF = new Currency("HUF", 348, 2, "Hungarian forint");
        public static readonly Currency IDR = new Currency("IDR", 360, 2, "Indonesian rupiah");
        public static readonly Currency ILS = new Currency("ILS", 376, 2, "Israeli new shekel");
        public static readonly Currency INR = new Currency("INR", 356, 2, "Indian rupee");
        public static readonly Currency IQD = new Currency("IQD", 368, 3, "Iraqi dinar");
        public static readonly Currency IRR = new Currency("IRR", 364, 2, "Iranian rial");
        public static readonly Currency ISK = new Currency("ISK", 352, 0, "Icelandic króna");
        public static readonly Currency JMD = new Currency("JMD", 388, 2, "Jamaican dollar");
        public static readonly Currency JOD = new Currency("JOD", 400, 3, "Jordanian dinar");
        public static readonly Currency JPY = new Currency("JPY", 392, 0, "Japanese yen");
        public static readonly Currency KES = new Currency("KES", 404, 2, "Kenyan shilling");
        public static readonly Currency KGS = new Currency("KGS", 417, 2, "Kyrgyzstani som");
        public static readonly Currency KHR = new Currency("KHR", 116, 2, "Cambodian riel");
        public static readonly Currency KMF = new Currency("KMF", 174, 0, "Comoro franc");
        public static readonly Currency KPW = new Currency("KPW", 408, 2, "North Korean won");
        public static readonly Currency KRW = new Currency("KRW", 410, 0, "South Korean won");
        public static readonly Currency KWD = new Currency("KWD", 414, 3, "Kuwaiti dinar");
        public static readonly Currency KYD = new Currency("KYD", 136, 2, "Cayman Islands dollar");
        public static readonly Currency KZT = new Currency("KZT", 398, 2, "Kazakhstani tenge");
        public static readonly Currency LAK = new Currency("LAK", 418, 2, "Lao kip");
        public static readonly Currency LBP = new Currency("LBP", 422, 2, "Lebanese pound");
        public static readonly Currency LKR = new Currency("LKR", 144, 2, "Sri Lankan rupee");
        public static readonly Currency LRD = new Currency("LRD", 430, 2, "Liberian dollar");
        public static readonly Currency LSL = new Currency("LSL", 426, 2, "Lesotho loti");
        public static readonly Currency LYD = new Currency("LYD", 434, 3, "Libyan dinar");
        public static readonly Currency MAD = new Currency("MAD", 504, 2, "Moroccan dirham");
        public static readonly Currency MDL = new Currency("MDL", 498, 2, "Moldovan leu");
        public static readonly Currency MGA = new Currency("MGA", 969, 2, "Malagasy ariary");
        public static readonly Currency MKD = new Currency("MKD", 807, 2, "Macedonian denar");
        public static readonly Currency MMK = new Currency("MMK", 104, 2, "Myanmar kyat");
        public static readonly Currency MNT = new Currency("MNT", 496, 2, "Mongolian tögrög");
        public static readonly Currency MOP = new Currency("MOP", 446, 2, "Macanese pataca");
        public static readonly Currency MRU = new Currency("MRU", 929, 2, "Mauritanian ouguiya");
        public static readonly Currency MUR = new Currency("MUR", 480, 2, "Mauritian rupee");
        public static readonly Currency MVR = new Currency("MVR", 462, 2, "Maldivian rufiyaa");
        public static readonly Currency MWK = new Currency("MWK", 454, 2, "Malawian kwacha");
        public static readonly Currency MXN = new Currency("MXN", 484, 2, "Mexican peso");
        public static readonly Currency MYR = new Currency("MYR", 458, 2, "Malaysian ringgit");
        public static readonly Currency MZN = new Currency("MZN", 943, 2, "Mozambican metical");
        public static readonly Currency NAD = new Currency("NAD", 516, 2, "Namibian dollar");
        public static readonly Currency NGN = new Currency("NGN", 566, 2, "Nigerian naira");
        public static readonly Currency NIO = new Currency("NIO", 558, 2, "Nicaraguan córdoba");
        public static readonly Currency NOK = new Currency("NOK", 578, 2, "Norwegian krone");
        public static readonly Currency NPR = new Currency("NPR", 524, 2, "Nepalese rupee");
        public static readonly Currency NZD = new Currency("NZD", 554, 2, "New Zealand dollar");
        public static readonly Currency OMR = new Currency("OMR", 512, 3, "Omani rial");
        public static readonly Currency PAB = new Currency("PAB", 590, 2, "Panamanian balboa");
        public static readonly Currency PEN = new Currency("PEN", 604, 2, "Peruvian sol");
        public static readonly Currency PGK = new Currency("PGK", 598, 2, "Papua New Guinean kina");
        public static readonly Currency PHP = new Currency("PHP", 608, 2, "Philippine peso");
        public static readonly Currency PKR = new Currency("PKR", 586, 2, "Pakistani rupee");
        public static readonly Currency PLN = new Currency("PLN", 985, 2, "Polish złoty");
        public static readonly Currency PYG = new Currency("PYG", 600, 0, "Paraguayan guaraní");
        public static readonly Currency QAR = new Currency("QAR", 634, 2, "Qatari riyal");
        public static readonly Currency RON = new Currency("RON", 946, 2, "Romanian leu");
        public static readonly Currency RSD = new Currency("RSD", 941, 2, "Serbian dinar");
        public static readonly Currency CNY = new Currency("CNY", 156, 2, "Renminbi");
        public static readonly Currency RUB = new Currency("RUB", 643, 2, "Russian ruble");
        public static readonly Currency RWF = new Currency("RWF", 646, 0, "Rwandan franc");
        public static readonly Currency SAR = new Currency("SAR", 682, 2, "Saudi riyal");
        public static readonly Currency SBD = new Currency("SBD", 90, 2, "Solomon Islands dollar");
        public static readonly Currency SCR = new Currency("SCR", 690, 2, "Seychelles rupee");
        public static readonly Currency SDG = new Currency("SDG", 938, 2, "Sudanese pound");
        public static readonly Currency SEK = new Currency("SEK", 752, 2, "Swedish krona");
        public static readonly Currency SGD = new Currency("SGD", 702, 2, "Singapore dollar");
        public static readonly Currency SHP = new Currency("SHP", 654, 2, "Saint Helena pound");
        public static readonly Currency SLE = new Currency("SLE", 925, 2, "Sierra Leonean leone(new leone)");
        public static readonly Currency SLL = new Currency("SLL", 694, 2, "Sierra Leonean leone(old leone)");
        public static readonly Currency SOS = new Currency("SOS", 706, 2, "Somali shilling");
        public static readonly Currency SRD = new Currency("SRD", 968, 2, "Surinamese dollar");
        public static readonly Currency SSP = new Currency("SSP", 728, 2, "South Sudanese pound");
        public static readonly Currency STN = new Currency("STN", 930, 2, "São Tomé and Príncipe dobra");
        public static readonly Currency SVC = new Currency("SVC", 222, 2, "Salvadoran colón");
        public static readonly Currency SYP = new Currency("SYP", 760, 2, "Syrian pound");
        public static readonly Currency SZL = new Currency("SZL", 748, 2, "Swazi lilangeni");
        public static readonly Currency THB = new Currency("THB", 764, 2, "Thai baht");
        public static readonly Currency TJS = new Currency("TJS", 972, 2, "Tajikistani somoni");
        public static readonly Currency TMT = new Currency("TMT", 934, 2, "Turkmenistan manat");
        public static readonly Currency TND = new Currency("TND", 788, 3, "Tunisian dinar");
        public static readonly Currency TOP = new Currency("TOP", 776, 2, "Tongan paʻanga");
        public static readonly Currency TRY = new Currency("TRY", 949, 2, "Turkish lira");
        public static readonly Currency TTD = new Currency("TTD", 780, 2, "Trinidad and Tobago dollar");
        public static readonly Currency TWD = new Currency("TWD", 901, 2, "New Taiwan dollar");
        public static readonly Currency TZS = new Currency("TZS", 834, 2, "Tanzanian shilling");
        public static readonly Currency UAH = new Currency("UAH", 980, 2, "Ukrainian hryvnia");
        public static readonly Currency UGX = new Currency("UGX", 800, 0, "Ugandan shilling");
        public static readonly Currency USD = new Currency("USD", 840, 2, "United States dollar");
        public static readonly Currency UYI = new Currency("UYI", 940, 0, "Uruguay Peso en Unidades Indexadas");
        public static readonly Currency UYU = new Currency("UYU", 858, 2, "Uruguayan peso");
        public static readonly Currency UYW = new Currency("UYW", 927, 4, "Unidad previsional");
        public static readonly Currency UZS = new Currency("UZS", 860, 2, "Uzbekistan sum");
        public static readonly Currency VED = new Currency("VED", 926, 2, "Venezuelan digital bolívar");
        public static readonly Currency VES = new Currency("VES", 928, 2, "Venezuelan sovereign bolívar");
        public static readonly Currency VND = new Currency("VND", 704, 0, "Vietnamese đồng");
        public static readonly Currency VUV = new Currency("VUV", 548, 0, "Vanuatu vatu");
        public static readonly Currency WST = new Currency("WST", 882, 2, "Samoan tala");
        public static readonly Currency XAF = new Currency("XAF", 950, 0, "CFA franc BEAC");
        public static readonly Currency XCD = new Currency("XCD", 951, 2, "East Caribbean dollar");
        public static readonly Currency XOF = new Currency("XOF", 952, 0, "CFA franc BCEAO");
        public static readonly Currency XPF = new Currency("XPF", 953, 0, "CFP franc");
        public static readonly Currency YER = new Currency("YER", 886, 2, "Yemeni rial");
        public static readonly Currency ZAR = new Currency("ZAR", 710, 2, "South African rand");
        public static readonly Currency ZMW = new Currency("ZMW", 967, 2, "Zambian kwacha");
        public static readonly Currency ZWL = new Currency("ZWL", 932, 2, "Zimbabwean dollar");

        public static IEnumerable<Currency> Currencies { get; } = new[] 
        {
            AED, AFN, ALL, AMD, ANG, AOA, ARS, AUD, AWG, AZN, BAM, BBD, BDT, BGN,
            BHD, BIF, BMD, BND, BOB, BRL, BSD, BTN, BWP, BYN, BZD, CAD, CDF, CHF,
            CLP, COP, CRC, CUC, CUP, CVE, CZK, DJF, DKK, DOP, DZD, EGP, ERN, ETB,
            EUR, FJD, FKP, GBP, GEL, GHS, GIP, GMD, GNF, GTQ, GYD, HKD, HNL, HTG,
            HUF, IDR, ILS, INR, IQD, IRR, ISK, JMD, JOD, JPY, KES, KGS, KHR, KMF,
            KPW, KRW, KWD, KYD, KZT, LAK, LBP, LKR, LRD, LSL, LYD, MAD, MDL, MGA,
            MKD, MMK, MNT, MOP, MRU, MUR, MVR, MWK, MXN, MYR, MZN, NAD, NGN, NIO,
            NOK, NPR, NZD, OMR, PAB, PEN, PGK, PHP, PKR, PLN, PYG, QAR, RON, RSD,
            CNY, RUB, RWF, SAR, SBD, SCR, SDG, SEK, SGD, SHP, SLE, SLL, SOS, SRD,
            SSP, STN, SVC, SYP, SZL, THB, TJS, TMT, TND, TOP, TRY, TTD, TWD, TZS,
            UAH, UGX, USD, UYI, UYU, UYW, UZS, VED, VES, VND, VUV, WST, XAF, XCD,
            XOF, XPF, YER, ZAR, ZMW, ZWL
        };

        private readonly string _toString;

        public string AlphabeticCode { get; }
        public ushort NumericCode { get; }
        public byte Precision { get; }
        public string Name { get; }

        private Currency(string alphabeticCode, ushort numericCode, byte precision, string name)
        {
            AlphabeticCode = alphabeticCode;
            NumericCode = numericCode;
            Precision = precision;
            Name = name;

            _toString = $"{AlphabeticCode},{NumericCode:000},{Precision},{Name}";
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Currency other && Equals(other);
                
        }

        public bool Equals(Currency other)
        {
            return
                NumericCode == other.NumericCode &&
                Precision == other.Precision &&
                AlphabeticCode == other.AlphabeticCode &&
                Name == other.Name;
        }

        public int CompareTo(Currency other)
        {
            return AlphabeticCode.CompareTo(other.AlphabeticCode);
        }

        public static bool operator ==(Currency c1, Currency c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Currency c1, Currency c2)
        {
            return !c1.Equals(c2);
        }

        public override int GetHashCode()
        {
            return NumericCode;
        }

        public override string ToString()
        {
            return _toString ?? "Empty";
        }
    }
}
