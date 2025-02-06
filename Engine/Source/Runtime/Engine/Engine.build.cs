using System;
using System.IO;
using Sharpmake;

[Generate]
public class Engine : CommonProject
{
    public Engine() { }

    public override void ConfigureAll(Configuration conf, EngineTarget target)
    {
        base.ConfigureAll(conf, target);
        conf.AddPublicDependency<Core>(target);
    }
}