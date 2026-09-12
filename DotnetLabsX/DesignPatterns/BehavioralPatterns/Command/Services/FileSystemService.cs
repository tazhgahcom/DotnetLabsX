using Tazhgah.DesignPatterns.Command.Interfaces;

namespace Tazhgha.DesignPatterns.Command.Services
{
    public class FileSystemService : IFileSystemService
    {
        public DirectoryInfo CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path);        
        }

        public FileInfo CreateFile(string path)
        {
            File.Create(path);
            FileInfo fi = new FileInfo(path);
            return fi;
        }

        public DirectoryInfo DeleteDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException();
            }
            DirectoryInfo di = new DirectoryInfo(path);
            Directory.Delete(path, true);
            return di;
        }

        public FileInfo DeleteFile(string path)
        {
            FileInfo fi = new FileInfo(path);
            File.Delete(path);
            return fi;
        }

        public string[] ListDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }

        public string[] ListFiles(string path)
        {
            return Directory.GetFiles(path);
        }
    }
}
