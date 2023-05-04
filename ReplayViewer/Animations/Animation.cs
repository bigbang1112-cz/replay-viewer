using GBX.NET.Engines.Scene;
using System.Runtime.InteropServices.JavaScript;

namespace ReplayViewer.Tweens;

abstract class Animation
{
    public abstract JSObject GetMember(JSObject ghost);
    public abstract JSObject CreateKeyframe(int period, CSceneVehicleCar.Sample sample);
}
