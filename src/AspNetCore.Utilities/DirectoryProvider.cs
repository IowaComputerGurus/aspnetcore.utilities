using System;
using System.Collections.Generic;
using System.IO;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    ///     Wrapper for <see cref="System.IO.Directory" /> to allow unit testing
    /// </summary>
    public interface IDirectoryProvider
    {
        /// <summary>
        ///     Creates all directories and subdirectories in the specified path unless they already exist.
        /// </summary>
        /// <param name="path">The directory to create.</param>
        /// <returns>
        ///     An object that represents the directory at the specified path. This object is returned regardless of whether a
        ///     directory at the specified path already exists.
        /// </returns>
        DirectoryInfo CreateDirectory(string path);

        /// <summary>
        ///     Deletes an empty directory from a specified path.
        /// </summary>
        /// <param name="path">The name of the empty directory to remove. This directory must be writable and empty.</param>
        void Delete(string path);

        /// <summary>
        ///     Deletes the specified directory and, if indicated, any subdirectories and files in the directory.
        /// </summary>
        /// <param name="path">The name of the directory to remove.</param>
        /// <param name="recursive">true to remove directories, subdirectories, and files in path; otherwise, false.</param>
        void Delete(string path, bool recursive);

        /// <summary>
        ///     Returns an enumerable collection of directory names in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>
        ///     An enumerable collection of the full names (including paths) for the directories in the directory specified by
        ///     path.
        /// </returns>
        IEnumerable<string> EnumerateDirectories(string path);

        /// <summary>
        ///     Returns an enumerable collection of directory names that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of directories in path. This parameter can
        ///     contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular
        ///     expressions.
        /// </param>
        /// <returns></returns>
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern);

        /// <summary>
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of directories in path. This parameter can
        ///     contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular
        ///     expressions.
        /// </param>
        /// <param name="enumerationOptions"></param>
        /// <returns></returns>
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern,
            EnumerationOptions enumerationOptions);

        /// <summary>
        ///     Returns an enumerable collection of directory names that match a search pattern in a specified path, and optionally
        ///     searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of directories in path. This parameter can
        ///     contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular
        ///     expressions.
        /// </param>
        /// <param name="searchOption">
        ///     One of the enumeration values that specifies whether the search operation should include
        ///     only the current directory or should include all subdirectories.
        /// </param>
        /// <returns></returns>
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="enumerationOptions"></param>
        /// <returns></returns>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>
        ///     Returns an enumerable collection of file names that match a search pattern in a specified path, and optionally
        ///     searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of files in path. This parameter can contain a
        ///     combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.
        /// </param>
        /// <param name="searchOption">
        ///     One of the enumeration values that specifies whether the search operation should include
        ///     only the current directory or should include all subdirectories.
        /// </param>
        /// <returns></returns>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);

        /// <summary>
        ///     Returns an enumerable collection of file names in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by path.</returns>
        IEnumerable<string> EnumerateFiles(string path);

        /// <summary>
        ///     Returns an enumerable collection of file names that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of files in path. This parameter can contain a
        ///     combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.
        /// </param>
        /// <returns></returns>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);

        /// <summary>
        ///     Returns an enumerable collection of file names and directory names in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of file-system entries in the directory specified by path.</returns>
        IEnumerable<string> EnumerateFileSystemEntries(string path);

        /// <summary>
        ///     Returns an enumerable collection of file names and directory names that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of file-system entries in path. This parameter
        ///     can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular
        ///     expressions.
        /// </param>
        /// <returns></returns>
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="enumerationOptions"></param>
        /// <returns></returns>
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern,
            EnumerationOptions enumerationOptions);

        /// <summary>
        ///     Returns an enumerable collection of file names and directory names that match a search pattern in a specified path,
        ///     and optionally searches subdirectories.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of file-system entries in path. This parameter
        ///     can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular
        ///     expressions.
        /// </param>
        /// <param name="searchOption">
        ///     One of the enumeration values that specifies whether the search operation should include
        ///     only the current directory or should include all subdirectories.
        /// </param>
        /// <returns></returns>
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);

        /// <summary>
        ///     Determines whether the given path refers to an existing directory on disk.
        /// </summary>
        /// <param name="path">The path to test</param>
        /// <returns></returns>
        bool Exists(string path);

        /// <summary>
        ///     Gets the creation date and time of a directory.
        /// </summary>
        /// <param name="path">The path to the directory</param>
        /// <returns></returns>
        DateTime GetCreationTime(string path);

        /// <summary>
        ///     Gets the creation date and time of a directory in UTC format
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        DateTime GetCreationTimeUtc(string path);

        /// <summary>
        ///     Gets the current working directory of the application.
        /// </summary>
        /// <returns>
        ///     A string that contains the absolute path of the current working directory, and does not end with a backslash
        ///     (\).
        /// </returns>
        string GetCurrentDirectory();

        /// <summary>
        ///     Returns the names of the subdirectories (including their paths) that match the specified search pattern in the
        ///     specified directory, and optionally searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of subdirectories in path. This parameter can
        ///     contain a combination of valid literal and wildcard characters, but it doesn't support regular expressions.
        /// </param>
        /// <param name="searchOption">
        ///     One of the enumeration values that specifies whether the search operation should include all
        ///     subdirectories or only the current directory.
        /// </param>
        /// <returns></returns>
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="enumerationOptions"></param>
        /// <returns></returns>
        string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>
        ///     Returns the names of subdirectories (including their paths) in the specified directory.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>
        ///     An array of the full names (including paths) of subdirectories in the specified path, or an empty array if no
        ///     directories are found.
        /// </returns>
        string[] GetDirectories(string path);

        /// <summary>
        ///     Returns the volume information, root information, or both for the specified path.
        /// </summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>A string that contains the volume information, root information, or both for the specified path.</returns>
        string GetDirectoryRoot(string path);

        /// <summary>
        ///     Returns the names of files (including their paths) in the specified directory.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns></returns>
        string[] GetFiles(string path);

        /// <summary>
        ///     Returns the names of files (including their paths) that match the specified search pattern in the specified
        ///     directory.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of files in path. This parameter can contain a
        ///     combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.
        /// </param>
        /// <returns></returns>
        string[] GetFiles(string path, string searchPattern);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="enumerationOptions"></param>
        /// <returns></returns>
        string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>
        ///     Returns the names of files (including their paths) that match the specified search pattern in the specified
        ///     directory, using a value to determine whether to search subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of files in path. This parameter can contain a
        ///     combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.
        /// </param>
        /// <param name="searchOption">
        ///     One of the enumeration values that specifies whether the search operation should include all
        ///     subdirectories or only the current directory.
        /// </param>
        /// <returns></returns>
        string[] GetFiles(string path, string searchPattern, SearchOption searchOption);

        /// <summary>
        ///     Returns the names of all files and subdirectories in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns></returns>
        string[] GetFileSystemEntries(string path);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <returns></returns>
        string[] GetFileSystemEntries(string path, string searchPattern);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern"></param>
        /// <param name="enumerationOptions"></param>
        /// <returns></returns>
        string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);

        /// <summary>
        ///     Returns an array of all the file names and directory names that match a search pattern in a specified path, and
        ///     optionally searches subdirectories.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of files and directories in path. This
        ///     parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support
        ///     regular expressions.
        /// </param>
        /// <param name="searchOption">
        ///     One of the enumeration values that specifies whether the search operation should include
        ///     only the current directory or should include all subdirectories.
        /// </param>
        /// <returns></returns>
        string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);

        /// <summary>
        ///     Returns the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns></returns>
        DateTime GetLastAccessTime(string path);

        /// <summary>
        ///     Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was
        ///     last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns></returns>
        DateTime GetLastAccessTimeUtc(string path);

        /// <summary>
        ///     Returns the date and time the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information.</param>
        /// <returns></returns>
        DateTime GetLastWriteTime(string path);

        /// <summary>
        ///     Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was
        ///     last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information.</param>
        /// <returns></returns>
        DateTime GetLastWriteTimeUtc(string path);

        /// <summary>
        ///     Retrieves the names of the logical drives on this computer in the form "&lt;drive letter&gt;:\".
        /// </summary>
        /// <returns></returns>
        string[] GetLogicalDrives();

        /// <summary>
        ///     Retrieves the parent directory of the specified path, including both absolute and relative paths.
        /// </summary>
        /// <param name="path">The path for which to retrieve the parent directory.</param>
        /// <returns></returns>
        DirectoryInfo GetParent(string path);

        /// <summary>
        ///     Moves a file or a directory and its contents to a new location.
        /// </summary>
        /// <param name="sourceDirName">The path of the file or directory to move.</param>
        /// <param name="destDirName">
        ///     The path to the new location for sourceDirName. If sourceDirName is a file, then destDirName
        ///     must also be a file name.
        /// </param>
        void Move(string sourceDirName, string destDirName);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTime"></param>
        void SetCreationTime(string path, DateTime creationTime);

        /// <summary>
        /// </summary>
        /// <param name="path"></param>
        /// <param name="creationTime"></param>
        void SetCreationTimeUtc(string path, DateTime creationTime);

        /// <summary>
        ///     Sets the application's current working directory to the specified directory.
        /// </summary>
        /// <param name="path">The path to which the current working directory is set.</param>
        void SetCurrentDirectory(string path);

        /// <summary>
        /// Sets the date and time that a directory was last accessed to.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastAccessTime"></param>
        void SetLastAccessTime(string path, DateTime lastAccessTime);

        /// <summary>
        /// Sets the date and time, in Coordinated Universal Time (UTC) format, that a directory was last accessed
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastAccessTimeUtc">The date and time the directory was last written to. This value is expressed in UTC time.</param>
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);

        /// <summary>
        /// Sets the date and time that a directory was last written to.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTime"></param>
        void SetLastWriteTime(string path, DateTime lastWriteTime);

        /// <summary>
        /// Sets the date and time, in Coordinated Universal Time (UTC) format, that a directory was last written to.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTimeUtc">The date and time the directory was last written to. This value is expressed in UTC time.</param>
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
    }

    /// <inheritdoc />
    public class DirectoryProvider : IDirectoryProvider
    {
        /// <inheritdoc />
        public DirectoryInfo CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path);
        }

        /// <inheritdoc />
        public void Delete(string path)
        {
            Directory.Delete(path);
        }

        /// <inheritdoc />
        public void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path)
        {
            return Directory.EnumerateDirectories(path);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return Directory.EnumerateDirectories(path, searchPattern);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern,
            EnumerationOptions enumerationOptions)
        {
            return Directory.EnumerateDirectories(path, searchPattern, enumerationOptions);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern,
            SearchOption searchOption)
        {
            return Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern,
            EnumerationOptions enumerationOptions)
        {
            return Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern,
            SearchOption searchOption)
        {
            return Directory.EnumerateFiles(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path)
        {
            return Directory.EnumerateFiles(path);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return Directory.EnumerateFiles(path, searchPattern);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            return Directory.EnumerateFileSystemEntries(path);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern,
            EnumerationOptions enumerationOptions)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern, enumerationOptions);
        }

        /// <inheritdoc />
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern,
            SearchOption searchOption)
        {
            return Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        /// <inheritdoc />
        public DateTime GetCreationTime(string path)
        {
            return Directory.GetCreationTime(path);
        }

        /// <inheritdoc />
        public DateTime GetCreationTimeUtc(string path)
        {
            return Directory.GetCreationTimeUtc(path);
        }

        /// <inheritdoc />
        public string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetDirectories(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path, string searchPattern,
            EnumerationOptions enumerationOptions)
        {
            return Directory.GetDirectories(path, searchPattern, enumerationOptions);
        }

        /// <inheritdoc />
        public string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }

        /// <inheritdoc />
        public string GetDirectoryRoot(string path)
        {
            return Directory.GetDirectoryRoot(path);
        }

        /// <inheritdoc />
        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern)
        {
            return Directory.GetFiles(path, searchPattern);
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            return Directory.GetFiles(path, searchPattern, enumerationOptions);
        }

        /// <inheritdoc />
        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFiles(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path)
        {
            return Directory.GetFileSystemEntries(path);
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return Directory.GetFileSystemEntries(path, searchPattern);
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path, string searchPattern,
            EnumerationOptions enumerationOptions)
        {
            return Directory.GetFileSystemEntries(path, searchPattern, enumerationOptions);
        }

        /// <inheritdoc />
        public string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFileSystemEntries(path, searchPattern, searchOption);
        }

        /// <inheritdoc />
        public DateTime GetLastAccessTime(string path)
        {
            return Directory.GetLastAccessTime(path);
        }

        /// <inheritdoc />
        public DateTime GetLastAccessTimeUtc(string path)
        {
            return Directory.GetLastAccessTimeUtc(path);
        }

        /// <inheritdoc />
        public DateTime GetLastWriteTime(string path)
        {
            return Directory.GetLastWriteTime(path);
        }

        /// <inheritdoc />
        public DateTime GetLastWriteTimeUtc(string path)
        {
            return Directory.GetLastWriteTimeUtc(path);
        }

        /// <inheritdoc />
        public string[] GetLogicalDrives()
        {
            return Directory.GetLogicalDrives();
        }

        /// <inheritdoc />
        public DirectoryInfo GetParent(string path)
        {
            return Directory.GetParent(path);
        }

        /// <inheritdoc />
        public void Move(string sourceDirName, string destDirName)
        {
            Directory.Move(sourceDirName, destDirName);
        }

        /// <inheritdoc />
        public void SetCreationTime(string path, DateTime creationTime)
        {
            Directory.SetCreationTime(path, creationTime);
        }

        /// <inheritdoc />
        public void SetCreationTimeUtc(string path, DateTime creationTime)
        {
            Directory.SetLastWriteTimeUtc(path, creationTime);
        }

        /// <inheritdoc />
        public void SetCurrentDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);
        }

        /// <inheritdoc />
        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            Directory.SetLastAccessTime(path, lastAccessTime);
        }

        /// <inheritdoc />
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            Directory.SetLastWriteTimeUtc(path, lastAccessTimeUtc);
        }
        
        /// <inheritdoc />
        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            Directory.SetLastWriteTime(path, lastWriteTime);
        }

        /// <inheritdoc />
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }
    }
}