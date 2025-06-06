namespace Chizl.RegexPatterns.Finance
{
    /// <summary>
    /// List of currency codes, country name, currency name, ISO 4217 decimal points, and their text symbol(s).<br/>
    /// According to the ISO 4217 standard some have zero minor units (meaning no "cents" or fractional parts).  
    /// These are often referred to as "zero-decimal currencies."<br/>
    /// </summary>
    public enum Currency
    {
        /// <summary>
        /// ALL - Albania Lek<br/>
        /// </summary>
        [Currency(2, ALL, "Albania", "Lek", new int[] { 76, 101, 107 })]
        ALL = 0,
        /// <summary>
        /// AFN - Afghanistan Afghani<br/>
        /// </summary>
        [Currency(2, AFN, "Afghanistan", "Afghani", new int[] { 1547 })]
        AFN,
        /// <summary>
        /// ARS - Argentina Peso<br/>
        /// </summary>
        [Currency(2, ARS, "Argentina", "Peso", new int[] { 36 })]
        ARS,
        /// <summary>
        /// AWG - Aruba Guilder<br/>
        /// </summary>
        [Currency(2, AWG, "Aruba", "Guilder", new int[] { 402 })]
        AWG,
        /// <summary>
        /// AUD - Australia Dollar<br/>
        /// </summary>
        [Currency(2, AUD, "Australia", "Dollar", new int[] { 36 })]
        AUD,
        /// <summary>
        /// AZN - Azerbaijan Manat<br/>
        /// </summary>
        [Currency(2, AZN, "Azerbaijan", "Manat", new int[] { 8380 })]
        AZN,
        /// <summary>
        /// BSD - Bahamas Dollar<br/>
        /// </summary>
        [Currency(2, BSD, "Bahamas", "Dollar", new int[] { 36 })]
        BSD,
        /// <summary>
        /// BBD - Barbados Dollar<br/>
        /// </summary>
        [Currency(2, BBD, "Barbados", "Dollar", new int[] { 36 })]
        BBD,
        /// <summary>
        /// BYN - Belarus Ruble<br/>
        /// </summary>
        [Currency(2, BYN, "Belarus", "Ruble", new int[] { 66, 114 })]
        BYN,
        /// <summary>
        /// BZD - Belize Dollar<br/>
        /// </summary>
        [Currency(2, BZD, "Belize", "Dollar", new int[] { 66, 90, 36 })]
        BZD,
        /// <summary>
        /// BMD - Bermuda Dollar<br/>
        /// </summary>
        [Currency(2, BMD, "Bermuda", "Dollar", new int[] { 36 })]
        BMD,
        /// <summary>
        /// BOB - Bolivia Bolíviano<br/>
        /// Summary: ??
        /// </summary>
        [Currency(2, BOB, "Bolivia", "Bolíviano", new int[] { 36, 98 })]
        BOB,
        /// <summary>
        /// BAM - Bosnia and Herzegovina Convertible Mark<br/>
        /// </summary>
        [Currency(2, BAM, "Bosnia and Herzegovina", "Convertible Mark", new int[] { 75, 77 })]
        BAM,
        /// <summary>
        /// BWP - Botswana Pula<br/>
        /// </summary>
        [Currency(2, BWP, "Botswana", "Pula", new int[] { 80 })]
        BWP,
        /// <summary>
        /// BGN - Bulgaria Lev<br/>
        /// Summary: лв<br/>
        /// </summary>
        [Currency(2, BGN, "Bulgaria", "Lev", new int[] { 1083, 1074 })]
        BGN,
        /// <summary>
        /// BRL - Brazil Real<br/>
        /// </summary>
        [Currency(2, BRL, "Brazil", "Real", new int[] { 82, 36 })]
        BRL,
        /// <summary>
        /// BND - Brunei Darussalam Dollar<br/>
        /// </summary>
        [Currency(2, BND, "Brunei Darussalam", "Dollar", new int[] { 36 })]
        BND,
        /// <summary>
        /// KHR - Cambodia Riel<br/>
        /// </summary>
        [Currency(2, KHR, "Cambodia", "Riel", new int[] { 6107 })]
        KHR,
        /// <summary>
        /// CAD - Canada Dollar<br/>
        /// </summary>
        [Currency(2, CAD, "Canada", "Dollar", new int[] { 36 })]
        CAD,
        /// <summary>
        /// KYD - Cayman Islands Dollar<br/>
        /// </summary>
        [Currency(2, KYD, "Cayman Islands", "Dollar", new int[] { 36 })]
        KYD,
        /// <summary>
        /// CLP - Chilean Peso<br/>
        /// Symbol: $ (Dollar Sign)<br/>
        /// </summary>
        [Currency(0, CLP, "Chilean", "Peso", new int[] { 0x0000024 })]
        CLP,
        /// <summary>
        /// CNY - China Yuan Renminbi<br/>
        /// </summary>
        [Currency(2, CNY, "China Yuan", "Renminbi", new int[] { 165 })]
        CNY,
        /// <summary>
        /// COP - Colombia Peso<br/>
        /// </summary>
        [Currency(2, COP, "Colombia", "Peso", new int[] { 36 })]
        COP,
        /// <summary>
        /// CRC - Costa Rica Colon<br/>
        /// </summary>
        [Currency(2, CRC, "Costa Rica", "Colon", new int[] { 8353 })]
        CRC,
        /// <summary>
        /// HRK - Croatia Kuna<br/>
        /// </summary>
        [Currency(2, HRK, "Croatia", "Kuna", new int[] { 107, 110 })]
        HRK,
        /// <summary>
        /// CUP - Cuba Peso<br/>
        /// </summary>
        [Currency(2, CUP, "Cuba", "Peso", new int[] { 8369 })]
        CUP,
        /// <summary>
        /// CZK - Czech Republic Koruna<br/>
        /// </summary>
        [Currency(2, CZK, "Czech Republic", "Koruna", new int[] { 75, 269 })]
        CZK,
        /// <summary>
        /// DKK - Denmark Krone<br/>
        /// </summary>
        [Currency(2, DKK, "Denmark", "Krone", new int[] { 107, 114 })]
        DKK,
        /// <summary>
        /// DOP - Dominican Republic Peso<br/>
        /// </summary>
        [Currency(2, DOP, "Dominican Republic", "Peso", new int[] { 82, 68, 36 })]
        DOP,
        /// <summary>
        /// XCD - East Caribbean Dollar<br/>
        /// </summary>
        [Currency(2, XCD, "East Caribbean", "Dollar", new int[] { 36 })]
        XCD,
        /// <summary>
        /// EGP - Egypt Pound<br/>
        /// </summary>
        [Currency(2, EGP, "Egypt", "Pound", new int[] { 163 })]
        EGP,
        /// <summary>
        /// SVC - El Salvador Colon<br/>
        /// </summary>
        [Currency(2, SVC, "El Salvador", "Colon", new int[] { 36 })]
        SVC,
        /// <summary>
        /// EUR - Euro Member Countries<br/>
        /// </summary>
        [Currency(2, EUR, "European Union, Eurozone", "Euro", new int[] { 8364 })]
        EUR,
        /// <summary>
        /// FKP - Falkland Islands (Malvinas) Pound<br/>
        /// </summary>
        [Currency(2, FKP, "Falkland Islands (Malvinas)", "Pound", new int[] { 163 })]
        FKP,
        /// <summary>
        /// FJD - Fiji Dollar<br/>
        /// </summary>
        [Currency(2, FJD, "Fiji", "Dollar", new int[] { 36 })]
        FJD,
        /// <summary>
        /// GHS - Ghana Cedi<br/>
        /// </summary>
        [Currency(2, GHS, "Ghana", "Cedi", new int[] { 162 })]
        GHS,
        /// <summary>
        /// GIP - Gibraltar Pound<br/>
        /// </summary>
        [Currency(2, GIP, "Gibraltar", "Pound", new int[] { 163 })]
        GIP,
        /// <summary>
        /// GTQ - Guatemala Quetzal<br/>
        /// </summary>
        [Currency(2, GTQ, "Guatemala", "Quetzal", new int[] { 81 })]
        GTQ,
        /// <summary>
        /// GGP - Guernsey Pound<br/>
        /// </summary>
        [Currency(2, GGP, "Guernsey", "Pound", new int[] { 163 })]
        GGP,
        /// <summary>
        /// GYD - Guyana Dollar<br/>
        /// </summary>
        [Currency(2, GYD, "Guyana", "Dollar", new int[] { 36 })]
        GYD,
        /// <summary>
        /// HNL - Honduras Lempira<br/>
        /// </summary>
        [Currency(2, HNL, "Honduras", "Lempira", new int[] { 76 })]
        HNL,
        /// <summary>
        /// HKD - Hong Kong Dollar<br/>
        /// </summary>
        [Currency(2, HKD, "Hong Kong", "Dollar", new int[] { 36 })]
        HKD,
        /// <summary>
        /// HUF - Hungary Forint<br/>
        /// </summary>
        [Currency(2, HUF, "Hungary", "Forint", new int[] { 70, 116 })]
        HUF,
        /// <summary>
        /// ISK - Icelandic Króna<br/>
        /// Symbol: kr (There isn't a dedicated Unicode character.)<br/>
        /// Icelandic Króna (though some systems might still use two decimals for processing, officially it's zero)<br/>
        /// </summary>
        [Currency(0, ISK, "Icelandic", "Króna", new int[] { 0x000006B, 0x0000072 })]
        ISK,
        /// <summary>
        /// INR - India Rupee<br/>
        /// </summary>
        [Currency(2, INR, "India", "Rupee", new int[] { 8377 })]
        INR,
        /// <summary>
        /// IDR - Indonesia Rupiah<br/>
        /// Official Decimal Point: 0 (though some sources list 2)<br/>
        /// </summary>
        [Currency(2, IDR, "Indonesia", "Rupiah", new int[] { 82, 112 })]
        IDR,
        /// <summary>
        /// IRR - Iran Rial<br/>
        /// </summary>
        [Currency(2, IRR, "Iran", "Rial", new int[] { 65020 })]
        IRR,
        /// <summary>
        /// IMP - Isle of Man Pound<br/>
        /// </summary>
        [Currency(2, IMP, "Isle of Man", "Pound", new int[] { 163 })]
        IMP,
        /// <summary>
        /// ILS - Israel Shekel<br/>
        /// </summary>
        [Currency(2, ILS, "Israel", "Shekel", new int[] { 8362 })]
        ILS,
        /// <summary>
        /// JMD - Jamaica Dollar<br/>
        /// </summary>
        [Currency(2, JMD, "Jamaica", "Dollar", new int[] { 74, 36 })]
        JMD,
        /// <summary>
        /// JPY - Japan/Japanese Yen<br/>
        /// Symbol: ¥ (Yen Sign)<br/>
        /// Official Decimal Point: 0<br/>
        /// </summary>
        [Currency(0, JPY, "Japan", "Yen", new int[] { 0x00000A5 })]
        JPY,
        /// <summary>
        /// JEP - Jersey Pound<br/>
        /// </summary>
        [Currency(2, JEP, "Jersey", "Pound", new int[] { 163 })]
        JEP,
        /// <summary>
        /// KZT - Kazakhstan Tenge<br/>
        /// Symbol: ₸ (Kazakhstan Tenge)
        /// </summary>
        [Currency(2, KZT, "Kazakhstan", "Tenge", new int[] { 8376 })]
        KZT,
        /// <summary>
        /// KPW - Korea (North) Won<br/>
        /// </summary>
        [Currency(2, KPW, "Korea (North)", "Won", new int[] { 8361 })]
        KPW,
        /// <summary>
        /// KRW - Korea (South) Won<br/>
        /// Symbol: ₩ (Won Sign)<br/>
        /// South Korean Won<br/>
        /// Official Decimal Point: 0<br/>
        /// </summary>
        [Currency(0, KRW, "South Korean", "Won", new int[] { 0x00020A9 })]
        KRW,
        /// <summary>
        /// KGS - Kyrgyzstan Som<br/>
        /// </summary>
        [Currency(2, KGS, "Kyrgyzstan", "Som", new int[] { 1089 })]
        KGS,
        /// <summary>
        /// LAK - Laos Kip<br/>
        /// </summary>
        [Currency(2, LAK, "Laos", "Kip", new int[] { 8365 })]
        LAK,
        /// <summary>
        /// LBP - Lebanon Pound<br/>
        /// </summary>
        [Currency(2, LBP, "Lebanon", "Pound", new int[] { 163 })]
        LBP,
        /// <summary>
        /// LRD - Liberia Dollar<br/>
        /// </summary>
        [Currency(2, LRD, "Liberia", "Dollar", new int[] { 36 })]
        LRD,
        /// <summary>
        /// MKD - Macedonia Denar<br/>
        /// </summary>
        [Currency(2, MKD, "Macedonia", "Denar", new int[] { 1076, 1077, 1085 })]
        MKD,
        /// <summary>
        /// MYR - Malaysia Ringgit<br/>
        /// </summary>
        [Currency(2, MYR, "Malaysia", "Ringgit", new int[] { 82, 77 })]
        MYR,
        /// <summary>
        /// MUR - Mauritius Rupee<br/>
        /// </summary>
        [Currency(2, MUR, "Mauritius", "Rupee", new int[] { 8360 })]
        MUR,
        /// <summary>
        /// MXN - Mexico Peso<br/>
        /// </summary>
        [Currency(2, MXN, "Mexico", "Peso", new int[] { 36 })]
        MXN,
        /// <summary>
        /// MNT - Mongolia Tughrik<br/>
        /// </summary>
        [Currency(2, MNT, "Mongolia", "Tughrik", new int[] { 8366 })]
        MNT,
        /// <summary>
        /// MZN - Mozambique Metical<br/>
        /// </summary>
        [Currency(2, MZN, "Mozambique", "Metical", new int[] { 77, 84 })]
        MZN,
        /// <summary>
        /// NAD - Namibia Dollar<br/>
        /// </summary>
        [Currency(2, NAD, "Namibia", "Dollar", new int[] { 36 })]
        NAD,
        /// <summary>
        /// NPR - Nepal Rupee<br/>
        /// </summary>
        [Currency(2, NPR, "Nepal", "Rupee", new int[] { 8360 })]
        NPR,
        /// <summary>
        /// ANG - Netherlands Antilles Guilder<br/>
        /// </summary>
        [Currency(2, ANG, "Netherlands Antilles", "Guilder", new int[] { 402 })]
        ANG,
        /// <summary>
        /// NZD - New Zealand Dollar<br/>
        /// </summary>
        [Currency(2, NZD, "New Zealand", "Dollar", new int[] { 36 })]
        NZD,
        /// <summary>
        /// NIO - Nicaragua Cordoba<br/>
        /// </summary>
        [Currency(2, NIO, "Nicaragua", "Cordoba", new int[] { 67, 36 })]
        NIO,
        /// <summary>
        /// NGN - Nigeria Naira<br/>
        /// </summary>
        [Currency(2, NGN, "Nigeria", "Naira", new int[] { 8358 })]
        NGN,
        /// <summary>
        /// NOK - Norway Krone<br/>
        /// </summary>
        [Currency(2, NOK, "Norway", "Krone", new int[] { 107, 114 })]
        NOK,
        /// <summary>
        /// OMR - Oman Rial<br/>
        /// </summary>
        [Currency(2, OMR, "Oman", "Rial", new int[] { 65020 })]
        OMR,
        /// <summary>
        /// PKR - Pakistan Rupee<br/>
        /// </summary>
        [Currency(2, PKR, "Pakistan", "Rupee", new int[] { 8360 })]
        PKR,
        /// <summary>
        /// PAB - Panama Balboa<br/>
        /// </summary>
        [Currency(2, PAB, "Panama", "Balboa", new int[] { 66, 47, 46 })]
        PAB,
        /// <summary>
        /// PYG - Paraguayan Guarani<br/>
        /// Symbol: ₲ (Guarani Sign)<br/>
        /// Official Decimal Point: 0<br/>
        /// </summary>
        [Currency(0, PYG, "Paraguayan", "Guarani", new int[] { 0x00020B2 })]
        PYG,
        /// <summary>
        /// PEN - Peru Sol<br/>
        /// </summary>
        [Currency(2, PEN, "Peru", "Sol", new int[] { 83, 47, 46 })]
        PEN,
        /// <summary>
        /// PHP - Philippines Peso<br/>
        /// </summary>
        [Currency(2, PHP, "Philippines", "Peso", new int[] { 8369 })]
        PHP,
        /// <summary>
        /// PLN - Poland Zloty<br/>
        /// </summary>
        [Currency(2, PLN, "Poland", "Zloty", new int[] { 122, 322 })]
        PLN,
        /// <summary>
        /// QAR - Qatar Riyal<br/>
        /// </summary>
        [Currency(2, QAR, "Qatar", "Riyal", new int[] { 65020 })]
        QAR,
        /// <summary>
        /// RON - Romania Leu<br/>
        /// </summary>
        [Currency(2, RON, "Romania", "Leu", new int[] { 108, 101, 105 })]
        RON,
        /// <summary>
        /// RUB - Russia Ruble<br/>
        /// </summary>
        [Currency(2, RUB, "Russia", "Ruble", new int[] { 8381 })]
        RUB,
        /// <summary>
        /// SHP - Saint Helena Pound<br/>
        /// </summary>
        [Currency(2, SHP, "Saint Helena", "Pound", new int[] { 163 })]
        SHP,
        /// <summary>
        /// SAR - Saudi Arabia Riyal<br/>
        /// </summary>
        [Currency(2, SAR, "Saudi Arabia", "Riyal", new int[] { 65020 })]
        SAR,
        /// <summary>
        /// RSD - Serbia Dinar<br/>
        /// Symbol: дин
        /// </summary>
        [Currency(2, RSD, "Serbia", "Dinar", new int[] { 1044, 1080, 1085, 46 })]
        RSD,
        /// <summary>
        /// SCR - Seychelles Rupee<br/>
        /// </summary>
        [Currency(2, SCR, "Seychelles", "Rupee", new int[] { 8360 })]
        SCR,
        /// <summary>
        /// SGD - Singapore Dollar<br/>
        /// </summary>
        [Currency(2, SGD, "Singapore", "Dollar", new int[] { 36 })]
        SGD,
        /// <summary>
        /// SBD - Solomon Islands Dollar<br/>
        /// </summary>
        [Currency(2, SBD, "Solomon Islands", "Dollar", new int[] { 36 })]
        SBD,
        /// <summary>
        /// SOS - Somalia Shilling<br/>
        /// </summary>
        [Currency(2, SOS, "Somalia", "Shilling", new int[] { 83 })]
        SOS,
        /// <summary>
        /// ZAR - South Africa Rand<br/>
        /// </summary>
        [Currency(2, ZAR, "South Africa", "Rand", new int[] { 82 })]
        ZAR,
        /// <summary>
        /// LKR - Sri Lanka Rupee<br/>
        /// </summary>
        [Currency(2, LKR, "Sri Lanka", "Rupee", new int[] { 8360 })]
        LKR,
        /// <summary>
        /// SEK - Sweden Krona<br/>
        /// </summary>
        [Currency(2, SEK, "Sweden", "Krona", new int[] { 107, 114 })]
        SEK,
        /// <summary>
        /// CHF - Switzerland Franc<br/>
        /// </summary>
        [Currency(2, CHF, "Switzerland", "Franc", new int[] { 67, 72, 70 })]
        CHF,
        /// <summary>
        /// SRD - Suriname Dollar<br/>
        /// </summary>
        [Currency(2, SRD, "Suriname", "Dollar", new int[] { 36 })]
        SRD,
        /// <summary>
        /// SYP - Syria Pound<br/>
        /// </summary>
        [Currency(2, SYP, "Syria", "Pound", new int[] { 163 })]
        SYP,
        /// <summary>
        /// TWD - Taiwan New Dollar<br/>
        /// </summary>
        [Currency(2, TWD, "Taiwan New", "Dollar", new int[] { 78, 84, 36 })]
        TWD,
        /// <summary>
        /// THB - Thailand Baht<br/>
        /// </summary>
        [Currency(2, THB, "Thailand", "Baht", new int[] { 3647 })]
        THB,
        /// <summary>
        /// TTD - Trinidad and Tobago Dollar<br/>
        /// </summary>
        [Currency(2, TTD, "Trinidad and Tobago", "Dollar", new int[] { 84, 84, 36 })]
        TTD,
        /// <summary>
        /// TRY - Turkey Lira<br/>
        /// </summary>
        [Currency(2, TRY, "Turkey", "Lira", new int[] { 8378 })]
        TRY,
        /// <summary>
        /// TVD - Tuvalu Dollar<br/>
        /// </summary>
        [Currency(2, TVD, "Tuvalu", "Dollar", new int[] { 36 })]
        TVD,
        /// <summary>
        /// UAH - Ukraine Hryvnia<br/>
        /// </summary>
        [Currency(2, UAH, "Ukraine", "Hryvnia", new int[] { 8372 })]
        UAH,
        /// <summary>
        /// GBP - United Kingdom Pound<br/>
        /// </summary>
        [Currency(2, GBP, "United Kingdom", "Pound", new int[] { 163 })]
        GBP,
        /// <summary>
        /// USD - United States Dollar<br/>
        /// </summary>
        [Currency(2, USD, "United States", "Dollar", new int[] { 36 })]
        USD,
        /// <summary>
        /// UYU - Uruguay Peso<br/>
        /// </summary>
        [Currency(2, UYU, "Uruguay", "Peso", new int[] { 36, 85 })]
        UYU,
        /// <summary>
        /// UZS - Uzbekistan Som<br/>
        /// Symbol: so'm
        /// </summary>
        [Currency(2, UZS, "Uzbekistan", "Som", new int[] { 115, 111, 39, 109 })]
        UZS,
        /// <summary>
        /// VEF - Venezuela Bolívar<br/>
        /// </summary>
        [Currency(2, VEF, "Venezuela", "Bolívar", new int[] { 66, 115 })]
        VEF,
        /// <summary>
        /// VND - Vietnamese Đồng<br/>
        /// Symbol: ₫ (Dong Sign), or informally đ and sometimes Đ<br/>
        /// Vietnamese Đồng (officially has 2 minor units, but rarely used, often treated as zero)<br/>
        /// </summary>
        [Currency(0, VND, "Vietnamese", "Đồng", new int[] { 0x00020AB })]
        VND,
        /// <summary>
        /// YER - Yemen Rial<br/>
        /// </summary>
        [Currency(2, YER, "Yemen", "Rial", new int[] { 65020 })]
        YER,
        /// <summary>
        /// ZWD - Zimbabwe Dollar<br/>
        /// </summary>
        [Currency(2, ZWD, "Zimbabwe", "Dollar", new int[] { 90, 36 })]
        ZWD,
        /// <summary>
        /// BIF - Burundian Franc<br/>
        /// Symbol: FBu (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, BIF, "Burundian", "Franc", new int[] { 0x0000046, 0x0000042, 0x0000075 })]
        BIF,
        /// <summary>
        /// DJF - Djiboutian Franc<br/>
        /// Symbol: ??<br/>
        /// </summary>
        [Currency(0, DJF, "Djiboutian", "Franc", new int[] { 0x0000046, 0x0000064, 0x000006A })]
        DJF,
        /// <summary>
        /// GNF - Guinean Franc<br/>
        /// Symbol: FG (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, GNF, "Guinean", "Franc", new int[] { 0x0000046, 0x0000047 })]
        GNF,
        /// <summary>
        /// KMF - Comorian Franc<br/>
        /// Symbol: FC (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, KMF, "Comorian", "Franc", new int[] { 0x0000046, 0x0000043 })]
        KMF,
        /// <summary>
        /// MGA - Malagasy Ariary<br/>
        /// Symbol: Ar (There isn't a dedicated Unicode character.)<br/>
        /// Official Decimal Point is often expressed as 0 for practical purposes: 0<br/>
        /// </summary>
        [Currency(0, MGA, "Malagasy", "Ariary", new int[] { 0x0000041, 0x0000072 })]
        MGA,
        /// <summary>
        /// RWF - Rwandan Franc<br/>
        /// Symbol: FRw (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, RWF, "Rwandan", "Franc", new int[] { 0x0000046, 0x0000052, 0x0000077 })]
        RWF,
        /// <summary>
        /// UGX - Ugandan Shilling<br/>
        /// Symbol: Sh (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, UGX, "Ugandan", "Shilling", new int[] { 0x0000053, 0x0000068 })]
        UGX,
        /// <summary>
        /// VUV - Vanuatu Vatu<br/>
        /// Symbol: VT (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, VUV, "Vanuatu", "Vatu", new int[] { 0x0000056, 0x0000054 })]
        VUV,
        /// <summary>
        /// XAF - Central African CFA Franc<br/>
        /// Symbol: FCFA (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, XAF, "Central African CFA", "Franc", new int[] { 0x0000046, 0x0000043, 0x0000046, 0x0000041 })]
        XAF,
        /// <summary>
        /// XOF - West African CFA Franc<br/>
        /// Symbol: FCFA (There isn't a dedicated Unicode character.)<br/>
        /// </summary>
        [Currency(0, XOF, "West African CFA", "Franc", new int[] { 0x0000046, 0x0000043, 0x0000046, 0x0000041 })]
        XOF,
        /// <summary>
        /// XPF - CFP Franc<br/>
        /// Symbol: ₣ (French Franc Sign - often used as a generic franc symbol, but CFP Franc specific is '₣') or just 'F'. The most commonly used for CFP Franc is a simple 'F'.<br/>
        /// </summary>
        [Currency(0, XPF, "CFP", "Franc", new int[] { 0x00020A3, 0x0000046 })]
        XPF,
        /// <summary>
        /// AMD - Armenia Dram<br/>
        /// </summary>
        [Currency(2, AMD, "Armenia", "Dram", new int[] { 10255 })]
        AMD,
        /// <summary>
        /// BDT - Bangladesh Taka<br/>
        /// </summary>
        [Currency(2, BDT, "Bangladesh", "Taka", new int[] { 2547 })]
        BDT,
        /// <summary>
        /// ETB - Ethiopia Birr<br/>
        /// Symbol: Br<br/>
        /// </summary>
        [Currency(2, ETB, "Ethiopia", "Birr", new int[] { 66, 114 })]
        ETB,
        /// <summary>
        /// GEL - Georgia Lari<br/>
        /// </summary>
        [Currency(2, GEL, "Georgia", "Lari", new int[] { 8382 })]
        GEL,
        /// <summary>
        /// HTG - Haiti Gourde<br/>
        /// Symbol: G<br/>
        /// </summary>
        [Currency(2, HTG, "Haiti", "Gourde", new int[] { 71 })]
        HTG,
        /// <summary>
        /// MWK - Malawi Kwacha<br/>
        /// Symbol: MK<br/>
        /// </summary>
        [Currency(0, MWK, "Malawi", "Kwacha", new int[] { 77, 75 })]
        MWK,
        /// <summary>
        /// MRU - Mauritania Ouguiya<br/>
        /// Symbol: UM<br/>
        /// </summary>
        [Currency(2, MRU, "Mauritania", "Ouguiya", new int[] { 85, 77 })]
        MRU,
        /// <summary>
        /// DZD - Algeria Dinar<br/>
        /// Symbol: د.ج<br/>
        /// </summary>
        [Currency(2, DZD, "Algeria", "Dinar", new int[] { 1583, 46, 1580 })]
        DZD,
        /// <summary>
        /// BHD - Bahrain Dinar<br/>
        /// Symbol: ب.د<br/>
        /// </summary>
        [Currency(3, BHD, "Bahrain", "Dinar", new int[] { 1576, 46, 1583 })]
        BHD,
        /// <summary>
        /// IQD - Iraq Dinar<br/>
        /// Symbol: ع.د<br/>
        /// </summary>
        [Currency(3, IQD, "Iraq", "Dinar", new int[] { 1593, 46, 1583 })]
        IQD,
        /// <summary>
        /// JOD - Jordan Dinar<br/>
        /// Symbol: د.ا<br/>
        /// </summary>
        [Currency(3, JOD, "Jordan", "Dinar", new int[] { 1583, 46, 1575 })]
        JOD,
        /// <summary>
        /// KWD - Kuwait Dinar<br/>
        /// Symbol: د.ك<br/>
        /// </summary>
        [Currency(3, KWD, "Kuwait", "Dinar", new int[] { 1583, 46, 1603 })]
        KWD,
        /// <summary>
        /// LYD - Libya Dinar<br/>
        /// Symbol: ل.د<br/>
        /// </summary>
        [Currency(3, LYD, "Libya", "Dinar", new int[] { 1604, 46, 1583 })]
        LYD,
        /// <summary>
        /// TND - Tunisia Dinar<br/>
        /// Symbol: د.ت<br/>
        /// </summary>
        [Currency(3, TND, "Tunisia", "Dinar", new int[] { 1583, 46, 1578 })]
        TND,
    }
}
