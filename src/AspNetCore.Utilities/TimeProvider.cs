using System;

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
    }

    /// <summary>
    ///     A wrapper shim for the <see cref="DateTime" /> object to allow unit-testing
    /// </summary>
    public class TimeProvider : ITimeProvider
    {
        /// <summary>
        ///     Gets a <see cref="DateTime" /> object that is set to the current date and time on this computer, expressed in local
        ///     time
        /// </summary>
        public DateTime Now => DateTime.Now;

        /// <summary>
        ///     Gets the current date
        /// </summary>
        public DateTime Today => DateTime.Today;

        /// <summary>
        ///     Gets a <see cref="DateTime" /> object that is set to the current date and time on this computer, expressed in
        ///     Coordinated Universal Time (UTC)
        /// </summary>
        public DateTime UtcNow => DateTime.UtcNow;

        /// <summary>
        ///     Returns the number of days in the specified month and year
        /// </summary>
        /// <param name="month">The month number</param>
        /// <param name="year">The year</param>
        /// <returns>Total number of days in the month</returns>
        public int DaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}