using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentFrameTime                         ModelPrimitiveType float float float Single
    // 014 AverageFrameTime                         ModelPrimitiveType float float float Single
    // 018 CurrentGpuFrameTime                      ModelPrimitiveType float float float Single
    // 01C AverageGpuFrameTime                      ModelPrimitiveType float float float Single
    // 020 CurrentCpuFrameTime                      ModelPrimitiveType float float float Single
    // 024 AverageCpuFrameTime                      ModelPrimitiveType float float float Single
    public partial class FrameTiming : DataModel
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
            var value   = new FrameTiming() { Pointer= p0 };

            value.CurrentFrameTime                          = GetSingle(new IntPtr(p + 0x010)); // 0x10 CurrentFrameTime            ( ModelPrimitiveType float float float Single )
            value.AverageFrameTime                          = GetSingle(new IntPtr(p + 0x014)); // 0x14 AverageFrameTime            ( ModelPrimitiveType float float float Single )
            value.CurrentGpuFrameTime                       = GetSingle(new IntPtr(p + 0x018)); // 0x18 CurrentGpuFrameTime         ( ModelPrimitiveType float float float Single )
            value.AverageGpuFrameTime                       = GetSingle(new IntPtr(p + 0x01C)); // 0x1C AverageGpuFrameTime         ( ModelPrimitiveType float float float Single )
            value.CurrentCpuFrameTime                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 CurrentCpuFrameTime         ( ModelPrimitiveType float float float Single )
            value.AverageCpuFrameTime                       = GetSingle(new IntPtr(p + 0x024)); // 0x24 AverageCpuFrameTime         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
