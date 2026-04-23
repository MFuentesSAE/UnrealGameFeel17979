// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Unreal17979 : ModuleRules
{
	public Unreal17979(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Unreal17979",
			"Unreal17979/Variant_Platforming",
			"Unreal17979/Variant_Platforming/Animation",
			"Unreal17979/Variant_Combat",
			"Unreal17979/Variant_Combat/AI",
			"Unreal17979/Variant_Combat/Animation",
			"Unreal17979/Variant_Combat/Gameplay",
			"Unreal17979/Variant_Combat/Interfaces",
			"Unreal17979/Variant_Combat/UI",
			"Unreal17979/Variant_SideScrolling",
			"Unreal17979/Variant_SideScrolling/AI",
			"Unreal17979/Variant_SideScrolling/Gameplay",
			"Unreal17979/Variant_SideScrolling/Interfaces",
			"Unreal17979/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
