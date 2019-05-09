using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    ///     Wrapper for <see cref="System.IO.File" /> to allow unit testing
    /// </summary>
    public interface IFileProvider
    {
        /// <summary>
        ///     Appends lines to a file, and then closes the file. If the specified file does not exist, this method creates a
        ///     file, writes the specified lines to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        void AppendAllLines(string path, IEnumerable<string> contents);

        /// <summary>
        ///     Appends lines to a file, and then closes the file. If the specified file does not exist, this method creates a
        ///     file, writes the specified lines to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);

        /// <summary>
        ///     Opens a file, appends the specified string to the file, and then closes the file. If the file does not exist, this
        ///     method creates a file, writes the specified string to the file, then closes the file.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        void AppendAllText(string path, string contents);

        /// <summary>
        ///     Appends the specified string to the file, creating the file if it does not already exist.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        void AppendAllText(string path, string contents, Encoding encoding);

        /// <summary>
        /// Creates a StreamWriter that appends UTF-8 encoded text to an existing file, or to a new file if the specified file does not exist.
        /// </summary>
        /// <param name="path">The path to the file to append to.</param>
        /// <returns>A stream writer that appends UTF-8 encoded text to the specified file or to a new file.</returns>
        StreamWriter AppendText(string path);

        /// <summary>
        /// Copies an existing file to a new file. Overwriting a file of the same name is not allowed.
        /// </summary>
        /// <param name="sourceFileName">The file to copy</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory or an existing file.</param>
        void Copy(string sourceFileName, string destFileName);

        /// <summary>
        /// Copies an existing file to a new file. Overwriting a file of the same name is allowed.
        /// </summary>
        /// <param name="sourceFileName">The file to copy</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory or an existing file.</param>
        /// <param name="overwrite">true if the destination file can be overwritten; otherwise, false.</param>
        void Copy(string sourceFileName, string destFileName, bool overwrite);

        /// <summary>
        /// Creates or overwrites a file in the specified path.
        /// </summary>
        /// <param name="path">The path and name of the file to create.</param>
        /// <returns>A FileStream that provides read/write access to the file specified in path.</returns>
        FileStream Create(string path);

        /// <summary>
        /// Creates or overwrites the specified file.
        /// </summary>
        /// <param name="path">The path and name of the file to create.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <returns></returns>
        FileStream Create(string path, int bufferSize);

        /// <summary>
        /// Creates or overwrites the specified file.
        /// </summary>
        /// <param name="path">The path and name of the file to create.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <param name="options">One of the FileOptions values that describes how to create or overwrite the file.</param>
        /// <returns></returns>
        FileStream Create(string path, int bufferSize, FileOptions options);

        /// <summary>
        /// Creates or opens a file for writing UTF-8 encoded text. If the file already exists, its contents are overwritten.
        /// </summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>A StreamWriter that writes to the specified file using UTF-8 encoding.</returns>
        StreamWriter CreateText(string path);

        /// <summary>
        /// Decrypts a file that was encrypted by the current account using the Encrypt(String) method.
        /// </summary>
        /// <param name="path">A path that describes a file to decrypt.</param>
        void Decrypt(string path);

        /// <summary>
        /// Deletes the specified file
        /// </summary>
        /// <param name="path">The name of the file to be deleted. Wildcard characters are not supported.</param>
        void Delete(string path);

        /// <summary>
        /// Encrypts a file so that only the account used to encrypt the file can decrypt it.
        /// </summary>
        /// <param name="path">A path that describes a file to encrypt.</param>
        void Encrypt(string path);

        /// <summary>
        /// Determines whether the specified file exists.
        /// </summary>
        /// <param name="path">The file to check.</param>
        /// <returns>true if the caller has the required permissions and path contains the name of an existing file; otherwise, false. This method also returns false if path is null, an invalid path, or a zero-length string. If the caller does not have sufficient permissions to read the specified file, no exception is thrown and the method returns false regardless of the existence of path.</returns>
        bool Exists(string path);

        /// <summary>
        /// Gets the FileAttributes of the file on the path.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>The FileAttributes of the file on the path.</returns>
        FileAttributes GetAttributes(string path);

        /// <summary>
        /// Returns the creation date and time of the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A DateTime structure set to the creation date and time for the specified file or directory. This value is expressed in local time.</returns>
        DateTime GetCreationTime(string path);

        /// <summary>
        /// Returns the creation date and time, in coordinated universal time (UTC), of the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A DateTime structure set to the creation date and time for the specified file or directory. This value is expressed in UTC time.</returns>
        DateTime GetCreationTimeUtc(string path);

        /// <summary>
        /// Returns the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A DateTime structure set to the date and time that the specified file or directory was last accessed. This value is expressed in local time.</returns>
        DateTime GetLastAccessTime(string path);

        /// <summary>
        /// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A DateTime structure set to the date and time that the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
        DateTime GetLastAccessTimeUtc(string path);

        /// <summary>
        /// Returns the date and time the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A DateTime structure set to the date and time that the specified file or directory was last written to. This value is expressed in local time.</returns>
        DateTime GetLastWriteTime(string path);

        /// <summary>
        /// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A DateTime structure set to the date and time that the specified file or directory was last written to. This value is expressed in UTC time.</returns>
        DateTime GetLastWriteTimeUtc(string path);

        /// <summary>
        /// Moves a specified file to a new location, providing the option to specify a new file name.
        /// </summary>
        /// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
        /// <param name="destFileName">The new path and name for the file.</param>
        void Move(string sourceFileName, string destFileName);

        /// <summary>
        /// Opens a FileStream on the specified path with read/write access with no sharing.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <returns>A FileStream opened in the specified mode and path, with read/write access and not share</returns>
        FileStream Open(string path, System.IO.FileMode mode);

        /// <summary>
        /// Opens a FileStream on the specified path with read/write access with no sharing.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A FileAccess value that specifies the operations that can be performed on the file.</param>
        /// <returns>A FileStream opened in the specified mode and path, with read/write access and not share</returns>
        FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access);

        /// <summary>
        /// Opens a FileStream on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A FileAccess value that specifies the operations that can be performed on the file.</param>
        /// <param name="share">A FileShare value specifying the type of access other threads have to the file.</param>
        /// <returns></returns>
        FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share);

        /// <summary>
        /// Opens an existing file for reading.
        /// </summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A read-only FileStream on the specified path.</returns>
        FileStream OpenRead(string path);

        /// <summary>
        /// Opens an existing UTF-8 encoded text file for reading.
        /// </summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A StreamReader on the specified path.</returns>
        StreamReader OpenText(string path);

        /// <summary>
        /// Opens an existing file or creates a new file for writing.
        /// </summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>An unshared FileStream object on the specified path with Write access.</returns>
        FileStream OpenWrite(string path);

        /// <summary>
        /// Opens a binary file, reads the contents of the file into a byte array, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A byte array containing the contents of the file.</returns>
        byte[] ReadAllBytes(string path);

        /// <summary>
        /// Opens a text file, reads all lines of the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A string array containing all lines of the file.</returns>
        string[] ReadAllLines(string path);

        /// <summary>
        /// Opens a file, reads all lines of the file with the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading</param>
        /// <param name="encoding">The encoding applied to the contents of the file.</param>
        /// <returns></returns>
        string[] ReadAllLines(string path, Encoding encoding);

        /// <summary>
        /// Opens a file, reads all text in the file with the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding"></param>
        /// <returns>The encoding applied to the contents of the file.</returns>
        string ReadAllText(string path, Encoding encoding);

        /// <summary>
        /// Opens a text file, reads all the text in the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>The encoding applied to the contents of the file.</returns>
        string ReadAllText(string path);

        /// <summary>
        /// Reads the lines of a file.
        /// </summary>
        /// <param name="path">The file to read</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        IEnumerable<string> ReadLines(string path);

        /// <summary>
        /// Read the lines of a file that has a specified encoding.
        /// </summary>
        /// <param name="path">The file to read</param>
        /// <param name="encoding">The encoding that is applied to the contents of the file.</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        IEnumerable<string> ReadLines(string path, Encoding encoding);

        /// <summary>
        /// Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file.
        /// </summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);

        /// <summary>
        /// Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file and optionally ignores merge errors.
        /// </summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and access control lists (ACLs)) from the replaced file to the replacement file; otherwise, false.</param>
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

        /// <summary>
        /// Sets the specified FileAttributes of the file on the specified path.
        /// </summary>
        /// <param name="path">The path to the file</param>
        /// <param name="fileAttributes">A bitwise combination of the enumeration values.</param>
        void SetAttributes(string path, System.IO.FileAttributes fileAttributes);

        /// <summary>
        /// Sets the date and time the file was created.
        /// </summary>
        /// <param name="path">The file for which to set the creation date and time information</param>
        /// <param name="creationTime">A DateTime containing the value to set for the creation date and time of path. This value is expressed in local time.</param>
        void SetCreationTime(string path, DateTime creationTime);

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the file was created.
        /// </summary>
        /// <param name="path">The file for which to set the creation date and time information.</param>
        /// <param name="creationTimeUtc">A DateTime containing the value to set for the creation date and time of path. This value is expressed in UTC time.</param>
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);

        /// <summary>
        /// Sets the date and time the specified file was last accessed.
        /// </summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTime">A DateTime containing the value to set for the last access date and time of path. This value is expressed in local time</param>
        void SetLastAccessTime(string path, DateTime lastAccessTime);

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the specified file was last accessed.
        /// </summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTimeUtc">A DateTime containing the value to set for the last access date and time of path. This value is expressed in UTC time.</param>
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);

        /// <summary>
        /// Sets the date and time that the specified file was last written to.
        /// </summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTime">A DateTime containing the value to set for the last write date and time of path. This value is expressed in local time.</param>
        void SetLastWriteTime(string path, DateTime lastWriteTime);

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the specified file was last written to.
        /// </summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTimeUtc">A DateTime containing the value to set for the last write date and time of path. This value is expressed in UTC time.</param>
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);

        /// <summary>
        /// Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to</param>
        /// <param name="bytes">The bytes to write to the file.</param>
        void WriteAllBytes(string path, byte[] bytes);

        /// <summary>
        /// Creates a new file, writes the specified string array to the file by using the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to</param>
        /// <param name="contents">The string array to write to the file.</param>
        /// <param name="encoding">An Encoding object that represents the character encoding applied to the string array.</param>
        void WriteAllLines(string path, string[] contents, System.Text.Encoding encoding);

        /// <summary>
        /// Creates a new file by using the specified encoding, writes a collection of strings to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to</param>
        /// <param name="contents">The lines to write to the file.</param>
        /// <param name="encoding">An Encoding object that represents the character encoding applied to the string array.</param>
        void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents,
            System.Text.Encoding encoding);

        /// <summary>
        /// Creates a new file, write the specified string array to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to</param>
        /// <param name="contents">The lines to write to the file.</param>
        void WriteAllLines(string path, string[] contents);

        /// <summary>
        /// Creates a new file, writes a collection of strings to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to</param>
        /// <param name="contents">The lines to write to the file.</param>
        void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents);

        /// <summary>
        /// Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to</param>
        /// <param name="contents">The string to write to the file.</param>
        void WriteAllText(string path, string contents);

        /// <summary>
        /// Creates a new file, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to</param>
        /// <param name="contents">The string to write to the file.</param>
        /// <param name="encoding">The encoding to apply to the string.</param>
        void WriteAllText(string path, string contents, System.Text.Encoding encoding);
    }

    public class FileProvider : IFileProvider
    {
        /// <inheritdoc />
        public void AppendAllLines(string path, IEnumerable<string> contents)
        {
            File.AppendAllLines(path, contents);
        }

        /// <inheritdoc />
        public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            File.AppendAllLines(path, contents, encoding);
        }

        /// <inheritdoc />
        public void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }

        /// <inheritdoc />
        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }

        /// <inheritdoc />
        public StreamWriter AppendText(string path)
        {
            return File.AppendText(path);
        }

        /// <inheritdoc />
        public void Copy(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName);
        }

        /// <inheritdoc />
        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }

        /// <inheritdoc />
        public FileStream Create(string path)
        {
            return File.Create(path);
        }

        /// <inheritdoc />
        public FileStream Create(string path, int bufferSize)
        {
            return File.Create(path, bufferSize);
        }

        /// <inheritdoc />
        public FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return File.Create(path, bufferSize, options);
        }

        /// <inheritdoc />
        public StreamWriter CreateText(string path)
        {
            return File.CreateText(path);
        }

        /// <inheritdoc />
        public void Decrypt(string path)
        {
            File.Decrypt(path);
        }

        /// <inheritdoc />
        public void Delete(string path)
        {
            File.Delete(path);
        }

        /// <inheritdoc />
        public void Encrypt(string path)
        {
            File.Encrypt(path);
        }

        /// <inheritdoc />
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <inheritdoc />
        public FileAttributes GetAttributes(string path)
        {
            return File.GetAttributes(path);
        }

        /// <inheritdoc />
        public DateTime GetCreationTime(string path)
        {
            return File.GetCreationTime(path);
        }

        /// <inheritdoc />
        public DateTime GetCreationTimeUtc(string path)
        {
            return File.GetCreationTimeUtc(path);
        }

        /// <inheritdoc />
        public DateTime GetLastAccessTime(string path)
        {
            return File.GetLastAccessTime(path);
        }

        /// <inheritdoc />
        public DateTime GetLastAccessTimeUtc(string path)
        {
            return File.GetLastAccessTimeUtc(path);
        }

        /// <inheritdoc />
        public DateTime GetLastWriteTime(string path)
        {
            return File.GetLastWriteTime(path);
        }

        /// <inheritdoc />
        public DateTime GetLastWriteTimeUtc(string path)
        {
            return File.GetLastWriteTimeUtc(path);
        }

        /// <inheritdoc />
        public void Move(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

        /// <inheritdoc />
        public FileStream Open(string path, System.IO.FileMode mode)
        {
            return File.Open(path, mode);
        }

        /// <inheritdoc />
        public FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access)
        {
            return File.Open(path, mode, access);
        }

        /// <inheritdoc />
        public FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access,
            System.IO.FileShare share)
        {
            return File.Open(path, mode, access, share);
        }

        /// <inheritdoc />
        public FileStream OpenRead(string path)
        {
            return File.OpenRead(path);
        }

        /// <inheritdoc />
        public StreamReader OpenText(string path)
        {
            return File.OpenText(path);
        }

        /// <inheritdoc />
        public FileStream OpenWrite(string path)
        {
            return File.OpenWrite(path);
        }

        /// <inheritdoc />
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        /// <inheritdoc />
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        /// <inheritdoc />
        public string[] ReadAllLines(string path, Encoding encoding)
        {
            return File.ReadAllLines(path, encoding);
        }

        /// <inheritdoc />
        public string ReadAllText(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        /// <inheritdoc />
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        /// <inheritdoc />
        public IEnumerable<string> ReadLines(string path)
        {
            return File.ReadLines(path);
        }

        /// <inheritdoc />
        public IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return File.ReadLines(path, encoding);
        }

        /// <inheritdoc />
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }

        /// <inheritdoc />
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName,
            bool ignoreMetadataErrors)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }

        /// <inheritdoc />
        public void SetAttributes(string path, System.IO.FileAttributes fileAttributes)
        {
            File.SetAttributes(path, fileAttributes);
        }

        /// <inheritdoc />
        public void SetCreationTime(string path, DateTime creationTime)
        {
            File.SetCreationTime(path, creationTime);
        }

        /// <inheritdoc />
        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            File.SetCreationTimeUtc(path, creationTimeUtc);
        }

        /// <inheritdoc />
        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            File.SetLastAccessTime(path, lastAccessTime);
        }

        /// <inheritdoc />
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            File.SetCreationTimeUtc(path, lastAccessTimeUtc);
        }

        /// <inheritdoc />
        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            File.SetLastAccessTime(path, lastWriteTime);
        }

        /// <inheritdoc />
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        /// <inheritdoc />
        public void WriteAllBytes(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        /// <inheritdoc />
        public void WriteAllLines(string path, string[] contents, System.Text.Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }

        /// <inheritdoc />
        public void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents,
            System.Text.Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }

        /// <inheritdoc />
        public void WriteAllLines(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }

        /// <inheritdoc />
        public void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents)
        {
            File.WriteAllLines(path, contents);
        }

        /// <inheritdoc />
        public void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        /// <inheritdoc />
        public void WriteAllText(string path, string contents, System.Text.Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }
    }
}