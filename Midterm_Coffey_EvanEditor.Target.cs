// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Midterm_Coffey_EvanEditorTarget : TargetRules
{
	public Midterm_Coffey_EvanEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Midterm_Coffey_Evan");
	}
}
