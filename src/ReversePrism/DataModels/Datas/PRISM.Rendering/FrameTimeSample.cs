using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FramesPerSecond                          0001866656B0 ModelPrimitiveType float float float Single
    // 014 FullFrameTime                            0001866656B0 ModelPrimitiveType float float float Single
    // 018 GPUFrameTime                             0001866656B0 ModelPrimitiveType float float float Single
    // 01C MainThreadCPUFrameTime                   0001866656B0 ModelPrimitiveType float float float Single
    // 020 MainThreadCPUPresentWaitTime             0001866656B0 ModelPrimitiveType float float float Single
    // 024 RenderThreadCPUFrameTime                 0001866656B0 ModelPrimitiveType float float float Single
    public partial class FrameTimeSample : DataModel
    {
        public float                                    FramesPerSecond                         { get; set; }
        public float                                    FullFrameTime                           { get; set; }
        public float                                    GPUFrameTime                            { get; set; }
        public float                                    MainThreadCPUFrameTime                  { get; set; }
        public float                                    MainThreadCPUPresentWaitTime            { get; set; }
        public float                                    RenderThreadCPUFrameTime                { get; set; }

        public static FrameTimeSample? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameTimeSample() { Pointer= p0 };

            value.FramesPerSecond                           = GetSingle(new IntPtr(p + 0x010)); // 02466BB14730 0x10 FramesPerSecond             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FullFrameTime                             = GetSingle(new IntPtr(p + 0x014)); // 02466BB14750 0x14 FullFrameTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.GPUFrameTime                              = GetSingle(new IntPtr(p + 0x018)); // 02466BB14770 0x18 GPUFrameTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MainThreadCPUFrameTime                    = GetSingle(new IntPtr(p + 0x01C)); // 02466BB14790 0x1C MainThreadCPUFrameTime      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MainThreadCPUPresentWaitTime              = GetSingle(new IntPtr(p + 0x020)); // 02466BB147B0 0x20 MainThreadCPUPresentWaitTime ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RenderThreadCPUFrameTime                  = GetSingle(new IntPtr(p + 0x024)); // 02466BB147D0 0x24 RenderThreadCPUFrameTime    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
