using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 020 PlaymodeTintColor                        0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 LeftColor                                0001865AB0A0 ModelEnumType Color Color Color Int32
    // 040 TopColor                                 0001865AB0A0 ModelEnumType Color Color Color Int32
    // 050 RightColor                               0001865AB0A0 ModelEnumType Color Color Color Int32
    // 060 BottomColor                              0001865AB0A0 ModelEnumType Color Color Color Int32
    // 070 LeftWidth                                000186666050 ModelPrimitiveType float float float Single
    // 074 TopWidth                                 000186666050 ModelPrimitiveType float float float Single
    // 078 RightWidth                               000186666050 ModelPrimitiveType float float float Single
    // 07C BottomWidth                              000186666050 ModelPrimitiveType float float float Single
    // 080 TopLeftRadius                            0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 088 TopRightRadius                           0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 090 BottomRightRadius                        0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 098 BottomLeftRadius                         0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0A0 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 0A8 LeftColorPage                            0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32
    // 0B0 TopColorPage                             0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32
    // 0B8 RightColorPage                           0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32
    // 0C0 BottomColorPage                          0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32
    public partial class BorderParams
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
            var value   = new BorderParams();

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0270067E6BE8 0x10 Rect                        ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.PlaymodeTintColor                         = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270067E6C08 0x20 PlaymodeTintColor           ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.LeftColor                                 = (Color)GetInt32(new IntPtr(p + 0x030)); // 0270067E6C28 0x30 LeftColor                   ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TopColor                                  = (Color)GetInt32(new IntPtr(p + 0x040)); // 0270067E6C48 0x40 TopColor                    ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RightColor                                = (Color)GetInt32(new IntPtr(p + 0x050)); // 0270067E6C68 0x50 RightColor                  ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BottomColor                               = (Color)GetInt32(new IntPtr(p + 0x060)); // 0270067E6C88 0x60 BottomColor                 ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.LeftWidth                                 = GetSingle(new IntPtr(p + 0x070)); // 0270067E6CA8 0x70 LeftWidth                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.TopWidth                                  = GetSingle(new IntPtr(p + 0x074)); // 0270067E6CC8 0x74 TopWidth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.RightWidth                                = GetSingle(new IntPtr(p + 0x078)); // 0270067E6CE8 0x78 RightWidth                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.BottomWidth                               = GetSingle(new IntPtr(p + 0x07C)); // 0270067E6D08 0x7C BottomWidth                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x080)); // 0270067E6D28 0x80 TopLeftRadius               ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x088)); // 0270067E6D48 0x88 TopRightRadius              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x090)); // 0270067E6D68 0x90 BottomRightRadius           ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x098)); // 0270067E6D88 0x98 BottomLeftRadius            ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Material.FromPointer); // 0270067E6DA8 0xA0 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.LeftColorPage                             = (ColorPage)GetInt32(new IntPtr(p + 0x0A8)); // 0270067E6DC8 0xA8 LeftColorPage               ( 0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.TopColorPage                              = (ColorPage)GetInt32(new IntPtr(p + 0x0B0)); // 0270067E6DE8 0xB0 TopColorPage                ( 0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.RightColorPage                            = (ColorPage)GetInt32(new IntPtr(p + 0x0B8)); // 0270067E6E08 0xB8 RightColorPage              ( 0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32 )
            value.BottomColorPage                           = (ColorPage)GetInt32(new IntPtr(p + 0x0C0)); // 0270067E6E28 0xC0 BottomColorPage             ( 0001865D0830 ModelEnumType ColorPage ColorPage ColorPage Int32 )

            return value;
        }
    }
}
