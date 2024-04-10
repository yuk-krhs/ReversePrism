using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SizeMode                                 000186657360 ModelEnumType TextureSizeMode TextureSizeMode TextureSizeMode Int32
    // 014 Width                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Height                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Slices                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Scale                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 Func                                     0001866C1360 ModelClassType ScaleFunc ScaleFunc ScaleFunc Pointer
    // 030 DepthBufferBits                          0001866C18F0 ModelEnumType DepthBits DepthBits DepthBits Int32
    // 034 ColorFormat                              000186696620 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 038 FilterMode                               0001865809A0 ModelEnumType FilterMode FilterMode FilterMode Int32
    // 03C WrapMode                                 0001866581E0 ModelEnumType TextureWrapMode TextureWrapMode TextureWrapMode Int32
    // 040 Dimension                                000186651D60 ModelEnumType TextureDimension TextureDimension TextureDimension Int32
    // 044 EnableRandomWrite                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 045 UseMipMap                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 046 AutoGenerateMips                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 047 IsShadowMap                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 048 AnisoLevel                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 04C MipMapBias                               000186666050 ModelPrimitiveType float float float Single
    // 050 MsaaSamples                              0001865C5E80 ModelEnumType MSAASamples MSAASamples MSAASamples Int32
    // 054 BindTextureMS                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 055 UseDynamicScale                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 058 Memoryless                               00018665D080 ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32
    // 05C VrUsage                                  000186763FD0 ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32
    // 060 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 068 FastMemoryDesc                           000186558A70 ModelEnumType FastMemoryDesc FastMemoryDesc FastMemoryDesc Int32
    // 074 FallBackToBlackTexture                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 075 DisableFallBackToImportedTexture         000186595960 ModelPrimitiveType bool bool bool Bool
    // 076 ClearBuffer                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 078 ClearColor                               0001865AB0A0 ModelEnumType Color Color Color Int32
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

            value.SizeMode                                  = (TextureSizeMode)GetInt32(new IntPtr(p + 0x010)); // 0246691072D0 0x10 SizeMode                    ( 000186657360 ModelEnumType TextureSizeMode TextureSizeMode TextureSizeMode Int32 )
            value.Width                                     = GetInt32(new IntPtr(p + 0x014)); // 0246691072F0 0x14 Width                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x018)); // 024669107310 0x18 Height                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Slices                                    = GetInt32(new IntPtr(p + 0x01C)); // 024669107330 0x1C Slices                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Scale                                     = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 024669107350 0x20 Scale                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Func                                      = GetObject<ScaleFunc>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScaleFunc.FromPointer); // 024669107370 0x28 Func                        ( 0001866C1360 ModelClassType ScaleFunc ScaleFunc ScaleFunc Pointer )
            value.DepthBufferBits                           = (DepthBits)GetInt32(new IntPtr(p + 0x030)); // 024669107390 0x30 DepthBufferBits             ( 0001866C18F0 ModelEnumType DepthBits DepthBits DepthBits Int32 )
            value.ColorFormat                               = (GraphicsFormat)GetInt32(new IntPtr(p + 0x034)); // 0246691073B0 0x34 ColorFormat                 ( 000186696620 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.FilterMode                                = (FilterMode)GetInt32(new IntPtr(p + 0x038)); // 0246691073D0 0x38 FilterMode                  ( 0001865809A0 ModelEnumType FilterMode FilterMode FilterMode Int32 )
            value.WrapMode                                  = (TextureWrapMode)GetInt32(new IntPtr(p + 0x03C)); // 0246691073F0 0x3C WrapMode                    ( 0001866581E0 ModelEnumType TextureWrapMode TextureWrapMode TextureWrapMode Int32 )
            value.Dimension                                 = (TextureDimension)GetInt32(new IntPtr(p + 0x040)); // 024669107410 0x40 Dimension                   ( 000186651D60 ModelEnumType TextureDimension TextureDimension TextureDimension Int32 )
            value.EnableRandomWrite                         = GetBool(new IntPtr(p + 0x044)); // 024669107430 0x44 EnableRandomWrite           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseMipMap                                 = GetBool(new IntPtr(p + 0x045)); // 024669107450 0x45 UseMipMap                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AutoGenerateMips                          = GetBool(new IntPtr(p + 0x046)); // 024669107470 0x46 AutoGenerateMips            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsShadowMap                               = GetBool(new IntPtr(p + 0x047)); // 024669107490 0x47 IsShadowMap                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AnisoLevel                                = GetInt32(new IntPtr(p + 0x048)); // 0246691074B0 0x48 AnisoLevel                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MipMapBias                                = GetSingle(new IntPtr(p + 0x04C)); // 0246691074D0 0x4C MipMapBias                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.MsaaSamples                               = (MSAASamples)GetInt32(new IntPtr(p + 0x050)); // 0246691074F0 0x50 MsaaSamples                 ( 0001865C5E80 ModelEnumType MSAASamples MSAASamples MSAASamples Int32 )
            value.BindTextureMS                             = GetBool(new IntPtr(p + 0x054)); // 024669107510 0x54 BindTextureMS               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseDynamicScale                           = GetBool(new IntPtr(p + 0x055)); // 024669107530 0x55 UseDynamicScale             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Memoryless                                = (RenderTextureMemoryless)GetInt32(new IntPtr(p + 0x058)); // 024669107550 0x58 Memoryless                  ( 00018665D080 ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32 )
            value.VrUsage                                   = (VRTextureUsage)GetInt32(new IntPtr(p + 0x05C)); // 024669107570 0x5C VrUsage                     ( 000186763FD0 ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x060)); // 024669107590 0x60 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FastMemoryDesc                            = (FastMemoryDesc)GetInt32(new IntPtr(p + 0x068)); // 0246691075B0 0x68 FastMemoryDesc              ( 000186558A70 ModelEnumType FastMemoryDesc FastMemoryDesc FastMemoryDesc Int32 )
            value.FallBackToBlackTexture                    = GetBool(new IntPtr(p + 0x074)); // 0246691075D0 0x74 FallBackToBlackTexture      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DisableFallBackToImportedTexture          = GetBool(new IntPtr(p + 0x075)); // 0246691075F0 0x75 DisableFallBackToImportedTexture ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ClearBuffer                               = GetBool(new IntPtr(p + 0x076)); // 024669107610 0x76 ClearBuffer                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ClearColor                                = (Color)GetInt32(new IntPtr(p + 0x078)); // 024669107630 0x78 ClearColor                  ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
