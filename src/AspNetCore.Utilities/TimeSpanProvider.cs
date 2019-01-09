using System;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    ///     A wrapper shim for the <see cref="TimeSpan" /> object to allow unit-testing
    /// </summary>
    public interface ITimeSpanProvider
    {
        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of milliseconds.
        /// </summary>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>An object that represents value.</returns>
        TimeSpan FromMilliseconds(double value);

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of seconds, where the specification is
        ///     accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of seconds.</param>
        /// <returns>An object that represents value.</returns>
        TimeSpan FromSeconds(double value);

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of minutes, where the specification is
        ///     accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of minutes.</param>
        /// <returns>An object that represents value.</returns>
        TimeSpan FromMinutes(double value);

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of hours, where the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of hours.</param>
        /// <returns>An object that represents value.</returns>
        TimeSpan FromHours(double value);

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of days, where the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of days.</param>
        /// <returns>An object that represents value.</returns>
        TimeSpan FromDays(double value);

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified time, where the specification is in units of ticks.
        /// </summary>
        /// <param name="value">A number of Ticks.</param>
        /// <returns>An object that represents value.</returns>
        TimeSpan FromTicks(long value);

        /// <summary>
        ///     Converts the string representation of a time interval to its <see cref="TimeSpan" /> equivalent.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert</param>
        /// <returns>A time interval that corresponds to s.</returns>
        /// <exception cref="ArgumentNullException">[s] is null</exception>
        /// <exception cref="FormatException">[s] has an invalid format</exception>
        TimeSpan Parse(string s);

        /// <summary>
        ///     Converts the string representation of a time interval to its <see cref="TimeSpan" /> equivalent by using the
        ///     specified culture-specific format information.
        /// </summary>
        /// <param name="input">A string that specifies the time interval to convert.</param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information</param>
        /// <returns>A time interval that corresponds to input, as specified by formatProvider.</returns>
        /// <exception cref="ArgumentNullException">[s] is null</exception>
        /// <exception cref="FormatException">[s] has an invalid format</exception>
        /// <exception cref="OverflowException">input represents a number that is less than MinValue or greater than MaxValue.</exception>
        TimeSpan Parse(string input, IFormatProvider formatProvider);

        /// <summary>
        ///     Converts the string representation of a time interval to its TimeSpan equivalent and returns a value that indicates
        ///     whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="result">
        ///     When this method returns, contains an object that represents the time interval specified by s, or
        ///     Zero if the conversion failed. This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        ///     true if s was converted successfully; otherwise, false. This operation returns false if the s parameter is
        ///     null or Empty, has an invalid format, represents a time interval that is less than MinValue or greater than
        ///     MaxValue, or has at least one days, hours, minutes, or seconds component outside its valid range.
        /// </returns>
        bool TryParse(string s, out TimeSpan result);

        /// <summary>
        ///     Converts the string representation of a time interval to its TimeSpan equivalent and returns a value that indicates
        ///     whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
        /// <param name="result">
        ///     When this method returns, contains an object that represents the time interval specified by s, or
        ///     Zero if the conversion failed. This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        ///     true if s was converted successfully; otherwise, false. This operation returns false if the s parameter is
        ///     null or Empty, has an invalid format, represents a time interval that is less than MinValue or greater than
        ///     MaxValue, or has at least one days, hours, minutes, or seconds component outside its valid range.
        /// </returns>
        bool TryParse(string s, IFormatProvider formatProvider, out TimeSpan result);
    }

    /// <summary>
    ///     A wrapper shim for the <see cref="TimeSpan" /> object to allow unit-testing
    /// </summary>
    public class TimeSpanProvider : ITimeSpanProvider
    {
        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of milliseconds.
        /// </summary>
        /// <param name="value">A number of milliseconds.</param>
        /// <returns>An object that represents value.</returns>
        public TimeSpan FromMilliseconds(double value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of seconds, where the specification is
        ///     accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of seconds.</param>
        /// <returns>An object that represents value.</returns>
        public TimeSpan FromSeconds(double value)
        {
            return TimeSpan.FromSeconds(value);
        }

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of minutes, where the specification is
        ///     accurate to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of minutes.</param>
        /// <returns>An object that represents value.</returns>
        public TimeSpan FromMinutes(double value)
        {
            return TimeSpan.FromMinutes(value);
        }

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of hours, where the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of hours.</param>
        /// <returns>An object that represents value.</returns>
        public TimeSpan FromHours(double value)
        {
            return TimeSpan.FromHours(value);
        }

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified number of days, where the specification is accurate
        ///     to the nearest millisecond.
        /// </summary>
        /// <param name="value">A number of days.</param>
        /// <returns>An object that represents value.</returns>
        public TimeSpan FromDays(double value)
        {
            return TimeSpan.FromDays(value);
        }

        /// <summary>
        ///     Returns a <see cref="TimeSpan" /> that represents a specified time, where the specification is in units of ticks.
        /// </summary>
        /// <param name="value">A number of Ticks.</param>
        /// <returns>An object that represents value.</returns>
        public TimeSpan FromTicks(long value)
        {
            return TimeSpan.FromTicks(value);
        }

        /// <summary>
        ///     Converts the string representation of a time interval to its <see cref="TimeSpan" /> equivalent.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert</param>
        /// <returns>A time interval that corresponds to s.</returns>
        /// <exception cref="ArgumentNullException">[s] is null</exception>
        /// <exception cref="FormatException">[s] has an invalid format</exception>
        public TimeSpan Parse(string s)
        {
            return TimeSpan.Parse(s);
        }

        /// <summary>
        ///     Converts the string representation of a time interval to its <see cref="TimeSpan" /> equivalent by using the
        ///     specified culture-specific format information.
        /// </summary>
        /// <param name="input">A string that specifies the time interval to convert.</param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information</param>
        /// <returns>A time interval that corresponds to input, as specified by formatProvider.</returns>
        /// <exception cref="ArgumentNullException">[s] is null</exception>
        /// <exception cref="FormatException">[s] has an invalid format</exception>
        /// <exception cref="OverflowException">input represents a number that is less than MinValue or greater than MaxValue.</exception>
        public TimeSpan Parse(string input, IFormatProvider formatProvider)
        {
            return TimeSpan.Parse(input, formatProvider);
        }

        /// <summary>
        ///     Converts the string representation of a time interval to its TimeSpan equivalent and returns a value that indicates
        ///     whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="result">
        ///     When this method returns, contains an object that represents the time interval specified by s, or
        ///     Zero if the conversion failed. This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        ///     true if s was converted successfully; otherwise, false. This operation returns false if the s parameter is
        ///     null or Empty, has an invalid format, represents a time interval that is less than MinValue or greater than
        ///     MaxValue, or has at least one days, hours, minutes, or seconds component outside its valid range.
        /// </returns>
        public bool TryParse(string s, out TimeSpan result)
        {
            return TimeSpan.TryParse(s, out result);
        }

        /// <summary>
        ///     Converts the string representation of a time interval to its TimeSpan equivalent and returns a value that indicates
        ///     whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string that specifies the time interval to convert.</param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
        /// <param name="result">
        ///     When this method returns, contains an object that represents the time interval specified by s, or
        ///     Zero if the conversion failed. This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        ///     true if s was converted successfully; otherwise, false. This operation returns false if the s parameter is
        ///     null or Empty, has an invalid format, represents a time interval that is less than MinValue or greater than
        ///     MaxValue, or has at least one days, hours, minutes, or seconds component outside its valid range.
        /// </returns>
        public bool TryParse(string s, IFormatProvider formatProvider, out TimeSpan result)
        {
            return TimeSpan.TryParse(s, formatProvider, out result);
        }
    }
}