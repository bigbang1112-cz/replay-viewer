using GBX.NET.Engines.Game;
using MapViewerEngine;

namespace ReplayViewer;

public class ReplayViewerTool : MapViewerEngineTool
{
    public ReplayViewerTool(CGameCtnReplayRecord replay) : base(replay.Challenge ?? throw new Exception("No map found"))
    {
        
    }
}
