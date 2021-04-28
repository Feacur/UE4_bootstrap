using UnrealBuildTool;
using System.Collections.Generic;

// https://docs.unrealengine.com/en-US/ProductionPipelines/BuildTools/UnrealBuildTool/TargetFiles/index.html
public class SomethingEditorTarget : TargetRules
{
	public SomethingEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Something");

		// bPrintToolChainTimingInfo = true;
		// bParseTimingInfoForTracing = true;

		bUsePCHFiles = false;

		bIWYU = true;
		bEnforceIWYU = true;

		bUseUnityBuild = true;
		bForceUnityBuild = true;
		bUseAdaptiveUnityBuild = false;
	}
}
