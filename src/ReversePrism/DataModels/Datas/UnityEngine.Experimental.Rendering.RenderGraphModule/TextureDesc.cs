using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SizeMode                                 ModelEnumType TextureSizeMode TextureSizeMode TextureSizeMode Int32
    // 014 Width                                    ModelPrimitiveType int int int Int32
    // 018 Height                                   ModelPrimitiveType int int int Int32
    // 01C Slices                                   ModelPrimitiveType int int int Int32
    // 020 Scale                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 Func                                     ModelClassType ScaleFunc ScaleFunc ScaleFunc Pointer
    // 030 DepthBufferBits                          ModelEnumType DepthBits DepthBits DepthBits Int32
    // 034 ColorFormat                              ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 038 FilterMode                               ModelEnumType FilterMode FilterMode FilterMode Int32
    // 03C WrapMode                                 ModelEnumType TextureWrapMode TextureWrapMode TextureWrapMode Int32
    // 040 Dimension                                ModelEnumType TextureDimension TextureDimension TextureDimension Int32
    // 044 EnableRandomWrite                        ModelPrimitiveType bool bool bool Bool
    // 045 UseMipMap                                ModelPrimitiveType bool bool bool Bool
    // 046 AutoGenerateMips                         ModelPrimitiveType bool bool bool Bool
    // 047 IsShadowMap                              ModelPrimitiveType bool bool bool Bool
    // 048 AnisoLevel                               ModelPrimitiveType int int int Int32
    // 04C MipMapBias                               ModelPrimitiveType float float float Single
    // 050 MsaaSamples                              ModelEnumType MSAASamples MSAASamples MSAASamples Int32
    // 054 BindTextureMS                            ModelPrimitiveType bool bool bool Bool
    // 055 UseDynamicScale                          ModelPrimitiveType bool bool bool Bool
    // 058 Memoryless                               ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32
    // 05C VrUsage                                  ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32
    // 060 Name                                     ModelPrimitiveType string string string String
    // 068 FastMemoryDesc                           ModelEnumType FastMemoryDesc FastMemoryDesc FastMemoryDesc Int32
    // 074 FallBackToBlackTexture                   ModelPrimitiveType bool bool bool Bool
    // 075 DisableFallBackToImportedTexture         ModelPrimitiveType bool bool bool Bool
    // 076 ClearBuffer                              ModelPrimitiveType bool bool bool Bool
    // 078 ClearColor                               ModelEnumType Color Color Color Int32
    public partial class TextureDesc : DataModel
    {
        public TextureSizeMode                          SizeMode                                { get; set; }
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }
        public int                                      Slices                                  { get; set; }
        public Vector2                                  Scale                                   { get; set; }
        public ScaleFunc?                               Func                                    { get; set; }
        public DepthBits                                DepthBufferBits                         { get; set; }
        public GraphicsFormat                           ColorFormat                             { get; set; }
        public FilterMode                               FilterMode                              { get; set; }
        public TextureWrapMode                          WrapMode                                { get; set; }
        public TextureDimension                         Dimension                               { get; set; }
        public bool                                     EnableRandomWrite                       { get; set; }
        public bool                                     UseMipMap                               { get; set; }
        public bool                                     AutoGenerateMips                        { get; set; }
        public bool                                     IsShadowMap                             { get; set; }
        public int                                      AnisoLevel                              { get; set; }
        public float                                    MipMapBias                              { get; set; }
        public MSAASamples                              MsaaSamples                             { get; set; }
        public bool                                     BindTextureMS                           { get; set; }
        public bool                                     UseDynamicScale                         { get; set; }
        public RenderTextureMemoryless                  Memoryless                              { get; set; }
        public VRTextureUsage                           VrUsage                                 { get; set; }
        public string                                   Name                                    { get; set; }
        public FastMemoryDesc                           FastMemoryDesc                          { get; set; }
        public bool                                     FallBackToBlackTexture                  { get; set; }
        public bool                                     DisableFallBackToImportedTexture        { get; set; }
        public bool                                     ClearBuffer                             { get; set; }
        public Color                                    ClearColor                              { get; set; }

        public static TextureDesc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureDesc() { Pointer= p0 };

            value.SizeMode                                  = (TextureSizeMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 SizeMode                    ( ModelEnumType TextureSizeMode TextureSizeMode TextureSizeMode Int32 )
            value.Width                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Height                      ( ModelPrimitiveType int int int Int32 )
            value.Slices                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Slices                      ( ModelPrimitiveType int int int Int32 )
            value.Scale                                     = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 Scale                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Func                                      = GetObject<ScaleFunc>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScaleFunc.FromPointer); // 0x28 Func                        ( ModelClassType ScaleFunc ScaleFunc ScaleFunc Pointer )
            value.DepthBufferBits                           = (DepthBits)GetInt32(new IntPtr(p + 0x030)); // 0x30 DepthBufferBits             ( ModelEnumType DepthBits DepthBits DepthBits Int32 )
            value.ColorFormat                               = (GraphicsFormat)GetInt32(new IntPtr(p + 0x034)); // 0x34 ColorFormat                 ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.FilterMode                                = (FilterMode)GetInt32(new IntPtr(p + 0x038)); // 0x38 FilterMode                  ( ModelEnumType FilterMode FilterMode FilterMode Int32 )
            value.WrapMode                                  = (TextureWrapMode)GetInt32(new IntPtr(p + 0x03C)); // 0x3C WrapMode                    ( ModelEnumType TextureWrapMode TextureWrapMode TextureWrapMode Int32 )
            value.Dimension                                 = (TextureDimension)GetInt32(new IntPtr(p + 0x040)); // 0x40 Dimension                   ( ModelEnumType TextureDimension TextureDimension TextureDimension Int32 )
            value.EnableRandomWrite                         = GetBool(new IntPtr(p + 0x044)); // 0x44 EnableRandomWrite           ( ModelPrimitiveType bool bool bool Bool )
            value.UseMipMap                                 = GetBool(new IntPtr(p + 0x045)); // 0x45 UseMipMap                   ( ModelPrimitiveType bool bool bool Bool )
            value.AutoGenerateMips                          = GetBool(new IntPtr(p + 0x046)); // 0x46 AutoGenerateMips            ( ModelPrimitiveType bool bool bool Bool )
            value.IsShadowMap                               = GetBool(new IntPtr(p + 0x047)); // 0x47 IsShadowMap                 ( ModelPrimitiveType bool bool bool Bool )
            value.AnisoLevel                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 AnisoLevel                  ( ModelPrimitiveType int int int Int32 )
            value.MipMapBias                                = GetSingle(new IntPtr(p + 0x04C)); // 0x4C MipMapBias                  ( ModelPrimitiveType float float float Single )
            value.MsaaSamples                               = (MSAASamples)GetInt32(new IntPtr(p + 0x050)); // 0x50 MsaaSamples                 ( ModelEnumType MSAASamples MSAASamples MSAASamples Int32 )
            value.BindTextureMS                             = GetBool(new IntPtr(p + 0x054)); // 0x54 BindTextureMS               ( ModelPrimitiveType bool bool bool Bool )
            value.UseDynamicScale                           = GetBool(new IntPtr(p + 0x055)); // 0x55 UseDynamicScale             ( ModelPrimitiveType bool bool bool Bool )
            value.Memoryless                                = (RenderTextureMemoryless)GetInt32(new IntPtr(p + 0x058)); // 0x58 Memoryless                  ( ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32 )
            value.VrUsage                                   = (VRTextureUsage)GetInt32(new IntPtr(p + 0x05C)); // 0x5C VrUsage                     ( ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x060)); // 0x60 Name                        ( ModelPrimitiveType string string string String )
            value.FastMemoryDesc                            = (FastMemoryDesc)GetInt32(new IntPtr(p + 0x068)); // 0x68 FastMemoryDesc              ( ModelEnumType FastMemoryDesc FastMemoryDesc FastMemoryDesc Int32 )
            value.FallBackToBlackTexture                    = GetBool(new IntPtr(p + 0x074)); // 0x74 FallBackToBlackTexture      ( ModelPrimitiveType bool bool bool Bool )
            value.DisableFallBackToImportedTexture          = GetBool(new IntPtr(p + 0x075)); // 0x75 DisableFallBackToImportedTexture ( ModelPrimitiveType bool bool bool Bool )
            value.ClearBuffer                               = GetBool(new IntPtr(p + 0x076)); // 0x76 ClearBuffer                 ( ModelPrimitiveType bool bool bool Bool )
            value.ClearColor                                = (Color)GetInt32(new IntPtr(p + 0x078)); // 0x78 ClearColor                  ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
