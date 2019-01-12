using System;
using System.IO;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    ///     Wrapper for the <see cref="System.IO.Path" /> object for unit-testing
    /// </summary>
    public interface IPathProvider
    {
        /// <summary>
        ///     Changes the extension of a path string.
        /// </summary>
        /// <param name="path">
        ///     The path information to modify. The path cannot contain any of the characters defined in
        ///     GetInvalidPathChars().
        /// </param>
        /// <param name="extension">
        ///     The new extension (with or without a leading period). Specify null to remove an existing
        ///     extension from path.
        /// </param>
        /// <returns>
        ///     The modified path information.
        ///     On Windows-based desktop platforms, if path is null or an empty string (""), the path information is returned
        ///     unmodified.If extension is null, the returned string contains the specified path with its extension removed.If path
        ///     has no extension, and extension is not null, the returned path string contains extension appended to the end of
        ///     path.
        /// </returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        string ChangeExtension(string path, string extension);

        /// <summary>
        /// Combines an array of strings into a path.
        /// </summary>
        /// <param name="paths">An array of parts of the path.</param>
        /// <returns>The combined paths.</returns>
        /// <exception cref="ArgumentException">One of the strings in the array contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        /// <exception cref="ArgumentNullException">One of the strings in the array is null.</exception>
        string Combine(params string[] paths);

        /// <summary>
        /// Combines two strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine</param>
        /// <param name="path2">The second path to combine</param>
        /// <returns>The combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If path2 contains an absolute path, this method returns path2.</returns>
        /// <exception cref="ArgumentException">path1 or path2 contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        /// <exception cref="ArgumentNullException">path1 or path2 is null.</exception>
        string Combine(string path1, string path2);

        /// <summary>
        /// Combines three strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine</param>
        /// <param name="path2">The second path to combine</param>
        /// <param name="path3">The third path to combine</param>
        /// <returns>The combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If path2 contains an absolute path, this method returns path2.</returns>
        /// <exception cref="ArgumentException">path1 or path2 contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        /// <exception cref="ArgumentNullException">path1 or path2 is null.</exception>
        string Combine(string path1, string path2, string path3);

        /// <summary>
        /// Combined four strings into a path
        /// </summary>
        /// <param name="path1">The first path to combine</param>
        /// <param name="path2">The second path to combine</param>
        /// <param name="path3">The third path to combine</param>
        /// <param name="path4">The fourth path to combine</param>
        /// <returns>The combined path</returns>
        /// <exception cref="ArgumentException">If any inputs contain illegal path characters</exception>
        /// <exception cref="ArgumentNullException">If any inputs are null</exception>
        string Combine(string path1, string path2, string path3, string path4);

        /// <summary>
        /// Returns the directory information for the specified path string.
        /// </summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>Directory information for path, or null if path denotes a root directory or is null. Returns Empty if path does not contain directory information.</returns>
        /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
        /// <exception cref="PathTooLongException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, IOException, instead. The path parameter is longer than the system-defined maximum length.</exception>
        string GetDirectoryName(string path);

        /// <summary>
        /// Gets the extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to get the extension.</param>
        /// <returns>The extension of the specified path (including the period "."), or null, or Empty. If path is null, GetExtension(String) returns null. If path does not have extension information, GetExtension(String) returns Empty.</returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        string GetExtension(string path);

        /// <summary>
        /// Returns the file name and extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to obtain the file name and extension.</param>
        /// <returns>The characters after the last directory character in path. If the last character of path is a directory or volume separator character, this method returns Empty. If path is null, this method returns null.</returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        string GetFileName(string path);

        /// <summary>
        /// Returns the file name of the specified path string without the extension.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <returns>The string returned by GetFileName(String), minus the last period (.) and all characters following it.</returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        string GetFileNameWithoutExtension(string path);

        /// <summary>
        /// Returns the absolute path for the specified path string.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain absolute path information.</param>
        /// <returns>The fully qualified location of path, such as "C:\MyFile.txt".</returns>
        string GetFullPath(string path);

        /// <summary>
        /// Gets an array containing the characters that are not allowed in file names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in file names.</returns>
        char[] GetInvalidFileNameChars();

        /// <summary>
        /// Gets an array containing the characters that are not allowed in path names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in path names.</returns>
        char[] GetInvalidPathChars();

        /// <summary>
        /// Gets the root directory information of the specified path.
        /// </summary>
        /// <param name="path">The path from which to obtain root directory information.</param>
        /// <returns>The root directory of path, or null if path is null, or an empty string if path does not contain root directory information.</returns>
        string GetPathRoot(string path);

        /// <summary>
        /// Returns a random folder name or file name.
        /// </summary>
        /// <returns>A random folder name or file name.</returns>
        string GetRandomFileName();

        /// <summary>
        /// Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.
        /// </summary>
        /// <returns>The full path of the temporary file.</returns>
        string GetTempFileName();

        /// <summary>
        /// Returns the path of the current user's temporary folder.
        /// </summary>
        /// <returns>The path to the temporary folder, ending with a backslash.</returns>
        string GetTempPath();

        /// <summary>
        /// Determines whether a path includes a file name extension.
        /// </summary>
        /// <param name="path">The path to search for an extension</param>
        /// <returns></returns>
        bool HasExtension(string path);

        /// <summary>
        /// Determines if the path is a fully qualified path
        /// </summary>
        /// <param name="path">The path to test</param>
        /// <returns></returns>
        bool IsPathFullyQualified(string path);

        /// <summary>
        /// Gets a value indicating whether the specified path string contains a root.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <returns>true if path contains a root; otherwise, false.</returns>
        bool IsPathRooted(string path);
    }

    /// <summary>
    ///     Wrapper for the <see cref="System.IO.Path" /> object for unit-testing
    /// </summary>
    public class PathProvider : IPathProvider
    {
        /// <summary>
        ///     Changes the extension of a path string.
        /// </summary>
        /// <param name="path">
        ///     The path information to modify. The path cannot contain any of the characters defined in
        ///     GetInvalidPathChars().
        /// </param>
        /// <param name="extension">
        ///     The new extension (with or without a leading period). Specify null to remove an existing
        ///     extension from path.
        /// </param>
        /// <returns>
        ///     The modified path information.
        ///     On Windows-based desktop platforms, if path is null or an empty string (""), the path information is returned
        ///     unmodified.If extension is null, the returned string contains the specified path with its extension removed.If path
        ///     has no extension, and extension is not null, the returned path string contains extension appended to the end of
        ///     path.
        /// </returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        public string ChangeExtension(string path, string extension)
        {
            return Path.ChangeExtension(path, extension);
        }

        /// <summary>
        /// Combines an array of strings into a path.
        /// </summary>
        /// <param name="paths">An array of parts of the path.</param>
        /// <returns>The combined paths.</returns>
        /// <exception cref="ArgumentException">One of the strings in the array contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        /// <exception cref="ArgumentNullException">One of the strings in the array is null.</exception>
        public string Combine(params string[] paths)
        {
            return Path.Combine(paths);
        }

        /// <summary>
        /// Combines two strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine</param>
        /// <param name="path2">The second path to combine</param>
        /// <returns>The combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If path2 contains an absolute path, this method returns path2.</returns>
        /// <exception cref="ArgumentException">path1 or path2 contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        /// <exception cref="ArgumentNullException">path1 or path2 is null.</exception>
        public string Combine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        /// <summary>
        /// Combines three strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine</param>
        /// <param name="path2">The second path to combine</param>
        /// <param name="path3">The third path to combine</param>
        /// <returns>The combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If path2 contains an absolute path, this method returns path2.</returns>
        /// <exception cref="ArgumentException">path1 or path2 contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        /// <exception cref="ArgumentNullException">path1 or path2 is null.</exception>
        public string Combine(string path1, string path2, string path3)
        {
            return Path.Combine(path1, path2, path3);
        }

        /// <summary>
        /// Combined four strings into a path
        /// </summary>
        /// <param name="path1">The first path to combine</param>
        /// <param name="path2">The second path to combine</param>
        /// <param name="path3">The third path to combine</param>
        /// <param name="path4">The fourth path to combine</param>
        /// <returns>The combined path</returns>
        /// <exception cref="ArgumentException">If any inputs contain illegal path characters</exception>
        /// <exception cref="ArgumentNullException">If any inputs are null</exception>
        public string Combine(string path1, string path2, string path3, string path4)
        {
            return Path.Combine(path1, path2, path3, path4);
        }

        /// <summary>
        /// Returns the directory information for the specified path string.
        /// </summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>Directory information for path, or null if path denotes a root directory or is null. Returns Empty if path does not contain directory information.</returns>
        /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
        /// <exception cref="PathTooLongException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, IOException, instead. The path parameter is longer than the system-defined maximum length.</exception>
        public string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        /// <summary>
        /// Gets the extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to get the extension.</param>
        /// <returns>The extension of the specified path (including the period "."), or null, or Empty. If path is null, GetExtension(String) returns null. If path does not have extension information, GetExtension(String) returns Empty.</returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        public string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }

        /// <summary>
        /// Returns the file name and extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to obtain the file name and extension.</param>
        /// <returns>The characters after the last directory character in path. If the last character of path is a directory or volume separator character, this method returns Empty. If path is null, this method returns null.</returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        /// <summary>
        /// Returns the file name of the specified path string without the extension.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <returns>The string returned by GetFileName(String), minus the last period (.) and all characters following it.</returns>
        /// <exception cref="ArgumentException">path contains one or more of the invalid characters defined in GetInvalidPathChars().</exception>
        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        /// <summary>
        /// Returns the absolute path for the specified path string.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain absolute path information.</param>
        /// <returns>The fully qualified location of path, such as "C:\MyFile.txt".</returns>
        public string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }

        /// <summary>
        /// Gets an array containing the characters that are not allowed in file names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in file names.</returns>
        public char[] GetInvalidFileNameChars()
        {
            return Path.GetInvalidFileNameChars();
        }

        /// <summary>
        /// Gets an array containing the characters that are not allowed in path names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in path names.</returns>
        public char[] GetInvalidPathChars()
        {
            return Path.GetInvalidPathChars();
        }

        /// <summary>
        /// Gets the root directory information of the specified path.
        /// </summary>
        /// <param name="path">The path from which to obtain root directory information.</param>
        /// <returns>The root directory of path, or null if path is null, or an empty string if path does not contain root directory information.</returns>
        public string GetPathRoot(string path)
        {
            return Path.GetPathRoot(path);
        }

        /// <summary>
        /// Returns a random folder name or file name.
        /// </summary>
        /// <returns>A random folder name or file name.</returns>
        public string GetRandomFileName()
        {
            return Path.GetRandomFileName();
        }

        /// <summary>
        /// Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.
        /// </summary>
        /// <returns>The full path of the temporary file.</returns>
        public string GetTempFileName()
        {
            return Path.GetTempFileName();
        }

        /// <summary>
        /// Returns the path of the current user's temporary folder.
        /// </summary>
        /// <returns>The path to the temporary folder, ending with a backslash.</returns>
        public string GetTempPath()
        {
            return Path.GetTempPath();
        }

        /// <summary>
        /// Determines whether a path includes a file name extension.
        /// </summary>
        /// <param name="path">The path to search for an extension</param>
        /// <returns></returns>
        public bool HasExtension(string path)
        {
            return Path.HasExtension(path);
        }

        /// <summary>
        /// Determines if the path is a fully qualified path
        /// </summary>
        /// <param name="path">The path to test</param>
        /// <returns></returns>
        public bool IsPathFullyQualified(string path)
        {
            return Path.IsPathFullyQualified(path);
        }

        /// <summary>
        /// Gets a value indicating whether the specified path string contains a root.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <returns>true if path contains a root; otherwise, false.</returns>
        public bool IsPathRooted(string path)
        {
            return Path.IsPathRooted(path);
        }
    }
}