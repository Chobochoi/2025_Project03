// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class fps : ModuleRules
{
	public fps(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// 25.01.09
		// Online Subsystem Steam을 사용하기 위해 
		// OnlineSubsystem과 OnlineSubsystemSteam 추가
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "OnlineSubsystemSteam", "OnlineSubsystem" });
	}
}
