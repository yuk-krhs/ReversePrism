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
    public partial class FrameTimeSample
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
            var value   = new FrameTimeSample();

            value.FramesPerSecond                           = GetSingle(new IntPtr(p + 0x010)); // 0270DBA7D230 0x10 FramesPerSecond             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.FullFrameTime                             = GetSingle(new IntPtr(p + 0x014)); // 0270DBA7D250 0x14 FullFrameTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.GPUFrameTime                              = GetSingle(new IntPtr(p + 0x018)); // 0270DBA7D270 0x18 GPUFrameTime                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MainThreadCPUFrameTime                    = GetSingle(new IntPtr(p + 0x01C)); // 0270DBA7D290 0x1C MainThreadCPUFrameTime      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MainThreadCPUPresentWaitTime              = GetSingle(new IntPtr(p + 0x020)); // 0270DBA7D2B0 0x20 MainThreadCPUPresentWaitTime ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RenderThreadCPUFrameTime                  = GetSingle(new IntPtr(p + 0x024)); // 0270DBA7D2D0 0x24 RenderThreadCPUFrameTime    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
