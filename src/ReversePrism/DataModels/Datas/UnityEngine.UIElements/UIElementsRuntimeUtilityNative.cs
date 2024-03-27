using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RepaintOverlayPanelsCallback             Action IL2CPP_TYPE_CLASS
    // 008 UpdateRuntimePanelsCallback              Action IL2CPP_TYPE_CLASS
    // 010 RepaintOffscreenPanelsCallback           000186679EC0 ModelClassType Action Action Action Pointer
    public partial class UIElementsRuntimeUtilityNative
    {
        public Action?                                  RepaintOffscreenPanelsCallback          { get; set; }

        public static UIElementsRuntimeUtilityNative? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIElementsRuntimeUtilityNative();

            value.RepaintOffscreenPanelsCallback            = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0270022B8428 0x10 RepaintOffscreenPanelsCallback ( 000186679EC0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
