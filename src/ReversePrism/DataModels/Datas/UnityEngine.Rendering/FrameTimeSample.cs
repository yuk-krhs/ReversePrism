using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FramesPerSecond                          ModelPrimitiveType float float float Single
    // 014 FullFrameTime                            ModelPrimitiveType float float float Single
    // 018 MainThreadCPUFrameTime                   ModelPrimitiveType float float float Single
    // 01C MainThreadCPUPresentWaitTime             ModelPrimitiveType float float float Single
    // 020 RenderThreadCPUFrameTime                 ModelPrimitiveType float float float Single
    // 024 GPUFrameTime                             ModelPrimitiveType float float float Single
    public partial class FrameTimeSample : DataModel
    {
        public float                                    FramesPerSecond                         { get; set; }
        public float                                    FullFrameTime                           { get; set; }
        public float                                    MainThreadCPUFrameTime                  { get; set; }
        public float                                    MainThreadCPUPresentWaitTime            { get; set; }
        public float                                    RenderThreadCPUFrameTime                { get; set; }
        public float                                    GPUFrameTime                            { get; set; }

        public static FrameTimeSample? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameTimeSample() { Pointer= p0 };

            value.FramesPerSecond                           = GetSingle(new IntPtr(p + 0x010)); // 0x10 FramesPerSecond             ( ModelPrimitiveType float float float Single )
            value.FullFrameTime                             = GetSingle(new IntPtr(p + 0x014)); // 0x14 FullFrameTime               ( ModelPrimitiveType float float float Single )
            value.MainThreadCPUFrameTime                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 MainThreadCPUFrameTime      ( ModelPrimitiveType float float float Single )
            value.MainThreadCPUPresentWaitTime              = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MainThreadCPUPresentWaitTime ( ModelPrimitiveType float float float Single )
            value.RenderThreadCPUFrameTime                  = GetSingle(new IntPtr(p + 0x020)); // 0x20 RenderThreadCPUFrameTime    ( ModelPrimitiveType float float float Single )
            value.GPUFrameTime                              = GetSingle(new IntPtr(p + 0x024)); // 0x24 GPUFrameTime                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
