using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OutlineSize                              ModelPrimitiveType float float float Single
    // 014 OutlineColor                             ModelEnumType Color Color Color Int32
    public partial class ShapeUguiOutlineBehaviour : DataModel
    {
        public float                                    OutlineSize                             { get; set; }
        public Color                                    OutlineColor                            { get; set; }

        public static ShapeUguiOutlineBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShapeUguiOutlineBehaviour() { Pointer= p0 };

            value.OutlineSize                               = GetSingle(new IntPtr(p + 0x010)); // 0x10 OutlineSize                 ( ModelPrimitiveType float float float Single )
            value.OutlineColor                              = (Color)GetInt32(new IntPtr(p + 0x014)); // 0x14 OutlineColor                ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
