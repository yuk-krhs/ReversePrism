using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Gradient                                 ModelClassType Gradient Gradient Gradient Pointer
    // 030 Axis                                     ModelEnumType Axis Axis Axis Int32
    // 034 UseOriginalAlpha                         ModelPrimitiveType bool bool bool Bool
    // 038 VertexList                               ModelEnumListType List`1<UIVertex> List`1<UIVertex> List<UIVertex> Pointer
    // 040 MinMax                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 AxisIndex                                ModelPrimitiveType int int int Int32
    public partial class UIGradient : DataModel
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
            var value   = new UIGradient() { Pointer= p0 };

            value.Gradient                                  = GetObject<Gradient>(new IntPtr(p + 0x028), ReversePrism.DataModels.Gradient.FromPointer); // 0x28 Gradient                    ( ModelClassType Gradient Gradient Gradient Pointer )
            value.Axis                                      = (Axis)GetInt32(new IntPtr(p + 0x030)); // 0x30 Axis                        ( ModelEnumType Axis Axis Axis Int32 )
            value.UseOriginalAlpha                          = GetBool(new IntPtr(p + 0x034)); // 0x34 UseOriginalAlpha            ( ModelPrimitiveType bool bool bool Bool )
            value.VertexList                                = GetEnumList<UIVertex>(new IntPtr(p + 0x038)); // 0x38 VertexList                  ( ModelEnumListType List`1<UIVertex> List`1<UIVertex> List<UIVertex> Pointer )
            value.MinMax                                    = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 MinMax                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AxisIndex                                 = GetInt32(new IntPtr(p + 0x048)); // 0x48 AxisIndex                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
