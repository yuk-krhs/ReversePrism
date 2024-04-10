using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PresentLimited                           000186665900 ModelPrimitiveType float float float Single
    // 014 CPU                                      000186665900 ModelPrimitiveType float float float Single
    // 018 GPU                                      000186665900 ModelPrimitiveType float float float Single
    // 01C Balanced                                 000186665900 ModelPrimitiveType float float float Single
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

            value.PresentLimited                            = GetSingle(new IntPtr(p + 0x010)); // 0246691C4F68 0x10 PresentLimited              ( 000186665900 ModelPrimitiveType float float float Single )
            value.CPU                                       = GetSingle(new IntPtr(p + 0x014)); // 0246691C4F88 0x14 CPU                         ( 000186665900 ModelPrimitiveType float float float Single )
            value.GPU                                       = GetSingle(new IntPtr(p + 0x018)); // 0246691C4FA8 0x18 GPU                         ( 000186665900 ModelPrimitiveType float float float Single )
            value.Balanced                                  = GetSingle(new IntPtr(p + 0x01C)); // 0246691C4FC8 0x1C Balanced                    ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
