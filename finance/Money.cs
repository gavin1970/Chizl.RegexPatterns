namespace Chizl.RegexPatterns.Finance
{
    public sealed class Money : RegexBase
    {
        /// <summary>
        /// Insurance that it can only be initialized from within this library.
        /// </summary>
        internal Money() { }

        #region Templates
        const string _symbolReqTemplate = "[{0}]";
        const string _symbolOptTemplate = "[{0}?]";
        const string _majorUnitTemplate = @"[0-9]";
        const string _majorUnitOptTemplate = "([0-9]?){0,_MAX_}";
        const string _minorUnitTemplate = @"\.[0-9]";
        const string _minorUnitOptTemplate = @"\.?[0-9?]{0,_MAX_}";
        #endregion

        #region Defaults
        private Currency _currency = Currency.USD;
        private DisplayStatus _currencySymbolStatus = DisplayStatus.Optional;
        private UnitStatus _majorUnitStatus = UnitStatus.Required;
        private UnitStatus _minorUnitStatus = UnitStatus.Deny;
        private MinMax _majorUnitLength = MinMax.SetRange(0, 12);
        private MinMax _minorUnitLength = MinMax.SetRange(0, 4);
        #endregion

        #region Private vars and defaults for properties
        private string _currencySymbol = string.Empty;
        private string _currencySymbolDisplay = string.Empty;
        private string _countryName = string.Empty;
        private string _currencyName = string.Empty;
        private int _decimalPoint = 2;
        private bool _hasMinorUnits = true;
        #endregion

        #region Public Properties
        /// <summary>
        /// Sets the currency, and will set pattern with correct Symbol.<br/>
        /// Will also be used to auto skip MinorUnits if Currency doesn't support it.<br/>
        /// Default: USD<br/>
        /// </summary>
        public Currency Currency 
        { 
            set 
            { 
                _currency = value; 
                ClearPatterns();
                _minorUnitStatus = ValidateCurrency(_minorUnitStatus);
                RefreshPatterns();
            } 
            get { return _currency; } }
        /// <summary>
        /// Set if the Currency Symbol is Reqired, Optional, or Deny<br/>
        /// Default: Optional
        /// </summary>
        public DisplayStatus CurrencySymbolStatus 
        { 
            set 
            { 
                _currencySymbolStatus = value;
                RefreshPatterns();
            }
            get { return _currencySymbolStatus; } 
        }
        /// <summary>
        /// Sets the minimum and maximum length of the MajorUnit (aka Dollar), without MinorUnit (aka Cents).<br/>
        /// Default: Optional<br/>
        /// </summary>
        public UnitStatus MajorUnitStatus 
        { 
            set 
            { 
                _majorUnitStatus = value;
                RefreshPatterns();
            }
            get { return _majorUnitStatus; } 
        }
        /// <summary>
        /// Sets the minimum and maximum length of the MinorUnit (aka Cents).<br/>
        /// Default: Optional<br/>
        /// </summary>
        public UnitStatus MinorUnitStatus 
        { 
            set 
            { 
                _minorUnitStatus = ValidateCurrency(value);
                RefreshPatterns();
            }
            get { return _minorUnitStatus; } 
        }
        /// <summary>
        /// Setup the MajorUnit (Dollars) length
        /// </summary>
        public MinMax MajorUnitLength 
        { 
            get { return _majorUnitLength; } 
        }
        /// <summary>
        /// Setup the MinorUnit (Cents) length
        /// </summary>
        public MinMax MinorUnitLength 
        { 
            get { return _minorUnitLength; } 
        }
        /// <summary>
        /// ISO 4217 standard decimal points for this currency.
        /// </summary>
        public int DecimalPoint
        {
            get { return _decimalPoint; }
        }
        /// <summary>
        /// Displays the Currency Symbol in string form.
        /// </summary>
        public string CurrencySymbol
        {
            get
            {
                lock (_locker)
                    return _currencySymbol;
            }
        }
        /// <summary>
        /// Displays the Currency Symbol in string form without escapes.
        /// </summary>
        public string CurrencySymbolDisplay
        {
            get
            {
                lock (_locker)
                    return _currencySymbol.Replace("\\", "");
            }
        }
        /// <summary>
        /// Currency Name
        /// </summary>
        public string CurrencyName 
        { 
            get 
            { 
                lock (_locker)
                    return _currencyName; 
            }
        }
        /// <summary>
        /// Currency's Country / Union Name
        /// </summary>
        public string CountryName 
        { 
            get 
            { 
                lock (_locker) 
                    return _countryName; 
            } 
        }
        #endregion
        
        #region Private Methods
        /// <summary>
        /// Clear's matches to be rebuilt, because there was a change in one of the properties.
        /// </summary>
        private void ClearPatterns()
        {
            lock (_locker)
            {
                _matchPattern = string.Empty;
                _replacePattern = string.Empty;
            }
        }
        /// <summary>
        /// Setup Pattern for RegEx.Replace()
        /// </summary>
        private void SetReplacePattern()
        {
            var pattern = "";

            pattern += string.Format(_symbolReqTemplate, _currencySymbol);
            pattern += _majorUnitTemplate;

            if (_hasMinorUnits)
                pattern += _minorUnitTemplate;

            _replacePattern = pattern;
        }
        /// <summary>
        /// Setup Pattern for RegEx.Match()
        /// </summary>
        private void SetMatchPattern()
        {
            var pattern = "^";

            //Check if Symbol e.g. '$' is required.
            if (this.CurrencySymbolStatus.IsRequired())
            {
                pattern += string.Format(_symbolReqTemplate, _currencySymbol);
                pattern += "{" + _currencySymbolDisplay.Length + "}";
            }
            //Check if Symbol e.g. '$' is optional.
            else if (this.CurrencySymbolStatus.IsOptional())
            {
                pattern += string.Format(_symbolOptTemplate, _currencySymbol);
                //since it's optional, 0 means it will not be there, 1 means symbol can be max length of 1.
                pattern += "{0," + _currencySymbolDisplay.Length + "}";
            }
            // else Symbol e.g. '$' if exists will be rejected and fail during match.

            if (!this.MajorUnitStatus.IsDenied())
            {
                var majorMaxMin = string.Empty;
                if (this.MajorUnitLength.Min.Equals(this.MajorUnitLength.Max))
                    majorMaxMin = $"{{{this.MajorUnitLength.Min}}}";
                else
                    majorMaxMin = $"{{{this.MajorUnitLength.Min},{this.MajorUnitLength.Max}}}";

                pattern += this.MajorUnitStatus.IsOptional() ?
                    _majorUnitOptTemplate.Replace("_MAX_", this.MajorUnitLength.Max.ToString()) :
                    _majorUnitTemplate.Insert(_majorUnitTemplate.Length, majorMaxMin);
            }

            if (!this.MinorUnitStatus.IsDenied())
            {
                var minorMaxMin = string.Empty;
                if (this.MinorUnitLength.Min.Equals(this.MinorUnitLength.Max))
                    minorMaxMin = $"{{{this.MinorUnitLength.Min}}}";
                else
                    minorMaxMin = $"{{{this.MinorUnitLength.Min},{this.MinorUnitLength.Max}}}";

                pattern += this.MinorUnitStatus.IsOptional() ? 
                    _minorUnitOptTemplate.Replace("_MAX_", this.MinorUnitLength.Max.ToString()) :
                    _minorUnitTemplate.Insert(_minorUnitTemplate.Length, minorMaxMin); 
            }

            pattern += "$";

            _matchPattern = pattern;
        }
        /// <summary>
        /// Make sure required displays are not set for Currency with no decimal points.  If set, change to Optional.
        /// </summary>
        private UnitStatus ValidateCurrency(UnitStatus unitStatus)
        {
            var retVal = unitStatus;

            //if currency has no Minor Units (cents), then it can't be required.
            //However, custom systems might store as .00, so make it optional.
            if (unitStatus.IsRequired() && !_currency.HasMinorUnits()) 
                retVal = UnitStatus.Optional;

            return retVal;
        }
        #endregion

        #region Public Overrides
        public override bool IsMatch(string str)
        {
            if (_majorUnitLength.Modified || _minorUnitLength.Modified)
                RefreshPatterns();

            return base.IsMatch(str);
        }
        public override string Replace(string str, string replaceWith = "")
        {
            if (_majorUnitLength.Modified || _minorUnitLength.Modified)
                RefreshPatterns();

            return base.Replace(str, replaceWith);
        }
        public override void RefreshPatterns()
        {
            lock (_locker)
            {
                //refresh called, clear cache
                var succ = _currency.DropAttributes();
                //grab all attributes 1 time per Currency to be more efficent
                var attrib = _currency.CurrencyAttr();
                if (attrib != null)
                {
                    _currencySymbolDisplay = attrib.CurrencySymbol;
                    _currencySymbol = EscapeChars(attrib.CurrencySymbol);
                    _hasMinorUnits = attrib.HasMinorUnits;
                    _currencyName = attrib.CurrencyName;
                    _countryName = attrib.CountryName;
                    _decimalPoint = attrib.DecimalPoint;
                }

                SetMatchPattern();
                SetReplacePattern();

                _majorUnitLength.Modified = false;
                _minorUnitLength.Modified = false;
            }
        }
        #endregion
    }
}
