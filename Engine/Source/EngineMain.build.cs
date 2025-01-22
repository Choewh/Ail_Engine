using System.IO;
using Sharpmake;

[module: Include("EngineSolution.build.cs")]
[module: Include("Utils.cs")]

public static class Main
{
    [Sharpmake.Main]
    public static void SharpmakeMain(Sharpmake.Arguments arguments)
    {

        // KitsRootPaths.SetUseKitsRootForDevEnv 는
        // 환경 조건을 걸어 동일한 환경에서만 작업할 수 있도록 함
        KitsRootPaths.SetUseKitsRootForDevEnv(DevEnv.vs2022, KitsRootEnum.KitsRoot10, Options.Vc.General.WindowsTargetPlatformVersion.Latest);
        
        // Sharpmake에게 EngineSolution 설명된 솔루션을 생성하라고 지시합니다.
        arguments.Generate<EngineSolution>();

    }
}