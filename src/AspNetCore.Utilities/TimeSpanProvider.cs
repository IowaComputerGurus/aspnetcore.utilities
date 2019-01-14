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
        /// <inheritdoc />
        public TimeSpan FromMilliseconds(double value) => TimeSpan.FromMilliseconds(value);

        /// <inheritdoc />
        public TimeSpan FromSeconds(double value) => TimeSpan.FromSeconds(value);

        /// <inheritdoc />
        public TimeSpan FromMinutes(double value) => TimeSpan.FromMinutes(value);

        /// <inheritdoc />
        public TimeSpan FromHours(double value) => TimeSpan.FromHours(value);

        /// <inheritdoc />
        public TimeSpan FromDays(double value) => TimeSpan.FromDays(value);

        /// <inheritdoc />
        public TimeSpan FromTicks(long value) => TimeSpan.FromTicks(value);

        /// <inheritdoc />
        public TimeSpan Parse(string s) => TimeSpan.Parse(s);

        /// <inheritdoc />
        public TimeSpan Parse(string input, IFormatProvider formatProvider) => TimeSpan.Parse(input, formatProvider);

        /// <inheritdoc />
        public bool TryParse(string s, out TimeSpan result) => TimeSpan.TryParse(s, out result);

        /// <inheritdoc />
        public bool TryParse(string s, IFormatProvider formatProvider, out TimeSpan result) => TimeSpan.TryParse(s, formatProvider, out result);
    }
}