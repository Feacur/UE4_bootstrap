using UnrealBuildTool;

// https://docs.unrealengine.com/en-US/ProductionPipelines/BuildTools/UnrealBuildTool/ModuleFiles/index.html
public class Something : ModuleRules
{
	public Something(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PrivateDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		bEnforceIWYU = true;

		bEnableExceptions = false;
		bUseRTTI = false;
	}
}
