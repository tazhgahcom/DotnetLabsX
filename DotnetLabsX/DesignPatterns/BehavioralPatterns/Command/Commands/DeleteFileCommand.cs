using Tazhgah.DesignPatterns.Command.Interfaces;

namespace Tazhgah.DesignPatterns.Command.Commands
{
    public class DeleteFileCommand(IFileSystemService fileSystemService) : ICommand
    {

        protected readonly IFileSystemService _fileSystemService = fileSystemService;

        public void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing args. Usage: unlink <path>");
                return;
            }
            _fileSystemService.DeleteFile(args[0]);
        }
    }
}
