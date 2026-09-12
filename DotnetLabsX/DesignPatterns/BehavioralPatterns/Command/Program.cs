using Tazhgah.DesignPatterns.Command.Commands;
using Tazhgah.DesignPatterns.Command.Interfaces;
using Tazhgha.DesignPatterns.Command.Services;

namespace Tazhgah.DesignPatterns.Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFileSystemService fileSystemService = new FileSystemService();

            CLI cli = new();
            cli.RegisterCommand("mkdir", new CreateDirectoryCommand(fileSystemService));
            cli.RegisterCommand("rmdir", new DeleteDirectoryCommand(fileSystemService));
            cli.RegisterCommand("ls", new ListDirectoriesCommand(fileSystemService));
            cli.RegisterCommand("lsfiles", new ListFilesCommand(fileSystemService));
            cli.RegisterCommand("touch", new CreateFileCommand(fileSystemService));
            cli.RegisterCommand("unlink", new DeleteFileCommand(fileSystemService));
            cli.RegisterCommand("pwd", new WorkingDirectoryCommand(fileSystemService));


            if (args is [var commandName, .. var commandArgs])
            {
                cli.ExecuteCommand(commandName, commandArgs);
            }
        }
    }
}