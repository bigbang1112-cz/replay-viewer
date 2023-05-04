using GBX.NET.Engines.Scene;
using MapViewerEngine.Modules;
using ReplayViewer.Modules;
using System.Runtime.InteropServices.JavaScript;

namespace ReplayViewer.Tweens;

class VehicleWheelFLRotation : Animation
{
    public override JSObject GetMember(JSObject ghost)
    {
        var wheel = Vehicle.GetObjectByName(ghost, "1FLWheel")?.GetPropertyAsJSObject("rotation")!;
        Vehicle.ReorderEuler(wheel);
        return wheel;
    }

    public override JSObject CreateKeyframe(int period, CSceneVehicleCar.Sample sample)
    {
        return Timeline.CreateKeyframeVec(period, sample.FLWheelRotation, sample.SteerFront, 0);
    }
}
