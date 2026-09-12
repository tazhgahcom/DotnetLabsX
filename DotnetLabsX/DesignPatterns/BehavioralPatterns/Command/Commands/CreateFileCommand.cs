using Tazhgah.DesignPatterns.Command.Interfaces;
using Tazhgha.DesignPatterns.Command.Services;

namespace Tazhgah.DesignPatterns.Command.Commands
{
    internal class CreateFileCommand(IFileSystemService fileSystemService) : ICommand
    {
        protected readonly IFileSystemService _fileSystemService = fileSystemService;

        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing path. Usage: touch <path>");
                return;
            }
            _fileSystemService.CreateFile(args[0]);
        }
    }
}
