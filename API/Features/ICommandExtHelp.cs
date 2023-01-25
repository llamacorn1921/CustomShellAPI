namespace CustomShell.API.Features;

/// <summary>
///     ICommandExtHelp
///     This interface allows the command developer to build a custom help message for the shell to use instead of the
///     default one
/// </summary>
public interface ICommandExtHelp
{
	#region Command: Info

	/// <summary>
	/// The command. 
	/// </summary>
	/// <returns></returns>
	[Description("The Actual Command")] string Command { get; }

	#endregion
#region Command: Method

	/// <summary>
	/// Put all the info inside this.
	/// </summary>
	[Description("The method to add the info into")]
	void CustomHelp();

#endregion
}