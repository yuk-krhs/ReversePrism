using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PathColor                                ModelEnumType Color Color Color Int32
    // 020 InactivePathColor                        ModelEnumType Color Color Color Int32
    // 030 Width                                    ModelPrimitiveType float float float Single
    public partial class Appearance : DataModel
    {
        public Color                                    PathColor                               { get; set; }
        public Color                                    InactivePathColor                       { get; set; }
        public float                                    Width                                   { get; set; }

        public static Appearance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Appearance() { Pointer= p0 };

            value.PathColor                                 = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 PathColor                   ( ModelEnumType Color Color Color Int32 )
            value.InactivePathColor                         = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 InactivePathColor           ( ModelEnumType Color Color Color Int32 )
            value.Width                                     = GetSingle(new IntPtr(p + 0x030)); // 0x30 Width                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
