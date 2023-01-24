namespace CustomShell.API.Features;

/// <summary>
///     ICommandExtHelp
///     This interface allows the command developer to build a custom help message for the shell to use instead of the
///     default one
/// </summary>
public interface ICommandExtHelp
{
#region Command: Method

	[Description("The Actual Command")] string Command { get; }
	[Description("The method to add the info into")]
	void CustomHelp();

#endregion
}