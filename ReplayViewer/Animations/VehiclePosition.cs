using GBX.NET.Engines.Scene;
using MapViewerEngine.Modules;
using ReplayViewer.Modules;
using System.Runtime.InteropServices.JavaScript;

namespace ReplayViewer.Tweens;

class VehiclePosition : Animation
{
    public override JSObject GetMember(JSObject ghost)
    {
        return ghost.GetPropertyAsJSObject("position")!;
    }

    public override JSObject CreateKeyframe(int period, CSceneVehicleCar.Sample sample)
    {
        return Timeline.CreateKeyframeVec(period, sample.Position.X, sample.Position.Y, sample.Position.Z);
    }
}
