using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Intensity                                000186666050 ModelPrimitiveType float float float Single
    // 014 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class LightingBehaviour : DataModel
    {
        public float                                    Intensity                               { get; set; }
        public Color                                    Color                                   { get; set; }

        public static LightingBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightingBehaviour() { Pointer= p0 };

            value.Intensity                                 = GetSingle(new IntPtr(p + 0x010)); // 024664E733F0 0x10 Intensity                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 024664E73410 0x14 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
