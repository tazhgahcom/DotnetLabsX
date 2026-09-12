using Tazhgah.DesignPatterns.Command.Interfaces;

namespace Tazhgah.DesignPatterns.Command.Commands
{
    public class ListDirectoriesCommand(IFileSystemService fileSystemService) : ICommand
    {
        protected readonly IFileSystemService _fileSystemService = fileSystemService;

        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing arg. Usage: ls <path>");
                return;
            }

            string[] directories = _fileSystemService.ListDirectories(args[0]);
            foreach (var dir in directories)
            {
                Console.WriteLine(dir);
            }
        }
    }
}
