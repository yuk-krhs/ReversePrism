using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      000186666050 ModelPrimitiveType float float float Single
    // 014 Max                                      000186666050 ModelPrimitiveType float float float Single
    // 018 Zero                                     000186666050 ModelPrimitiveType float float float Single
    public partial class NormalizeProcessor
    {
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }
        public float                                    Zero                                    { get; set; }

        public static NormalizeProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NormalizeProcessor();

            value.Min                                       = GetSingle(new IntPtr(p + 0x010)); // 0270D783BA38 0x10 Min                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x014)); // 0270D783BA58 0x14 Max                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Zero                                      = GetSingle(new IntPtr(p + 0x018)); // 0270D783BA78 0x18 Zero                        ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
