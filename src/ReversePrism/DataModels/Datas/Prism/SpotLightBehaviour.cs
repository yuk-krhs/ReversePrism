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
    public partial class SpotLightBehaviour : DataModel
    {
        public float                                    Intensity                               { get; set; }
        public Color                                    Color                                   { get; set; }

        public static SpotLightBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpotLightBehaviour() { Pointer= p0 };

            value.Intensity                                 = GetSingle(new IntPtr(p + 0x010)); // 024664E73F70 0x10 Intensity                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 024664E73F90 0x14 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
