using GBX.NET.Engines.Scene;
using MapViewerEngine.Modules;
using ReplayViewer.Modules;
using System.Runtime.InteropServices.JavaScript;

namespace ReplayViewer.Tweens;

class VehicleQuaternion : Animation
{
    public override JSObject GetMember(JSObject ghost)
    {
        return ghost.GetPropertyAsJSObject("quaternion")!;
    }

    public override JSObject CreateKeyframe(int period, CSceneVehicleCar.Sample sample)
    {
        return Timeline.CreateKeyframeQuat(period, sample.Rotation.X, sample.Rotation.Y, sample.Rotation.Z, sample.Rotation.W);
    }
}
