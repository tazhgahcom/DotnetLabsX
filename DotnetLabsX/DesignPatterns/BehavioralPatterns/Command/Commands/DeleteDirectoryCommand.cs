using Tazhgah.DesignPatterns.Command.Interfaces;

namespace Tazhgah.DesignPatterns.Command.Commands
{
    public class DeleteDirectoryCommand(IFileSystemService fileSystemService) : ICommand
    {

        protected readonly IFileSystemService _fileSystemService = fileSystemService;

        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing args. Usage: rmdir <path>");
                return;
            }

            _fileSystemService.DeleteDirectory(args[0]);
        }
    }
}
