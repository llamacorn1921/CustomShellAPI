# CustomShell-API
## This is an API Framework for the CustomShell I made to allow the user to create commands
## The api uses C# for the language, Version 10.0

 \
 \
 \
 .
# Table of Contents
1. [How to use](#How-to-use)
2. [Code Structure](#codestructure)



# How to use
<a name="codestructure"></a>
## Code Structure
The code structure of the commands looks like this
```csharp
using CustomShell.API.Features;

namespace YourNamespace;
public class Name : ICommand
{
  // this region is Only for what you see here
#region Command: Info

	public string Group { get; } = "Group";
	public string Name { get; } = "Name";
	public string Command { get; } = "command";
	public string Description { get; } = "Description"; 
	public List<ICommandArguments> Arguments { get; } = new List<ICommandArguments>();
	public bool IsSudo { get; } = false;
	public string Example { get; } = "example";
	public bool HasCustomHelp { get; } = false;

#endregion

#region Command: Methods

	public bool Load()
	{
		
	}

	public void Execute(string[] arguments)
	{
		
	}

#endregion
}
```
The `Load` method is called when the command is loaded at start up. This is for anything that needs to be done before the command can be used. It shall return `true` if loading was complete or `false` if loading failed. /
The `Execute` method is called when the command is called. The `arguments` paramater is anything the user will enter, excluding the actaul command call.


\
\
All packages must be place inside `user\Documents\CustomShell\Packages`. The API.dll does not need to be placed there.