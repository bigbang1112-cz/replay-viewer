using GBX.NET.Engines.Scene;
using MapViewerEngine.Modules;
using ReplayViewer.Modules;
using System.Runtime.InteropServices.JavaScript;

namespace ReplayViewer.Tweens;

class VehicleWheelFRRotation : Animation
{
    public override JSObject GetMember(JSObject ghost)
    {
        var wheel = Vehicle.GetObjectByName(ghost, "1FRWheel")?.GetPropertyAsJSObject("rotation")!;
        Vehicle.ReorderEuler(wheel);
        return wheel;
    }

    public override JSObject CreateKeyframe(int period, CSceneVehicleCar.Sample sample)
    {
        return Timeline.CreateKeyframeVec(period, sample.FRWheelRotation, sample.SteerFront, 0);
    }
}
