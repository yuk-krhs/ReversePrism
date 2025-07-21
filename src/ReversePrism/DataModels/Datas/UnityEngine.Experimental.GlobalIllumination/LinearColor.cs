using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_red                                    ModelPrimitiveType float float float Single
    // 014 M_green                                  ModelPrimitiveType float float float Single
    // 018 M_blue                                   ModelPrimitiveType float float float Single
    // 01C M_intensity                              ModelPrimitiveType float float float Single
    public partial class LinearColor : DataModel
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
            var value   = new LinearColor() { Pointer= p0 };

            value.M_red                                     = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_red                       ( ModelPrimitiveType float float float Single )
            value.M_green                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_green                     ( ModelPrimitiveType float float float Single )
            value.M_blue                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_blue                      ( ModelPrimitiveType float float float Single )
            value.M_intensity                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_intensity                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
