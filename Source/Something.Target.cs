using UnrealBuildTool;
using System.Collections.Generic;

// https://docs.unrealengine.com/en-US/ProductionPipelines/BuildTools/UnrealBuildTool/TargetFiles/index.html
public class SomethingTarget : TargetRules
{
	public SomethingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Something" } );

		bUsePCHFiles = false;

		bIWYU = true;
		bEnforceIWYU = true;

		// bUseUnityBuild = true;
		// bForceUnityBuild = false;
		// bUseAdaptiveUnityBuild = true;
	}
}
