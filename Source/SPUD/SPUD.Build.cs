using UnrealBuildTool;
using System.IO;
using Microsoft.Extensions.Logging;


public class SPUD : ModuleRules
{
	
	public SPUD(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		//PublicIncludePaths.Add(ModuleDirectory);
		//PrivateIncludePaths.Add(ModuleDirectory);
		
		
		void AddPublicPrivatePaths()
		{
			bAddDefaultIncludePaths = true;
			foreach(string dir in Directory.GetDirectories(ModuleDirectory))
			{
				Logger.LogInformation("{m}: PublicPath= {p}", Name, dir);
			}
			
			PublicIncludePaths.Add(ModuleDirectory);
			PrivateIncludePaths.Add(ModuleDirectory);

			string DefaultPublicPath = Path.Combine(ModuleDirectory, "Public");
			Logger.LogInformation("{m}: PublicPath= {p}", Name, DefaultPublicPath);
			PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
			
			string DefaultPrivatePath = Path.Combine(ModuleDirectory, "Private");
			Logger.LogInformation("{m}: PrivatePath= {p}", Name, DefaultPrivatePath);
			PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));
		}
		AddPublicPrivatePaths();

		PublicIncludePaths.AddRange(new string[] { });
		PrivateIncludePaths.AddRange(new string[] { });
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine"
			}
			);
			
		PrivateDependencyModuleNames.AddRange(new string[] { });
		DynamicallyLoadedModuleNames.AddRange(new string[] { } );

		
	}
}
