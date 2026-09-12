using Tazhgah.DesignPatterns.Command.Interfaces;

namespace Tazhgah.DesignPatterns.Command.Commands
{
    public class WorkingDirectoryCommand(IFileSystemService fileSystemService) : ICommand
    {
        private readonly IFileSystemService _fileSystemService = fileSystemService;

        public void Execute(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}
