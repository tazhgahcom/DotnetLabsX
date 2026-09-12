namespace Tazhgah.DesignPatterns.Command.Interfaces
{
    public interface IFileSystemService
    {
        DirectoryInfo CreateDirectory(string path);
        DirectoryInfo DeleteDirectory(string path);
        FileInfo CreateFile(string path);
        FileInfo DeleteFile(string path);
        string[] ListDirectories(string path);
        string[] ListFiles(string path);
    }
}
