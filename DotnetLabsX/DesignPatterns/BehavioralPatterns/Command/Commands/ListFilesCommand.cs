using Tazhgah.DesignPatterns.Command.Interfaces;

namespace Tazhgah.DesignPatterns.Command.Commands
{
    public class ListFilesCommand(IFileSystemService fileSystemService) : ICommand
    {

        protected readonly IFileSystemService _fileSystemService = fileSystemService;

        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing arg. Usage: lsfiles <path>.");
                return;
            }
            string[] files = _fileSystemService.ListFiles(args[0]);
            foreach (string file in files) 
            {
                Console.WriteLine(file);
            }
        }
    }
}
