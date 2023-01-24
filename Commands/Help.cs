using CustomShell.API.Features;
using CustomShell.Handlers;

namespace CustomShell.Commands;

public class Help : ICommand
{
#region Command: Info

	public string Name { get; } = "Help";
	public string Command { get; } = "help";

	public string Description { get; } =
		"The Help command. This command is used to give insight on each existing command.";

	public Dictionary<int, ICommandArguments> Arguments { get; } = new Dictionary<int, ICommandArguments>()
	{
		{
			1,
			new ICommandArguments("command", "The command to get information about", false)
		}
	};

	public bool IsSudo { get; } = false;
	public string Example { get; } = "help [?command]";
	public bool HasCustomHelp { get; } = false;

#endregion

#region Command: Methods

	public bool Load()
	{
		return true;
	}

	public void Execute(string[] arguments)
	{
		if (IO.IsDebug)
		{
			AnsiConsole.MarkupLineInterpolated($"[yellow]{string.Join(" | ", arguments)}[/]");
		}

		if (Shell.Commands.ContainsKey(arguments.First()))
		{
			ICommand command = Shell.Commands[arguments.First()];
			if (command.HasCustomHelp)
			{
				Shell.CommandsHelpExt[command.Command].CustomHelp();
			}
			else
			{
				this._getCommandHelp(command);
			}
		}
		else
		{
			AnsiConsole.MarkupLineInterpolated(
				$"[green]Total Amount of Commands[/][bold white]:[/] [aqua]{Shell.TotalCommands.ToString()}[/]");
			foreach (var command in Shell.Commands)
			{
				AnsiConsole.MarkupLineInterpolated(
					$"[lime]Command[/][bold white]:[/] [aqua]{command.Value.Example}[/]");
			}
		}
	}

#endregion

	private void _getCommandHelp(ICommand command)
	{
		// displays default info
		// Name: command name
		// Example: command example
		// Description: command desc
		// Arguments
		// etc
	}
}