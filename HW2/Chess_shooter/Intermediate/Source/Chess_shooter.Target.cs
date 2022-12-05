using UnrealBuildTool;

public class Chess_shooterTarget : TargetRules
{
	public Chess_shooterTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Chess_shooter");
	}
}
