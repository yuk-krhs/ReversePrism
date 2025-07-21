using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Src                                      ModelClassType Texture Texture Texture Pointer
    // 018 SrcRect                                  ModelEnumType RectInt RectInt RectInt Int32
    // 028 DstPos                                   ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 030 Border                                   ModelPrimitiveType int int int Int32
    // 034 Tint                                     ModelEnumType Color Color Color Int32
    public partial class BlitInfo : DataModel
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
            var value   = new BlitInfo() { Pointer= p0 };

            value.Src                                       = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 0x10 Src                         ( ModelClassType Texture Texture Texture Pointer )
            value.SrcRect                                   = (RectInt)GetInt32(new IntPtr(p + 0x018)); // 0x18 SrcRect                     ( ModelEnumType RectInt RectInt RectInt Int32 )
            value.DstPos                                    = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 0x28 DstPos                      ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Border                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Border                      ( ModelPrimitiveType int int int Int32 )
            value.Tint                                      = (Color)GetInt32(new IntPtr(p + 0x034)); // 0x34 Tint                        ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
