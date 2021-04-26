using UnrealBuildTool;

// https://docs.unrealengine.com/en-US/ProductionPipelines/BuildTools/UnrealBuildTool/ModuleFiles/index.html
public class Something : ModuleRules
{
	public Something(ReadOnlyTargetRules Target) : base(Target)
	{
		bEnforceIWYU = true;
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		// bEnableExceptions = false;
		// bUseRTTI = false;
	}
}
