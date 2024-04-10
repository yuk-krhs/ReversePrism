using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 UseSRPBatcher                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 SupportsDynamicBatching                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A SupportsHDR                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C Msaa                                     0001865C5C50 ModelEnumType MSAASamples MSAASamples MSAASamples Int32
    // 020 ShadowResolution                         000186750BD0 ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 024 EnableFloorShadow                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 EnableDropShadow                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 DepthBufferBits                          0001866C1680 ModelEnumType DepthBits DepthBits DepthBits Int32
    // 02C Enable3DFPSLimit                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 GrabTextureDownSampling                  0001866F3310 ModelEnumType Downsampling Downsampling Downsampling Int32
    // 034 FilterMode                               000186580780 ModelEnumType FilterMode FilterMode FilterMode Int32
    // 038 EnableOverdrawRenderingMode              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 CharacterPassNames                       000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 DropShadowPass                           000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 FloorShadowPass                          000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 OpaquePassNames                          000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 CopyColorShader                          00018674C760 ModelClassType Shader Shader Shader Pointer
    // 068 CopyDepthShader                          00018674C760 ModelClassType Shader Shader Shader Pointer
    // 070 DrawStencilToAlphaShader                 00018674C760 ModelClassType Shader Shader Shader Pointer
    // 078 DrawByStencilShader                      00018674C760 ModelClassType Shader Shader Shader Pointer
    // 080 FallbackErrorShader                      00018674C760 ModelClassType Shader Shader Shader Pointer
    // 088 OverdrawOpaqueShader                     00018674C760 ModelClassType Shader Shader Shader Pointer
    // 090 OverdrawTransparentShader                00018674C760 ModelClassType Shader Shader Shader Pointer
    // 098 CopyColorMaterial                        00018660BDD0 ModelClassType Material Material Material Pointer
    // 0A0 CopyDepthMaterial                        00018660BDD0 ModelClassType Material Material Material Pointer
    // 0A8 DrawStencilToAlphaMaterial               00018660BDD0 ModelClassType Material Material Material Pointer
    // 0B0 DrawByStencilMaterial                    00018660BDD0 ModelClassType Material Material Material Pointer
    // 0B8 OverdrawOpaqueMaterial                   00018660BDD0 ModelClassType Material Material Material Pointer
    // 0C0 OverdrawTransparentMaterial              00018660BDD0 ModelClassType Material Material Material Pointer
    // 0C8 RenderingCamera                          0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 0D0 Is3DRenderingStart                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PrismRenderPipelineAsset : DataModel
    {
        public bool                                     UseSRPBatcher                           { get; set; }
        public bool                                     SupportsDynamicBatching                 { get; set; }
        public bool                                     SupportsHDR                             { get; set; }
        public MSAASamples                              Msaa                                    { get; set; }
        public ShadowResolution                         ShadowResolution                        { get; set; }
        public bool                                     EnableFloorShadow                       { get; set; }
        public bool                                     EnableDropShadow                        { get; set; }
        public DepthBits                                DepthBufferBits                         { get; set; }
        public bool                                     Enable3DFPSLimit                        { get; set; }
        public Downsampling                             GrabTextureDownSampling                 { get; set; }
        public FilterMode                               FilterMode                              { get; set; }
        public bool                                     EnableOverdrawRenderingMode             { get; set; }
        public List<string>?                            CharacterPassNames                      { get; set; }
        public List<string>?                            DropShadowPass                          { get; set; }
        public List<string>?                            FloorShadowPass                         { get; set; }
        public List<string>?                            OpaquePassNames                         { get; set; }
        public Shader?                                  CopyColorShader                         { get; set; }
        public Shader?                                  CopyDepthShader                         { get; set; }
        public Shader?                                  DrawStencilToAlphaShader                { get; set; }
        public Shader?                                  DrawByStencilShader                     { get; set; }
        public Shader?                                  FallbackErrorShader                     { get; set; }
        public Shader?                                  OverdrawOpaqueShader                    { get; set; }
        public Shader?                                  OverdrawTransparentShader               { get; set; }
        public Material?                                CopyColorMaterial                       { get; set; }
        public Material?                                CopyDepthMaterial                       { get; set; }
        public Material?                                DrawStencilToAlphaMaterial              { get; set; }
        public Material?                                DrawByStencilMaterial                   { get; set; }
        public Material?                                OverdrawOpaqueMaterial                  { get; set; }
        public Material?                                OverdrawTransparentMaterial             { get; set; }
        public Camera?                                  RenderingCamera                         { get; set; }
        public bool                                     Is3DRenderingStart                      { get; set; }

        public static PrismRenderPipelineAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismRenderPipelineAsset() { Pointer= p0 };

            value.UseSRPBatcher                             = GetBool(new IntPtr(p + 0x018)); // 0245A3342998 0x18 UseSRPBatcher               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SupportsDynamicBatching                   = GetBool(new IntPtr(p + 0x019)); // 0245A33429B8 0x19 SupportsDynamicBatching     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SupportsHDR                               = GetBool(new IntPtr(p + 0x01A)); // 0245A33429D8 0x1A SupportsHDR                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Msaa                                      = (MSAASamples)GetInt32(new IntPtr(p + 0x01C)); // 0245A33429F8 0x1C Msaa                        ( 0001865C5C50 ModelEnumType MSAASamples MSAASamples MSAASamples Int32 )
            value.ShadowResolution                          = (ShadowResolution)GetInt32(new IntPtr(p + 0x020)); // 0245A3342A18 0x20 ShadowResolution            ( 000186750BD0 ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.EnableFloorShadow                         = GetBool(new IntPtr(p + 0x024)); // 0245A3342A38 0x24 EnableFloorShadow           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EnableDropShadow                          = GetBool(new IntPtr(p + 0x025)); // 0245A3342A58 0x25 EnableDropShadow            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DepthBufferBits                           = (DepthBits)GetInt32(new IntPtr(p + 0x028)); // 0245A3342A78 0x28 DepthBufferBits             ( 0001866C1680 ModelEnumType DepthBits DepthBits DepthBits Int32 )
            value.Enable3DFPSLimit                          = GetBool(new IntPtr(p + 0x02C)); // 0245A3342A98 0x2C Enable3DFPSLimit            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GrabTextureDownSampling                   = (Downsampling)GetInt32(new IntPtr(p + 0x030)); // 0245A3342AB8 0x30 GrabTextureDownSampling     ( 0001866F3310 ModelEnumType Downsampling Downsampling Downsampling Int32 )
            value.FilterMode                                = (FilterMode)GetInt32(new IntPtr(p + 0x034)); // 0245A3342AD8 0x34 FilterMode                  ( 000186580780 ModelEnumType FilterMode FilterMode FilterMode Int32 )
            value.EnableOverdrawRenderingMode               = GetBool(new IntPtr(p + 0x038)); // 0245A3342AF8 0x38 EnableOverdrawRenderingMode ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CharacterPassNames                        = GetStringList(new IntPtr(p + 0x040)); // 0245A3342B18 0x40 CharacterPassNames          ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DropShadowPass                            = GetStringList(new IntPtr(p + 0x048)); // 0245A3342B38 0x48 DropShadowPass              ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FloorShadowPass                           = GetStringList(new IntPtr(p + 0x050)); // 0245A3342B58 0x50 FloorShadowPass             ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OpaquePassNames                           = GetStringList(new IntPtr(p + 0x058)); // 0245A3342B78 0x58 OpaquePassNames             ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CopyColorShader                           = GetObject<Shader>(new IntPtr(p + 0x060), ReversePrism.DataModels.Shader.FromPointer); // 0245A3342B98 0x60 CopyColorShader             ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.CopyDepthShader                           = GetObject<Shader>(new IntPtr(p + 0x068), ReversePrism.DataModels.Shader.FromPointer); // 0245A3342BB8 0x68 CopyDepthShader             ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.DrawStencilToAlphaShader                  = GetObject<Shader>(new IntPtr(p + 0x070), ReversePrism.DataModels.Shader.FromPointer); // 0245A3342BD8 0x70 DrawStencilToAlphaShader    ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.DrawByStencilShader                       = GetObject<Shader>(new IntPtr(p + 0x078), ReversePrism.DataModels.Shader.FromPointer); // 0245A3342BF8 0x78 DrawByStencilShader         ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.FallbackErrorShader                       = GetObject<Shader>(new IntPtr(p + 0x080), ReversePrism.DataModels.Shader.FromPointer); // 0245A3342C18 0x80 FallbackErrorShader         ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.OverdrawOpaqueShader                      = GetObject<Shader>(new IntPtr(p + 0x088), ReversePrism.DataModels.Shader.FromPointer); // 0245A3342C38 0x88 OverdrawOpaqueShader        ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.OverdrawTransparentShader                 = GetObject<Shader>(new IntPtr(p + 0x090), ReversePrism.DataModels.Shader.FromPointer); // 0245A3342C58 0x90 OverdrawTransparentShader   ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.CopyColorMaterial                         = GetObject<Material>(new IntPtr(p + 0x098), ReversePrism.DataModels.Material.FromPointer); // 0245A3342C78 0x98 CopyColorMaterial           ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.CopyDepthMaterial                         = GetObject<Material>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Material.FromPointer); // 0245A3342C98 0xA0 CopyDepthMaterial           ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.DrawStencilToAlphaMaterial                = GetObject<Material>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Material.FromPointer); // 0245A3342CB8 0xA8 DrawStencilToAlphaMaterial  ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.DrawByStencilMaterial                     = GetObject<Material>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Material.FromPointer); // 0245A3342CD8 0xB0 DrawByStencilMaterial       ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.OverdrawOpaqueMaterial                    = GetObject<Material>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Material.FromPointer); // 0245A3342CF8 0xB8 OverdrawOpaqueMaterial      ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.OverdrawTransparentMaterial               = GetObject<Material>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Material.FromPointer); // 0245A3342D18 0xC0 OverdrawTransparentMaterial ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.RenderingCamera                           = GetObject<Camera>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Camera.FromPointer); // 0245A3342D38 0xC8 RenderingCamera             ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.Is3DRenderingStart                        = GetBool(new IntPtr(p + 0x0D0)); // 0245A3342D58 0xD0 Is3DRenderingStart          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
