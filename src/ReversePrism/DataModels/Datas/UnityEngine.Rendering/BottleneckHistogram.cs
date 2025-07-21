using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PresentLimited                           ModelPrimitiveType float float float Single
    // 014 CPU                                      ModelPrimitiveType float float float Single
    // 018 GPU                                      ModelPrimitiveType float float float Single
    // 01C Balanced                                 ModelPrimitiveType float float float Single
    public partial class BottleneckHistogram : DataModel
    {
        public float                                    PresentLimited                          { get; set; }
        public float                                    CPU                                     { get; set; }
        public float                                    GPU                                     { get; set; }
        public float                                    Balanced                                { get; set; }

        public static BottleneckHistogram? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BottleneckHistogram() { Pointer= p0 };

            value.PresentLimited                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 PresentLimited              ( ModelPrimitiveType float float float Single )
            value.CPU                                       = GetSingle(new IntPtr(p + 0x014)); // 0x14 CPU                         ( ModelPrimitiveType float float float Single )
            value.GPU                                       = GetSingle(new IntPtr(p + 0x018)); // 0x18 GPU                         ( ModelPrimitiveType float float float Single )
            value.Balanced                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Balanced                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
