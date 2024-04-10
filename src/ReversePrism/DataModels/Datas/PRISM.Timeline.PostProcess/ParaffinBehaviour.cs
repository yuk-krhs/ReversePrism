using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 024 Rotate                                   000186666050 ModelPrimitiveType float float float Single
    // 028 Edge0                                    000186666050 ModelPrimitiveType float float float Single
    // 02C Edge1                                    000186666050 ModelPrimitiveType float float float Single
    public partial class ParaffinBehaviour : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public Color                                    Color                                   { get; set; }
        public float                                    Rotate                                  { get; set; }
        public float                                    Edge0                                   { get; set; }
        public float                                    Edge1                                   { get; set; }

        public static ParaffinBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParaffinBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0246650D9150 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 0246650D9170 0x14 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.Rotate                                    = GetSingle(new IntPtr(p + 0x024)); // 0246650D9190 0x24 Rotate                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Edge0                                     = GetSingle(new IntPtr(p + 0x028)); // 0246650D91B0 0x28 Edge0                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Edge1                                     = GetSingle(new IntPtr(p + 0x02C)); // 0246650D91D0 0x2C Edge1                       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
