using System;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    /// A wrapping shim around the System.Guid object
    /// </summary>
    public interface IGuidProvider
    {
        /// <summary>
        /// A read-only instance of the Guid structure whose value is all zeros.
        /// </summary>
        Guid Empty { get; }
        /// <summary>
        ///     Initializes a new instance of the Guid structure.
        /// </summary>
        /// <returns>A new GUID object.</returns>
        Guid NewGuid();

        /// <summary>
        ///     Converts the string representation of a GUID to the equivalent Guid structure.
        /// </summary>
        /// <param name="input">The string to parse</param>
        /// <returns>A structure that contains the value that was parsed.</returns>
        /// <exception cref="ArgumentNullException">input is null</exception>
        /// <exception cref="FormatException">input it not a recognized format</exception>
        Guid Parse(string input);

        /// <summary>
        ///     Converts the string representation of a GUID to the equivalent Guid structure, provided that the string is in the
        ///     specified format.
        /// </summary>
        /// <param name="input">The GUID to convert.</param>
        /// <param name="format">
        ///     One of the following specifiers that indicates the exact format to use when interpreting input:
        ///     "N", "D", "B", "P", or "X".
        /// </param>
        /// <returns>A structure that contains the value that was parsed.</returns>
        Guid ParseExact(string input, string format);

        /// <summary>
        ///     Converts the string representation of a GUID to the equivalent Guid structure.
        /// </summary>
        /// <param name="input">The GUID to convert.</param>
        /// <param name="result">
        ///     The structure that will contain the parsed value. If the method returns true, result contains a
        ///     valid Guid. If the method returns false, result equals Empty.
        /// </param>
        /// <returns>true if the parse operation was successful; otherwise, false.</returns>
        bool TryParse(string input, out Guid result);

        /// <summary>
        ///     Converts the string representation of a GUID to the equivalent Guid structure, provided that the string is in the
        ///     specified format.
        /// </summary>
        /// <param name="input">The GUID to convert.</param>
        /// <param name="format">
        ///     One of the following specifiers that indicates the exact format to use when interpreting input:
        ///     "N", "D", "B", "P", or "X".
        /// </param>
        /// <param name="result">
        ///     The structure that will contain the parsed value. If the method returns true, result contains a
        ///     valid Guid. If the method returns false, result equals Empty.
        /// </param>
        /// <returns>true if the parse operation was successful; otherwise, false.</returns>
        bool TryParseExact(string input, string format, out Guid result);
    }

    /// <summary>
    /// A wrapping shim around the System.Guid object
    /// </summary>
    public class GuidProvider : IGuidProvider
    {
        /// <inheritdoc />
        public Guid Empty => Guid.Empty;

        /// <inheritdoc />
        public Guid NewGuid() => Guid.NewGuid();

        /// <inheritdoc />
        public Guid Parse(string input) => Guid.Parse(input);

        /// <inheritdoc />
        public Guid ParseExact(string input, string format) => Guid.ParseExact(input, format);

        /// <inheritdoc />
        public bool TryParse(string input, out Guid result) => Guid.TryParse(input, out result);

        /// <inheritdoc />
        public bool TryParseExact(string input, string format, out Guid result) =>
            Guid.TryParseExact(input, format, out result);
    }
}