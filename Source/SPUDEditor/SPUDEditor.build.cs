// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using System.IO;
using Microsoft.Extensions.Logging;
using UnrealBuildTool;

public class SPUDEditor : ModuleRules
{
	private string PluginsPath
	{
		get { return PluginDirectory; }
	}
	void AddPublicPrivatePaths()
	{
		bAddDefaultIncludePaths = true;
		
		string DefaultPublicPath = Path.Combine(ModuleDirectory, "Public");
		Logger.LogInformation("{m}: PublicPath= {p}", Name, DefaultPublicPath);
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
		
		string DefaultPrivatePath = Path.Combine(ModuleDirectory, "Private");
		Logger.LogInformation("{m}: PrivatePath= {p}", Name, DefaultPrivatePath);
		PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));
	}
	

	public SPUDEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		AddPublicPrivatePaths();

		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bAddDefaultIncludePaths = true;
		PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "Engine",
                "UnrealEd"
            }
        );
		
		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
