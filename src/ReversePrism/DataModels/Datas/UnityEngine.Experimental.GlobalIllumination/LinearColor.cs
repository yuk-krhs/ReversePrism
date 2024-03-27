using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_red                                    0001866656B0 ModelPrimitiveType float float float Single
    // 014 M_green                                  0001866656B0 ModelPrimitiveType float float float Single
    // 018 M_blue                                   0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_intensity                              0001866656B0 ModelPrimitiveType float float float Single
    public partial class LinearColor
    {
        public float                                    M_red                                   { get; set; }
        public float                                    M_green                                 { get; set; }
        public float                                    M_blue                                  { get; set; }
        public float                                    M_intensity                             { get; set; }

        public static LinearColor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LinearColor();

            value.M_red                                     = GetSingle(new IntPtr(p + 0x010)); // 0270023893F8 0x10 M_red                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_green                                   = GetSingle(new IntPtr(p + 0x014)); // 027002389418 0x14 M_green                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_blue                                    = GetSingle(new IntPtr(p + 0x018)); // 027002389438 0x18 M_blue                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_intensity                               = GetSingle(new IntPtr(p + 0x01C)); // 027002389458 0x1C M_intensity                 ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
