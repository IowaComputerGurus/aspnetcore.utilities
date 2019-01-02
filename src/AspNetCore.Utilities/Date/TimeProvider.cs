using System;

namespace AspNetCore.Utilities.Date
{
    public interface ITimeProvider
    {
        DateTime CurrentServerTime { get; }
        DateTime CurrentUtcTime { get; }
    }

    public class TimeProvider : ITimeProvider
    {
        public DateTime CurrentServerTime => DateTime.Now;
        public DateTime CurrentUtcTime => DateTime.UtcNow;
    }
}