using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AttachedPanel                            ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer
    // 028 RenderChain                              ModelClassType RenderChain RenderChain RenderChain Pointer
    // 000 s_Description                            string IL2CPP_TYPE_STRING
    // 008 s_ProfilerMarker                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 030 DrawStats                                ModelPrimitiveType bool bool bool Bool
    // 031 BreakBatches                             ModelPrimitiveType bool bool bool Bool
    // 032 Disposed                                 ModelPrimitiveType bool bool bool Bool
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

            value.AttachedPanel                             = GetObject<BaseVisualElementPanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.BaseVisualElementPanel.FromPointer); // 0x20 AttachedPanel               ( ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer )
            value.RenderChain                               = GetObject<RenderChain>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderChain.FromPointer); // 0x28 RenderChain                 ( ModelClassType RenderChain RenderChain RenderChain Pointer )
            value.DrawStats                                 = GetBool(new IntPtr(p + 0x030)); // 0x30 DrawStats                   ( ModelPrimitiveType bool bool bool Bool )
            value.BreakBatches                              = GetBool(new IntPtr(p + 0x031)); // 0x31 BreakBatches                ( ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x032)); // 0x32 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
