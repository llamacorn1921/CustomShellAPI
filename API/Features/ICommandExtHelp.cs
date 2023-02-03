namespace CustomShell.API.Features;

/// <summary>
///     ICommandExtHelp
///     This interface allows the command developer to build a custom help message for the shell to use instead of the
///     default one
/// </summary>
public interface ICommandExtHelp : ICommand
{

#region Command: Method

	/// <summary>
	///     Put all the info inside this.
	/// </summary>
	[Description("The method to add the info into")]
	void CustomHelp();

#endregion
}