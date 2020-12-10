﻿using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;

namespace Nuke.Components
{
    public interface IHazArtifacts : INukeBuild
    {
        AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";
    }
}
