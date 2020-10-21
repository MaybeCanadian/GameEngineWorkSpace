// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Midterm_Coffey_Evan : ModuleRules
{
	public Midterm_Coffey_Evan(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
