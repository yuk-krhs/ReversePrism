using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FramesPerSecond                          000186665900 ModelPrimitiveType float float float Single
    // 014 FullFrameTime                            000186665900 ModelPrimitiveType float float float Single
    // 018 MainThreadCPUFrameTime                   000186665900 ModelPrimitiveType float float float Single
    // 01C MainThreadCPUPresentWaitTime             000186665900 ModelPrimitiveType float float float Single
    // 020 RenderThreadCPUFrameTime                 000186665900 ModelPrimitiveType float float float Single
    // 024 GPUFrameTime                             000186665900 ModelPrimitiveType float float float Single
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

            value.FramesPerSecond                           = GetSingle(new IntPtr(p + 0x010)); // 0246691C4788 0x10 FramesPerSecond             ( 000186665900 ModelPrimitiveType float float float Single )
            value.FullFrameTime                             = GetSingle(new IntPtr(p + 0x014)); // 0246691C47A8 0x14 FullFrameTime               ( 000186665900 ModelPrimitiveType float float float Single )
            value.MainThreadCPUFrameTime                    = GetSingle(new IntPtr(p + 0x018)); // 0246691C47C8 0x18 MainThreadCPUFrameTime      ( 000186665900 ModelPrimitiveType float float float Single )
            value.MainThreadCPUPresentWaitTime              = GetSingle(new IntPtr(p + 0x01C)); // 0246691C47E8 0x1C MainThreadCPUPresentWaitTime ( 000186665900 ModelPrimitiveType float float float Single )
            value.RenderThreadCPUFrameTime                  = GetSingle(new IntPtr(p + 0x020)); // 0246691C4808 0x20 RenderThreadCPUFrameTime    ( 000186665900 ModelPrimitiveType float float float Single )
            value.GPUFrameTime                              = GetSingle(new IntPtr(p + 0x024)); // 0246691C4828 0x24 GPUFrameTime                ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
