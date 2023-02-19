using GBX.NET.Engines.Game;
using MapViewerEngine;

namespace ReplayViewer;

public class ReplayViewerTool : MapViewerEngineTool
{
    private readonly CGameCtnChallenge map;
    private readonly IEnumerable<CGameCtnGhost> ghosts;
    private readonly CGameCtnReplayRecord? replay;

    public ReplayViewerTool(CGameCtnChallenge map, IEnumerable<CGameCtnGhost> ghosts) : base(map)
    {
        this.map = map;
        this.ghosts = ghosts;
    }

    public ReplayViewerTool(CGameCtnReplayRecord replay) : this(replay.Challenge ?? throw new Exception("No map found"), replay.GetGhosts())
    {
        this.replay = replay;
    }
}
