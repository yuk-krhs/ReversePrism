using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Intensity                                ModelPrimitiveType float float float Single
    // 014 Color                                    ModelEnumType Color Color Color Int32
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

            value.Intensity                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 Intensity                   ( ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 0x14 Color                       ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
