using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Src                                      00018664D720 ModelClassType Texture Texture Texture Pointer
    // 018 SrcRect                                  000186651230 ModelEnumType RectInt RectInt RectInt Int32
    // 028 DstPos                                   0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 030 Border                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 Tint                                     0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class BlitInfo
    {
        public Texture?                                 Src                                     { get; set; }
        public RectInt                                  SrcRect                                 { get; set; }
        public Vector2Int                               DstPos                                  { get; set; }
        public int                                      Border                                  { get; set; }
        public Color                                    Tint                                    { get; set; }

        public static BlitInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlitInfo();

            value.Src                                       = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 0270068792A0 0x10 Src                         ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.SrcRect                                   = (RectInt)GetInt32(new IntPtr(p + 0x018)); // 0270068792C0 0x18 SrcRect                     ( 000186651230 ModelEnumType RectInt RectInt RectInt Int32 )
            value.DstPos                                    = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 0270068792E0 0x28 DstPos                      ( 0001866AA610 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Border                                    = GetInt32(new IntPtr(p + 0x030)); // 027006879300 0x30 Border                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Tint                                      = (Color)GetInt32(new IntPtr(p + 0x034)); // 027006879320 0x34 Tint                        ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
