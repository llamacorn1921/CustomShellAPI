namespace CustomShell.API.Features;

/// <summary>
/// Builder for the commands arguments
/// </summary>
public class ICommandArguments
{
	/// <summary>
	/// The command's argument builder
	/// </summary>
	/// <param name="name">The argument name</param>
	/// <param name="description">The arguments description</param>
	/// <param name="isRequired">Is the argument required</param>
	public ICommandArguments(string name, string description, bool isRequired)
	{
		this.Name = name;
		this.Description = description;
		this.IsRequired = isRequired;
	}

	[Description("The Argument Name")] public string Name { get; set; }
	[Description("Argument Description")] public string Description { get; set; }

	[Description("Is the argument required")]
	public bool IsRequired { get; set; }
}