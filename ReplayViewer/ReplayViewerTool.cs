using GBX.NET.Engines.Game;
using GbxToolAPI;
using MapViewerEngine;

namespace ReplayViewer;

[ToolName("Replay Viewer")]
[ToolDescription("View replays in a web browser.")]
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
