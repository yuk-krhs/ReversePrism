using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    ModelEnumType Color Color Color Int32
    // 020 Time                                     ModelPrimitiveType float float float Single
    public partial class GradientColorKey : DataModel
    {
        public Color                                    Color                                   { get; set; }
        public float                                    Time                                    { get; set; }

        public static GradientColorKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GradientColorKey() { Pointer= p0 };

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 Color                       ( ModelEnumType Color Color Color Int32 )
            value.Time                                      = GetSingle(new IntPtr(p + 0x020)); // 0x20 Time                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
