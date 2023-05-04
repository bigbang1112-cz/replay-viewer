using System.Runtime.InteropServices.JavaScript;

namespace ReplayViewer.Modules;

internal static partial class Vehicle
{
    [JSImport("reorderEuler", nameof(Vehicle))]
    internal static partial JSObject? ReorderEuler(JSObject obj);

    [JSImport("getObjectByName", nameof(Vehicle))]
    internal static partial JSObject? GetObjectByName(JSObject obj, string name);
}
