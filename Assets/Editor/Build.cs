using UnityEditor;
using System.Linq;
using System;
using System.IO;
using UnityEngine;
using UnityEditor.Build.Reporting;

static class Build
{
	static void WebGL()
	{
		BuildPipeline.BuildPlayer(new BuildPlayerOptions()
		{
			scenes = (from scene in EditorBuildSettings.scenes where scene.enabled select scene.path).ToArray(),
			locationPathName = "web",
			target = BuildTarget.WebGL,
			options = BuildOptions.None
		});
	}
}
