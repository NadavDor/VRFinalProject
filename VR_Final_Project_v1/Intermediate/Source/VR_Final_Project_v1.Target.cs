using UnrealBuildTool;

public class VR_Final_Project_v1Target : TargetRules
{
	public VR_Final_Project_v1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_Final_Project_v1");
	}
}
