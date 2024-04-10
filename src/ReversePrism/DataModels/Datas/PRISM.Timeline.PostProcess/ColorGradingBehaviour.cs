using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 ColorFilter                              0001865AB0A0 ModelEnumType Color Color Color Int32
    // 024 HueShift                                 000186666050 ModelPrimitiveType float float float Single
    // 028 Saturation                               000186666050 ModelPrimitiveType float float float Single
    // 02C Brightness                               000186666050 ModelPrimitiveType float float float Single
    // 030 Contrast                                 000186666050 ModelPrimitiveType float float float Single
    public partial class ColorGradingBehaviour : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public Color                                    ColorFilter                             { get; set; }
        public float                                    HueShift                                { get; set; }
        public float                                    Saturation                              { get; set; }
        public float                                    Brightness                              { get; set; }
        public float                                    Contrast                                { get; set; }

        public static ColorGradingBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGradingBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0246650D8650 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ColorFilter                               = (Color)GetInt32(new IntPtr(p + 0x014)); // 0246650D8670 0x14 ColorFilter                 ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.HueShift                                  = GetSingle(new IntPtr(p + 0x024)); // 0246650D8690 0x24 HueShift                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Saturation                                = GetSingle(new IntPtr(p + 0x028)); // 0246650D86B0 0x28 Saturation                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Brightness                                = GetSingle(new IntPtr(p + 0x02C)); // 0246650D86D0 0x2C Brightness                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Contrast                                  = GetSingle(new IntPtr(p + 0x030)); // 0246650D86F0 0x30 Contrast                    ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
