using GBX.NET.Engines.Scene;
using MapViewerEngine.Modules;
using ReplayViewer.Modules;
using System.Runtime.InteropServices.JavaScript;

namespace ReplayViewer.Tweens;

class VehicleWheelRRRotation : Animation
{
    public override JSObject GetMember(JSObject ghost)
    {
        var wheel = Vehicle.GetObjectByName(ghost, "1RRWheel")?.GetPropertyAsJSObject("rotation")!;
        Vehicle.ReorderEuler(wheel);
        return wheel;
    }

    public override JSObject CreateKeyframe(int period, CSceneVehicleCar.Sample sample)
    {
        return Timeline.CreateKeyframeVec(period, sample.RRWheelRotation, 0, 0);
    }
}
