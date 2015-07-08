using ObjCRuntime;

[assembly: LinkWith ("libUserVoice.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64, ForceLoad = true)]