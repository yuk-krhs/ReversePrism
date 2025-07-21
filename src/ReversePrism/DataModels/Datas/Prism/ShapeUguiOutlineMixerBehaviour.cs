using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 OutlineSize                              ModelPrimitiveType float float float Single
    // 03C OutlineColor                             ModelEnumType Color Color Color Int32
    public partial class ShapeUguiOutlineMixerBehaviour : DataModel
    {
        public float                                    OutlineSize                             { get; set; }
        public Color                                    OutlineColor                            { get; set; }

        public static ShapeUguiOutlineMixerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShapeUguiOutlineMixerBehaviour() { Pointer= p0 };

            value.OutlineSize                               = GetSingle(new IntPtr(p + 0x038)); // 0x38 OutlineSize                 ( ModelPrimitiveType float float float Single )
            value.OutlineColor                              = (Color)GetInt32(new IntPtr(p + 0x03C)); // 0x3C OutlineColor                ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
