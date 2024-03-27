using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GraphicsResourcesRecreate                Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 EngineUpdate                             Action IL2CPP_TYPE_CLASS
    // 010 FlushPendingResources                    000186679C50 ModelClassType Action Action Action Pointer
    // 018 RegisterIntermediateRenderers            Action`1<Camera> IL2CPP_TYPE_GENERICINST
    // 020 RenderNodeAdd                            Action`1<<int>> IL2CPP_TYPE_GENERICINST
    // 028 RenderNodeExecute                        Action`1<<int>> IL2CPP_TYPE_GENERICINST
    // 030 RenderNodeCleanup                        Action`1<<int>> IL2CPP_TYPE_GENERICINST
    // 038 S_MarkerRaiseEngineUpdate                0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    public partial class Utility
    {
        public Action?                                  FlushPendingResources                   { get; set; }
        public ProfilerMarker                           S_MarkerRaiseEngineUpdate               { get; set; }

        public static Utility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utility();

            value.FlushPendingResources                     = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0270022C1370 0x10 FlushPendingResources       ( 000186679C50 ModelClassType Action Action Action Pointer )
            value.S_MarkerRaiseEngineUpdate                 = (ProfilerMarker)GetInt32(new IntPtr(p + 0x038)); // 0270022C1410 0x38 S_MarkerRaiseEngineUpdate   ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )

            return value;
        }
    }
}
