using GBX.NET.Engines.Game;
using GbxToolAPI;
using MapViewerEngine;

namespace ReplayViewer;

[ToolName("Replay Viewer")]
[ToolDescription("View replays in a web browser.")]
[ToolGitHub("bigbang1112-cz/replay-viewer", NoExe = true)]
public class ReplayViewerTool : MapViewerEngineTool
{
    private readonly CGameCtnChallenge map;
    
    public IEnumerable<CGameCtnGhost> Ghosts { get; }
    public CGameCtnReplayRecord? Replay { get; }

    public ReplayViewerTool(CGameCtnReplayRecord replay) : this(replay.Challenge ?? throw new Exception("No map found"), replay.GetGhosts())
    {
        Replay = replay;
    }

    public ReplayViewerTool(CGameCtnChallenge map, IEnumerable<CGameCtnGhost> ghosts) : base(map)
    {
        this.map = map;
        Ghosts = ghosts;
    }
}
