// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once 

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"
#include "Midterm_Coffey_EvanHUD.generated.h"

UCLASS()
class AMidterm_Coffey_EvanHUD : public AHUD
{
	GENERATED_BODY()

public:
	AMidterm_Coffey_EvanHUD();

	/** Primary draw call for the HUD */
	virtual void DrawHUD() override;

private:
	/** Crosshair asset pointer */
	class UTexture2D* CrosshairTex;

};

