using CustomShell.API.Features;

namespace CustomShell.Handlers;

public class Shell
{
	#region Variables: Directory
		
		public static readonly string DefaultDirectory =
			Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

		public static string CurrentDirectory => Environment.CurrentDirectory;
		public static string PreviousDirectory { get; internal set; }

	#endregion
	#region Variables: Commands
		/// <summary>
		/// Gets amount of commands
		/// </summary>
		public static int TotalCommands { get; }
		/// <summary>
		/// All the commands
		/// </summary>
		public static Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();
		/// <summary>
		/// All commands that are help extended
		/// </summary>
		public static Dictionary<string, ICommandExtHelp> CommandsHelpExt = new Dictionary<string, ICommandExtHelp>();

	#endregion

	#region Methods: Directory

		/// <summary>
		/// Change the directory safely.
		/// </summary>
		/// <param name="directory">The directory to change to.</param>
		public static void ChangeDirectory(string directory)
		{
			try
			{
				PreviousDirectory = CurrentDirectory;
				Directory.SetCurrentDirectory(directory);
			}
			catch (DirectoryNotFoundException e)
			{
				AnsiConsole.MarkupLine("[red]The given directory does not exist[/]");
			}
		}

	#endregion
}