using System;
using System.Globalization;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    ///     A wrapper shim for the <see cref="DateTime" /> object to allow unit-testing
    /// </summary>
    public interface ITimeProvider
    {
        /// <summary>
        ///     Gets a <see cref="DateTime" /> object that is set to the current date and time on this computer, expressed in local
        ///     time
        /// </summary>
        DateTime Now { get; }

        /// <summary>
        ///     Gets the current date
        /// </summary>
        DateTime Today { get; }

        /// <summary>
        ///     Gets a <see cref="DateTime" /> object that is set to the current date and time on this computer, expressed in
        ///     Coordinated Universal Time (UTC)
        /// </summary>
        DateTime UtcNow { get; }

        /// <summary>
        ///     Returns the number of days in the specified month and year
        /// </summary>
        /// <param name="month">The month number</param>
        /// <param name="year">The year</param>
        /// <returns>Total number of days in the month</returns>
        int DaysInMonth(int year, int month);
        
        /// <summary>
        ///     Converts the string representation of a date and time to its <see cref="DateTime" /> equivalent by using the
        ///     conventions of the current thread culture.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert. </param>
        /// <returns>An object that is equivalent to the date and time contained in s.</returns>
        /// <exception cref="ArgumentNullException">[s] is null</exception>
        /// <exception cref="FormatException">[s] does not contain a valid string representation of a date and time.</exception>
        DateTime Parse(string s);

        /// <summary>
        ///     Converts the string representation of a date and time to its <see cref="DateTime" /> equivalent by using the
        ///     conventions of the current thread culture.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert. </param>
        /// <param name="provider">An object that supplies culture-specific format information about s. </param>
        /// <returns>An object that is equivalent to the date and time contained in s.</returns>
        /// <exception cref="ArgumentNullException">[s] is null</exception>
        /// <exception cref="FormatException">[s] does not contain a valid string representation of a date and time.</exception>
        DateTime Parse(string s, IFormatProvider provider);

        /// <summary>
        ///     Converts the string representation of a date and time to its <see cref="DateTime" /> equivalent by using the
        ///     conventions of the current thread culture.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert. </param>
        /// <param name="provider">An object that supplies culture-specific format information about s. </param>
        /// <param name="styles">
        ///     A bitwise combination of the enumeration values that indicates the style elements that can be
        ///     present in s for the parse operation to succeed, and that defines how to interpret the parsed date in relation to
        ///     the current time zone or the current date. A typical value to specify is None.
        /// </param>
        /// <returns>An object that is equivalent to the date and time contained in s.</returns>
        /// <exception cref="ArgumentNullException">[s] is null</exception>
        /// <exception cref="FormatException">[s] does not contain a valid string representation of a date and time.</exception>
        DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent and
        ///     returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="result">
        ///     When this method returns, contains the DateTime value equivalent to the date and time contained in
        ///     s, if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion failed. The conversion fails
        ///     if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date
        ///     and time. This parameter is passed uninitialized.
        /// </param>
        /// <returns>[true] if the s parameter was converted successfully; otherwise, [false].</returns>
        bool TryParse(string s, out DateTime result);

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent using the
        ///     specified culture-specific format information and formatting style, and returns a value that indicates whether the
        ///     conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="format">An object that supplies culture-specific formatting information about [s].</param>
        /// <param name="styles">
        ///     A bitwise combination of enumeration values that defines how to interpret the parsed date in
        ///     relation to the current time zone or the current date. A typical value to specify is [None].
        /// </param>
        /// <param name="result">
        ///     When this method returns, contains the DateTime value equivalent to the date and time contained in
        ///     s, if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion failed. The conversion fails
        ///     if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date
        ///     and time. This parameter is passed uninitialized.
        /// </param>
        /// <returns>[true] if the s parameter was converted successfully; otherwise, [false].</returns>
        bool TryParse(string s, IFormatProvider format, DateTimeStyles styles, out DateTime result);

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent using the
        ///     specified format, culture-specific format information, and style. The format of the string representation must
        ///     match the specified format exactly. The method returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="format">The required format of [s].</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about [s].</param>
        /// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of s.</param>
        /// <param name="result"></param>
        /// <returns>
        ///     When this method returns, contains the DateTime value equivalent to the date and time contained in
        ///     s, if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion failed. The conversion fails
        ///     if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date
        ///     and time. This parameter is passed uninitialized.
        /// </returns>
        bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style,
            out DateTime result);

        /// <summary>
        ///     Converts the specified string representation of a date and time to its <see cref="DateTime" /> equivalent using the
        ///     specified format, culture-specific format information, and style. The format of the string representation must
        ///     match the specified format exactly. The method returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="formats">An array of allowable formats of [s].</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about [s].</param>
        /// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of s.</param>
        /// <param name="result"></param>
        /// <returns>
        ///     When this method returns, contains the DateTime value equivalent to the date and time contained in
        ///     s, if the conversion succeeded, or <see cref="DateTime.MinValue" /> if the conversion failed. The conversion fails
        ///     if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date
        ///     and time. This parameter is passed uninitialized.
        /// </returns>
        bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style,
            out DateTime result);

        /// <summary>
        ///     Provides the total number of seconds since the Epoch (1/1/1970).  Often used for integration with third-parties
        /// </summary>
        /// <param name="input">The date to use for calculation</param>
        /// <returns>
        ///     The Total # of Seconds since Epoch, based on the difference between the supplied DateTime and 1/1/1970
        /// </returns>
        ulong SecondsSinceEpoch(DateTime input);

        /// <summary>
        ///     Provides the total number of seconds since the Epoch (1/1/1970).  Often used for integration with third-parties.
        /// </summary>
        /// <returns>
        ///     The Total # of Seconds since Epoch, based on the difference between <see cref="DateTime.UtcNow"/> and 1/1/1970
        /// </returns>
        ulong UtcNowSecondsSinceEpoch();
    }

    /// <summary>
    ///     A wrapper shim for the <see cref="DateTime" /> object to allow unit-testing
    /// </summary>
    public class TimeProvider : ITimeProvider
    {
        /// <inheritdoc />
        public DateTime Now => DateTime.Now;

        /// <inheritdoc />
        public DateTime Today => DateTime.Today;

        /// <inheritdoc />
        public DateTime UtcNow => DateTime.UtcNow;

        /// <inheritdoc />
        public int DaysInMonth(int year, int month) => DateTime.DaysInMonth(year, month);

        /// <inheritdoc />
        public DateTime Parse(string s) => DateTime.Parse(s);
        
        /// <inheritdoc />
        public DateTime Parse(string s, IFormatProvider provider) => DateTime.Parse(s, provider);

        /// <inheritdoc />
        public DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) => DateTime.Parse(s, provider, styles);

        /// <inheritdoc />
        public bool TryParse(string s, out DateTime result) => DateTime.TryParse(s, out result);

        /// <inheritdoc />
        public bool TryParse(string s, IFormatProvider format, DateTimeStyles styles, out DateTime result) => DateTime.TryParse(s, format, styles, out result);

        /// <inheritdoc />
        public bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style,
            out DateTime result) => DateTime.TryParseExact(s, format, provider, style, out result);

        /// <inheritdoc />
        public bool TryParseExact(string s, string[] formats, IFormatProvider provider,
            DateTimeStyles style, out DateTime result) => DateTime.TryParseExact(s, formats, provider, style, out result);

        /// <inheritdoc />
        public ulong SecondsSinceEpoch(DateTime input)
        {
            var epochStart = new DateTime(1970, 01, 01, 0, 0, 0, 0, DateTimeKind.Utc);
            var timeSpan = input - epochStart;
            return Convert.ToUInt64(timeSpan.TotalSeconds);
        }

        /// <inheritdoc />
        public ulong UtcNowSecondsSinceEpoch()
        {
            return SecondsSinceEpoch(UtcNow);
        }
    }
}