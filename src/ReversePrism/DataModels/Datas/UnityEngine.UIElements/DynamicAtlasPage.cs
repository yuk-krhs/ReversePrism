using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextureId                                ModelEnumType TextureId TextureId TextureId Int32
    // 018 Atlas                                    ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 020 Format                                   ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32
    // 024 FilterMode                               ModelEnumType FilterMode FilterMode FilterMode Int32
    // 028 MinSize                                  ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 030 MaxSize                                  ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 038 M_1Padding                               ModelPrimitiveType int int int Int32
    // 03C M_2Padding                               ModelPrimitiveType int int int Int32
    // 040 M_Allocator                              ModelClassType Allocator2D Allocator2D Allocator2D Pointer
    // 048 M_Blitter                                ModelClassType TextureBlitter TextureBlitter TextureBlitter Pointer
    // 050 M_CurrentSize                            ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 000 s_TextureCounter                         int IL2CPP_TYPE_I4
    // 058 Disposed                                 ModelPrimitiveType bool bool bool Bool
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

            value.TextureId                                 = (TextureId)GetInt32(new IntPtr(p + 0x010)); // 0x10 TextureId                   ( ModelEnumType TextureId TextureId TextureId Int32 )
            value.Atlas                                     = GetObject<RenderTexture>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x18 Atlas                       ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.Format                                    = (RenderTextureFormat)GetInt32(new IntPtr(p + 0x020)); // 0x20 Format                      ( ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32 )
            value.FilterMode                                = (FilterMode)GetInt32(new IntPtr(p + 0x024)); // 0x24 FilterMode                  ( ModelEnumType FilterMode FilterMode FilterMode Int32 )
            value.MinSize                                   = (Vector2Int)GetInt32(new IntPtr(p + 0x028)); // 0x28 MinSize                     ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.MaxSize                                   = (Vector2Int)GetInt32(new IntPtr(p + 0x030)); // 0x30 MaxSize                     ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.M_1Padding                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_1Padding                  ( ModelPrimitiveType int int int Int32 )
            value.M_2Padding                                = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_2Padding                  ( ModelPrimitiveType int int int Int32 )
            value.M_Allocator                               = GetObject<Allocator2D>(new IntPtr(p + 0x040), ReversePrism.DataModels.Allocator2D.FromPointer); // 0x40 M_Allocator                 ( ModelClassType Allocator2D Allocator2D Allocator2D Pointer )
            value.M_Blitter                                 = GetObject<TextureBlitter>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextureBlitter.FromPointer); // 0x48 M_Blitter                   ( ModelClassType TextureBlitter TextureBlitter TextureBlitter Pointer )
            value.M_CurrentSize                             = (Vector2Int)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_CurrentSize               ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x058)); // 0x58 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
