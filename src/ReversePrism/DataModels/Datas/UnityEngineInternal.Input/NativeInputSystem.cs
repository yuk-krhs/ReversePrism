using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onUpdate                                 NativeUpdateCallback IL2CPP_TYPE_CLASS
    // 008 onBeforeUpdate                           Action`1<NativeInputUpdateType> IL2CPP_TYPE_GENERICINST
    // 010 onShouldRunUpdate                        Func`2<NativeInputUpdateType, bool> IL2CPP_TYPE_GENERICINST
    // 018 s_OnDeviceDiscoveredCallback             Action`2<int, string> IL2CPP_TYPE_GENERICINST
    public partial class NativeInputSystem : DataModel
    {

        public static NativeInputSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeInputSystem() { Pointer= p0 };


            return value;
        }
    }
}
