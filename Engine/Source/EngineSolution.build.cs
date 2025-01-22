using System;
using System.IO;
using Sharpmake;

[module: Include("Utils.cs")]

[Generate]
public class EngineSolution : Solution
{
    public EngineSolution() : base(typeof(EngineTarget))
    {
        // 솔루션의 이름입니다.
        IsFileNameToLower = false;
        Name = "Engine";

        // 프로젝트와 마찬가지로, 이 솔루션이 빌드되는 대상을 정의합니다.
        // 일반적으로 같은 대상을 사용합니다.
        AddTargets(new EngineTarget(
            ELaunchType.Editor | ELaunchType.Client | ELaunchType.Server,
            Platform.win64,
            DevEnv.vs2022,
            Optimization.Debug | Optimization.Release));
    }

    // 생성된 4가지 모든 대상(Target)에 대해 설정을 구성합니다.
    // 이번에는 구성 객체의 타입이 Solution.Configuration임을 참고하세요.
    // (Project.Configuration이 아닌 점에 유의하세요.)
    [Configure()]
    public virtual void ConfigureAll(Configuration conf, EngineTarget target)
    {
        Utils.MakeConfiturationNameDefine(conf, target);

        conf.SolutionPath = Utils.GetSolutionDir() + @"\Intermediate\ProjectFiles";
        string ProjectFilesDir = Utils.GetSolutionDir() + @"\Intermediate\ProjectFiles";
        Environment.SetEnvironmentVariable("ProjectFilesDir", ProjectFilesDir);

        // BasicsProject로 설명된 프로젝트를 솔루션에 추가합니다.
        // 이는 구성(Configuration)에서 이루어지므로 대상(Target)에 따라
        // 다른 프로젝트를 포함하는 솔루션을 생성할 수 있습니다.
        //
        // 예를 들어, 64비트만 지원하는 프로젝트를 32비트 대상에서는
        // 제외할 수 있습니다.

        //conf.AddProject<BasicsProject>(target);
    }
}