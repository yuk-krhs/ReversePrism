using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MyRenderer                               ModelClassType Renderer Renderer Renderer Pointer
    // 028 MainTexSt                                ModelEnumType Vector4 Vector4 Vector4 Int32
    // 038 ScrollSpeed                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 IsClamp                                  ModelPrimitiveType bool bool bool Bool
    // 044 ClampMin                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 04C ClampMax                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 054 Step                                     ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class UVScroller : DataModel
    {
        public Renderer?                                MyRenderer                              { get; set; }
        public Vector4                                  MainTexSt                               { get; set; }
        public Vector2                                  ScrollSpeed                             { get; set; }
        public bool                                     IsClamp                                 { get; set; }
        public Vector2                                  ClampMin                                { get; set; }
        public Vector2                                  ClampMax                                { get; set; }
        public Vector2                                  Step                                    { get; set; }

        public static UVScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UVScroller() { Pointer= p0 };

            value.MyRenderer                                = GetObject<Renderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.Renderer.FromPointer); // 0x20 MyRenderer                  ( ModelClassType Renderer Renderer Renderer Pointer )
            value.MainTexSt                                 = (Vector4)GetInt32(new IntPtr(p + 0x028)); // 0x28 MainTexSt                   ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ScrollSpeed                               = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0x38 ScrollSpeed                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.IsClamp                                   = GetBool(new IntPtr(p + 0x040)); // 0x40 IsClamp                     ( ModelPrimitiveType bool bool bool Bool )
            value.ClampMin                                  = (Vector2)GetInt32(new IntPtr(p + 0x044)); // 0x44 ClampMin                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ClampMax                                  = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0x4C ClampMax                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Step                                      = (Vector2)GetInt32(new IntPtr(p + 0x054)); // 0x54 Step                        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
