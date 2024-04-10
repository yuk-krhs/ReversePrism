using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextureId                                000186687C50 ModelEnumType TextureId TextureId TextureId Int32
    // 018 Atlas                                    000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 020 Format                                   00018665C470 ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32
    // 024 FilterMode                               000186580C60 ModelEnumType FilterMode FilterMode FilterMode Int32
    // 028 MinSize                                  0001866AA8A0 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 030 MaxSize                                  0001866AA8A0 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 038 M_1Padding                               0001865F4260 ModelPrimitiveType int int int Int32
    // 03C M_2Padding                               0001865F4260 ModelPrimitiveType int int int Int32
    // 040 M_Allocator                              0001866A44D0 ModelClassType Allocator2D Allocator2D Allocator2D Pointer
    // 048 M_Blitter                                00018664F8E0 ModelClassType TextureBlitter TextureBlitter TextureBlitter Pointer
    // 050 M_CurrentSize                            0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 000 s_TextureCounter                         int IL2CPP_TYPE_I4
    // 058 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DynamicAtlasPage : DataModel
    {
        public TextureId                                TextureId                               { get; set; }
        public RenderTexture?                           Atlas                                   { get; set; }
        public RenderTextureFormat                      Format                                  { get; set; }
        public FilterMode                               FilterMode                              { get; set; }
        public Vector2Int                               MinSize                                 { get; set; }
        public Vector2Int                               MaxSize                                 { get; set; }
        public int                                      M_1Padding                              { get; set; }
        public int                                      M_2Padding                              { get; set; }
        public Allocator2D?                             M_Allocator                             { get; set; }
        public TextureBlitter?                          M_Blitter                               { get; set; }
        public Vector2Int                               M_CurrentSize                           { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static DynamicAtlasPage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicAtlasPage() { Pointer= p0 };

            value.TextureId                                 = (TextureId)GetInt32(new IntPtr(p + 0x010)); // 0245A67A4EF0 0x10 TextureId                   ( 000186687C50 ModelEnumType TextureId TextureId TextureId Int32 )
            value.Atlas                                     = GetObject<RenderTexture>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A67A4F10 0x18 Atlas                       ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.Format                                    = (RenderTextureFormat)GetInt32(new IntPtr(p + 0x020)); // 0245A67A4F30 0x20 Format                      ( 00018665C470 ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32 )
            value.FilterMode                                = (FilterMode)GetInt32(new IntPtr(p + 0x024)); // 0245A67A4F50 0x24 FilterMode                  ( 000186580C60 ModelEnumType FilterMode FilterMode FilterMode Int32 )
            value.MinSize                                   = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 0245A67A4F70 0x28 MinSize                     ( 0001866AA8A0 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.MaxSize                                   = (Vector2Int)GetInt32(new IntPtr(p + 0x030)); // 0245A67A4F90 0x30 MaxSize                     ( 0001866AA8A0 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.M_1Padding                                = GetInt32(new IntPtr(p + 0x038)); // 0245A67A4FB0 0x38 M_1Padding                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_2Padding                                = GetInt32(new IntPtr(p + 0x03C)); // 0245A67A4FD0 0x3C M_2Padding                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_Allocator                               = GetObject<Allocator2D>(new IntPtr(p + 0x040), ReversePrism.DataModels.Allocator2D.FromPointer); // 0245A67A4FF0 0x40 M_Allocator                 ( 0001866A44D0 ModelClassType Allocator2D Allocator2D Allocator2D Pointer )
            value.M_Blitter                                 = GetObject<TextureBlitter>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextureBlitter.FromPointer); // 0245A67A5010 0x48 M_Blitter                   ( 00018664F8E0 ModelClassType TextureBlitter TextureBlitter TextureBlitter Pointer )
            value.M_CurrentSize                             = (Vector2Int)GetInt32(new IntPtr(p + 0x050)); // 0245A67A5030 0x50 M_CurrentSize               ( 0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x058)); // 0245A67A5070 0x58 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
