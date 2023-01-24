namespace CustomShell.API.Features;

/// <summary>
///     Builder for the commands arguments
/// </summary>
public class ICommandArguments
{
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