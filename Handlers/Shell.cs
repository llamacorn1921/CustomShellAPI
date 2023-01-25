using CustomShell.API.Features;

namespace CustomShell.Handlers;
/// <summary>
/// The shell.
/// </summary>
public class Shell
{
	#region Variables: Misc
		/// <summary>
		/// Is the shell in debug mode.
		/// </summary>
		public static bool IsDebug;
	
	#endregion
	#region Variables: Directory
		/// <summary>
		/// The default directory.
		/// </summary>
		public static readonly string DefaultDirectory =
			Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		/// <summary>
		/// The current directory
		/// </summary>
		public static string CurrentDirectory => Environment.CurrentDirectory;
		/// <summary>
		/// The previous directory.
		/// </summary>
		public static string PreviousDirectory { get; internal set; }

	#endregion
	#region Variables: Commands
		/// <summary>
		/// Gets the total amount of commnds
		/// </summary>
		public static int TotalCommands
		{
			get { return Commands.Count; }
		}
		/// <summary>
		/// Gets the amount of built-in commands.
		/// </summary>
		/// <value></value>
		public static int TotalBuiltInCommands
		{
			get { return BuiltInCommands.Count; }
		}
		/// <summary>
		/// All the commands loaded.
		/// </summary>
		public static Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();
		/// <summary>
		/// All commands that are help extended.
		/// </summary>
		public static Dictionary<string, ICommandExtHelp> CommandsHelpExt = new Dictionary<string, ICommandExtHelp>();
		/// <summary>
		/// List all built-in commands.
		/// </summary>
		public static List<ICommand> BuiltInCommands = new List<ICommand>();

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