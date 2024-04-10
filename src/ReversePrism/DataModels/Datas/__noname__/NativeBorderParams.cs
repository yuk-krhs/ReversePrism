using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 020 LeftColor                                0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 TopColor                                 0001865AB0A0 ModelEnumType Color Color Color Int32
    // 040 RightColor                               0001865AB0A0 ModelEnumType Color Color Color Int32
    // 050 BottomColor                              0001865AB0A0 ModelEnumType Color Color Color Int32
    // 060 LeftWidth                                000186666050 ModelPrimitiveType float float float Single
    // 064 TopWidth                                 000186666050 ModelPrimitiveType float float float Single
    // 068 RightWidth                               000186666050 ModelPrimitiveType float float float Single
    // 06C BottomWidth                              000186666050 ModelPrimitiveType float float float Single
    // 070 TopLeftRadius                            0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 TopRightRadius                           0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 BottomRightRadius                        0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 088 BottomLeftRadius                         0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 090 LeftColorPage                            000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32
    // 098 TopColorPage                             000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32
    // 0A0 RightColorPage                           000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32
    // 0A8 BottomColorPage                          000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32
    public partial class NativeBorderParams : DataModel
    {
        public Rect                                     Rect                                    { get; set; }
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
        public NativeColorPage                          LeftColorPage                           { get; set; }
        public NativeColorPage                          TopColorPage                            { get; set; }
        public NativeColorPage                          RightColorPage                          { get; set; }
        public NativeColorPage                          BottomColorPage                         { get; set; }

        public static NativeBorderParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeBorderParams() { Pointer= p0 };

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0245A67A0D38 0x10 Rect                        ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.LeftColor                                 = (Color)GetInt32(new IntPtr(p + 0x020)); // 0245A67A0D58 0x20 LeftColor                   ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TopColor                                  = (Color)GetInt32(new IntPtr(p + 0x030)); // 0245A67A0D78 0x30 TopColor                    ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RightColor                                = (Color)GetInt32(new IntPtr(p + 0x040)); // 0245A67A0D98 0x40 RightColor                  ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BottomColor                               = (Color)GetInt32(new IntPtr(p + 0x050)); // 0245A67A0DB8 0x50 BottomColor                 ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.LeftWidth                                 = GetSingle(new IntPtr(p + 0x060)); // 0245A67A0DD8 0x60 LeftWidth                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.TopWidth                                  = GetSingle(new IntPtr(p + 0x064)); // 0245A67A0DF8 0x64 TopWidth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.RightWidth                                = GetSingle(new IntPtr(p + 0x068)); // 0245A67A0E18 0x68 RightWidth                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.BottomWidth                               = GetSingle(new IntPtr(p + 0x06C)); // 0245A67A0E38 0x6C BottomWidth                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0245A67A0E58 0x70 TopLeftRadius               ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0245A67A0E78 0x78 TopRightRadius              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x080)); // 0245A67A0E98 0x80 BottomRightRadius           ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x088)); // 0245A67A0EB8 0x88 BottomLeftRadius            ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftColorPage                             = (NativeColorPage)GetInt32(new IntPtr(p + 0x090)); // 0245A67A0ED8 0x90 LeftColorPage               ( 000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32 )
            value.TopColorPage                              = (NativeColorPage)GetInt32(new IntPtr(p + 0x098)); // 0245A67A0EF8 0x98 TopColorPage                ( 000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32 )
            value.RightColorPage                            = (NativeColorPage)GetInt32(new IntPtr(p + 0x0A0)); // 0245A67A0F18 0xA0 RightColorPage              ( 000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32 )
            value.BottomColorPage                           = (NativeColorPage)GetInt32(new IntPtr(p + 0x0A8)); // 0245A67A0F38 0xA8 BottomColorPage             ( 000186701000 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32 )

            return value;
        }
    }
}
