using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentFrameTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 014 AverageFrameTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 018 CurrentGpuFrameTime                      0001866656B0 ModelPrimitiveType float float float Single
    // 01C AverageGpuFrameTime                      0001866656B0 ModelPrimitiveType float float float Single
    // 020 CurrentCpuFrameTime                      0001866656B0 ModelPrimitiveType float float float Single
    // 024 AverageCpuFrameTime                      0001866656B0 ModelPrimitiveType float float float Single
    public partial class FrameTiming
    {
        public float                                    CurrentFrameTime                        { get; set; }
        public float                                    AverageFrameTime                        { get; set; }
        public float                                    CurrentGpuFrameTime                     { get; set; }
        public float                                    AverageGpuFrameTime                     { get; set; }
        public float                                    CurrentCpuFrameTime                     { get; set; }
        public float                                    AverageCpuFrameTime                     { get; set; }

        public static FrameTiming? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameTiming();

            value.CurrentFrameTime                          = GetSingle(new IntPtr(p + 0x010)); // 0270D090A488 0x10 CurrentFrameTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AverageFrameTime                          = GetSingle(new IntPtr(p + 0x014)); // 0270D090A4A8 0x14 AverageFrameTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentGpuFrameTime                       = GetSingle(new IntPtr(p + 0x018)); // 0270D090A4C8 0x18 CurrentGpuFrameTime         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AverageGpuFrameTime                       = GetSingle(new IntPtr(p + 0x01C)); // 0270D090A4E8 0x1C AverageGpuFrameTime         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CurrentCpuFrameTime                       = GetSingle(new IntPtr(p + 0x020)); // 0270D090A508 0x20 CurrentCpuFrameTime         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AverageCpuFrameTime                       = GetSingle(new IntPtr(p + 0x024)); // 0270D090A528 0x24 AverageCpuFrameTime         ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
