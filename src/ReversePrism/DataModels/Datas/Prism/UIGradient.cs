using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Gradient                                 0001865DAFD0 ModelClassType Gradient Gradient Gradient Pointer
    // 030 Axis                                     00018665D8C0 ModelEnumType Axis Axis Axis Int32
    // 034 UseOriginalAlpha                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 VertexList                               000185D18C48 ModelEnumListType List`1<UIVertex> List`1<UIVertex> List<UIVertex> Pointer
    // 040 MinMax                                   0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 AxisIndex                                0001865F3220 ModelPrimitiveType int int int Int32
    public partial class UIGradient
    {
        public Gradient?                                Gradient                                { get; set; }
        public Axis                                     Axis                                    { get; set; }
        public bool                                     UseOriginalAlpha                        { get; set; }
        public List<UIVertex>?                          VertexList                              { get; set; }
        public Vector2                                  MinMax                                  { get; set; }
        public int                                      AxisIndex                               { get; set; }

        public static UIGradient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIGradient();

            value.Gradient                                  = GetObject<Gradient>(new IntPtr(p + 0x028), ReversePrism.DataModels.Gradient.FromPointer); // 027001E95950 0x28 Gradient                    ( 0001865DAFD0 ModelClassType Gradient Gradient Gradient Pointer )
            value.Axis                                      = (Axis)GetInt32(new IntPtr(p + 0x030)); // 027001E95970 0x30 Axis                        ( 00018665D8C0 ModelEnumType Axis Axis Axis Int32 )
            value.UseOriginalAlpha                          = GetBool(new IntPtr(p + 0x034)); // 027001E95990 0x34 UseOriginalAlpha            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.VertexList                                = GetEnumList<UIVertex>(new IntPtr(p + 0x038)); // 027001E959B0 0x38 VertexList                  ( 000185D18C48 ModelEnumListType List`1<UIVertex> List`1<UIVertex> List<UIVertex> Pointer )
            value.MinMax                                    = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 027001E959D0 0x40 MinMax                      ( 0001866A8470 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AxisIndex                                 = GetInt32(new IntPtr(p + 0x048)); // 027001E959F0 0x48 AxisIndex                   ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
