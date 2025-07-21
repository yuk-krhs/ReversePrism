using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     ModelEnumType Rect Rect Rect Int32
    // 020 PlaymodeTintColor                        ModelEnumType Color Color Color Int32
    // 030 LeftColor                                ModelEnumType Color Color Color Int32
    // 040 TopColor                                 ModelEnumType Color Color Color Int32
    // 050 RightColor                               ModelEnumType Color Color Color Int32
    // 060 BottomColor                              ModelEnumType Color Color Color Int32
    // 070 LeftWidth                                ModelPrimitiveType float float float Single
    // 074 TopWidth                                 ModelPrimitiveType float float float Single
    // 078 RightWidth                               ModelPrimitiveType float float float Single
    // 07C BottomWidth                              ModelPrimitiveType float float float Single
    // 080 TopLeftRadius                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 088 TopRightRadius                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 090 BottomRightRadius                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 098 BottomLeftRadius                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0A0 Material                                 ModelClassType Material Material Material Pointer
    // 0A8 LeftColorPage                            ModelEnumType ColorPage ColorPage ColorPage Int32
    // 0B0 TopColorPage                             ModelEnumType ColorPage ColorPage ColorPage Int32
    // 0B8 RightColorPage                           ModelEnumType ColorPage ColorPage ColorPage Int32
    // 0C0 BottomColorPage                          ModelEnumType ColorPage ColorPage ColorPage Int32
    public partial class BorderParams : DataModel
    {
        public Rect                                     Rect                                    { get; set; }
        public Color                                    PlaymodeTintColor                       { get; set; }
        public Color                                    LeftColor                               { get; set; }
        public Color                                    TopColor                                { get; set; }
        public Color                                    RightColor                              { get; set; }
        public Color                                    BottomColor                             { get; set; }
        public float                                    LeftWidth                               { get; set; }
        public float                                    TopWidth                                { get; set; }
        public float                                    RightWidth                              { get; set; }
        public float                                    BottomWidth                             { get; set; }
        public Vector2                                  TopLeftRadius                           { get; set; }
        public Vector2                                  TopRightRadius                          { get; set; }
        public Vector2                                  BottomRightRadius                       { get; set; }
        public Vector2                                  BottomLeftRadius                        { get; set; }
        public Material?                                Material                                { get; set; }
        public ColorPage                                LeftColorPage                           { get; set; }
        public ColorPage                                TopColorPage                            { get; set; }
        public ColorPage                                RightColorPage                          { get; set; }
        public ColorPage                                BottomColorPage                         { get; set; }

        public static BorderParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BorderParams() { Pointer= p0 };

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 Rect                        ( ModelEnumType Rect Rect Rect Int32 )
            value.PlaymodeTintColor                         = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 PlaymodeTintColor           ( ModelEnumType Color Color Color Int32 )
            value.LeftColor                                 = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 LeftColor                   ( ModelEnumType Color Color Color Int32 )
            value.TopColor                                  = (Color)GetInt32(new IntPtr(p + 0x040)); // 0x40 TopColor                    ( ModelEnumType Color Color Color Int32 )
            value.RightColor                                = (Color)GetInt32(new IntPtr(p + 0x050)); // 0x50 RightColor                  ( ModelEnumType Color Color Color Int32 )
            value.BottomColor                               = (Color)GetInt32(new IntPtr(p + 0x060)); // 0x60 BottomColor                 ( ModelEnumType Color Color Color Int32 )
            value.LeftWidth                                 = GetSingle(new IntPtr(p + 0x070)); // 0x70 LeftWidth                   ( ModelPrimitiveType float float float Single )
            value.TopWidth                                  = GetSingle(new IntPtr(p + 0x074)); // 0x74 TopWidth                    ( ModelPrimitiveType float float float Single )
            value.RightWidth                                = GetSingle(new IntPtr(p + 0x078)); // 0x78 RightWidth                  ( ModelPrimitiveType float float float Single )
            value.BottomWidth                               = GetSingle(new IntPtr(p + 0x07C)); // 0x7C BottomWidth                 ( ModelPrimitiveType float float float Single )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x080)); // 0x80 TopLeftRadius               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x088)); // 0x88 TopRightRadius              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x090)); // 0x90 BottomRightRadius           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x098)); // 0x98 BottomLeftRadius            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Material.FromPointer); // 0xA0 Material                    ( ModelClassType Material Material Material Pointer )
            value.LeftColorPage                             = (ColorPage)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 LeftColorPage               ( ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.TopColorPage                              = (ColorPage)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 TopColorPage                ( ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.RightColorPage                            = (ColorPage)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 RightColorPage              ( ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.BottomColorPage                           = (ColorPage)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 BottomColorPage             ( ModelEnumType ColorPage ColorPage ColorPage Int32 )

            return value;
        }
    }
}
