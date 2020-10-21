// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Midterm_Coffey_EvanTarget : TargetRules
{
	public Midterm_Coffey_EvanTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Midterm_Coffey_Evan");
	}
}
