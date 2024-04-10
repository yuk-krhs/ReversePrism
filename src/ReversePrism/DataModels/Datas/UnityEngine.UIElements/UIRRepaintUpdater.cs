using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AttachedPanel                            000186745F20 ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer
    // 028 RenderChain                              00018664F8D0 ModelClassType RenderChain RenderChain RenderChain Pointer
    // 000 s_Description                            string IL2CPP_TYPE_STRING
    // 008 s_ProfilerMarker                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 030 DrawStats                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 BreakBatches                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UIRRepaintUpdater : DataModel
    {
        public BaseVisualElementPanel?                  AttachedPanel                           { get; set; }
        public RenderChain?                             RenderChain                             { get; set; }
        public bool                                     DrawStats                               { get; set; }
        public bool                                     BreakBatches                            { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static UIRRepaintUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRRepaintUpdater() { Pointer= p0 };

            value.AttachedPanel                             = GetObject<BaseVisualElementPanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.BaseVisualElementPanel.FromPointer); // 0245A67AB370 0x20 AttachedPanel               ( 000186745F20 ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer )
            value.RenderChain                               = GetObject<RenderChain>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderChain.FromPointer); // 0245A67AB390 0x28 RenderChain                 ( 00018664F8D0 ModelClassType RenderChain RenderChain RenderChain Pointer )
            value.DrawStats                                 = GetBool(new IntPtr(p + 0x030)); // 0245A67AB3F0 0x30 DrawStats                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BreakBatches                              = GetBool(new IntPtr(p + 0x031)); // 0245A67AB410 0x31 BreakBatches                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x032)); // 0245A67AB430 0x32 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
