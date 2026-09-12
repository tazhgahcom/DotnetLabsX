using Tazhgah.DesignPatterns.Command.Interfaces;

namespace Tazhgah.DesignPatterns.Command.Commands
{
    public class CreateDirectoryCommand(IFileSystemService fileSystemService) : ICommand
    {

        protected IFileSystemService _fileSystemService = fileSystemService;

        public void Execute(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Missing directory path. Usage: mkdir <path>");
            }

            Console.WriteLine(args[0]);

            string path = Path.Join(Directory.GetCurrentDirectory(), args[0]);

            _fileSystemService.CreateDirectory(path);
        }
    }
}
