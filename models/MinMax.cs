using System;
using System.Diagnostics;

namespace Chizl.RegexPatterns
{
    /// <summary>
    /// Used for Min and Max Lengths, but could be use for anything with a Min and/or Max value.<br/>
    /// Valid(MinMax, Min, Max) method exists, since each component using this might have different values, that the user has passed.
    /// </summary>
    public class MinMax
    {
        #region Private Vars
        // For verification purposes only
        private int _minRangeValue = int.MinValue;
        // For verification purposes only
        private int _maxRangeValue = int.MaxValue;
        // Sets for property
        private int _minValue;
        // Sets for property
        private int _maxValue;
        #endregion

        #region Constructor
        private MinMax(int minRange, int maxRange)
        {
            if (minRange > maxRange)
                throw new ArgumentException($"'{nameof(minRange)}' ({minRange}) cannot be higher than '{nameof(maxRange)}' ({maxRange})");

            _minRangeValue = minRange;
            _maxRangeValue = maxRange;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Minimum Value allowed.
        /// </summary>
        public int Min { get { return _minValue; } set { _minValue = Verify(value, _minValue); CheckMinMax(true); } }
        /// <summary>
        /// Maximum Value allowed.
        /// </summary>
        public int Max { get { return _maxValue; } set { _maxValue = Verify(value, _maxValue); CheckMinMax(false); } }
        #endregion

        #region Internal Properties
        /// <summary>
        /// Developer can call back to make sure change wasn't made since last call.
        /// </summary>
        internal bool Modified { get; set; } = false;
        #endregion

        #region Internal Methods
        /// <summary>
        /// If value is out of range, it will change the value in range.<br/>
        /// If value is too high, the return value will be max value.<br/>
        /// If the value is too low, the return value will be the min.<br/>
        /// If the value is within range, the value passed in will be returned.
        /// </summary>
        /// <param name="val">Value to verify is within range.</param>
        /// <returns>An in range value</returns>
        internal int InRange(int val) => Math.Min(Math.Max(val, _minRangeValue), _maxRangeValue);
        /// <summary>
        /// Only for Internal Devlopers
        /// </summary>
        /// <param name="minRangeLow">Low range used for Min property.</param>
        /// <param name="minRangeHigh">High range used for Min property.</param>
        /// <param name="maxRangeLow">Low range used for Max property.</param>
        /// <param name="maxRangeHigh">High range used for Max property.</param>
        /// <returns>New MinMax() object, For external caller with only Min/Max property available.</returns>
        internal static MinMax SetRange(int minRange, int maxRange) => new MinMax(minRange, maxRange);
        #endregion

        #region Private Methods
        /// <summary>
        /// Private Validator for values passed in from end user.
        /// </summary>
        private int Verify(int val, int defaultValue)
        {
            var valid = val >= _minRangeValue && val <= _maxRangeValue;

            //TODO: add logger, for appropriate logging.
            if (!valid)
            {
                //invalid, use default
                val = defaultValue;
                Debug.WriteLine($"MinMax verification for '{val}' is outside of valid range: ({_minRangeValue} - {_maxRangeValue})");
            }
            
            return val;
        }
        /// <summary>
        /// Verfifies Min and Max and will update other property if out of sync.
        /// </summary>
        private void CheckMinMax(bool isMin)
        {
            if(_maxValue < _minValue)
            {
                if(isMin)
                    _maxValue = _minValue;
                else
                    _minValue = _maxValue;
            }

            //central point of change and this method is only called when something changed.
            this.Modified = true; 
        }

        /// <summary>
        /// Return string version of Min and Max
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"(Min: {Min}, Max: {Max})";
        #endregion
    }
}
