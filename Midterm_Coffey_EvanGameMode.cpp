// Copyright Epic Games, Inc. All Rights Reserved.

#include "Midterm_Coffey_EvanGameMode.h"
#include "Midterm_Coffey_EvanHUD.h"
#include "Midterm_Coffey_EvanCharacter.h"
#include "UObject/ConstructorHelpers.h"

AMidterm_Coffey_EvanGameMode::AMidterm_Coffey_EvanGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = AMidterm_Coffey_EvanHUD::StaticClass();
}
