using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ShadowResolution                         ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 01C EnableDropShadow                         ModelPrimitiveType bool bool bool Bool
    // 020 DepthBufferBits                          ModelEnumType DepthBits DepthBits DepthBits Int32
    // 024 Enable3DFPSLimit                         ModelPrimitiveType bool bool bool Bool
    // 028 GrabTextureDownSampling                  ModelEnumType Downsampling Downsampling Downsampling Int32
    // 02C FilterMode                               ModelEnumType FilterMode FilterMode FilterMode Int32
    // 030 ReservedBufferScale                      ModelPrimitiveType float float float Single
    // 038 CharacterPassNames                       ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 DropShadowPass                           ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 OpaquePassNames                          ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 Is3DRenderingStart                       ModelPrimitiveType bool bool bool Bool
    public partial class PrismRenderPipelineAsset : DataModel
    {
        public ShadowResolution                         ShadowResolution                        { get; set; }
        public bool                                     EnableDropShadow                        { get; set; }
        public DepthBits                                DepthBufferBits                         { get; set; }
        public bool                                     Enable3DFPSLimit                        { get; set; }
        public Downsampling                             GrabTextureDownSampling                 { get; set; }
        public FilterMode                               FilterMode                              { get; set; }
        public float                                    ReservedBufferScale                     { get; set; }
        public List<string>?                            CharacterPassNames                      { get; set; }
        public List<string>?                            DropShadowPass                          { get; set; }
        public List<string>?                            OpaquePassNames                         { get; set; }
        public bool                                     Is3DRenderingStart                      { get; set; }

        public static PrismRenderPipelineAsset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismRenderPipelineAsset() { Pointer= p0 };

            value.ShadowResolution                          = (ShadowResolution)GetInt32(new IntPtr(p + 0x018)); // 0x18 ShadowResolution            ( ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.EnableDropShadow                          = GetBool(new IntPtr(p + 0x01C)); // 0x1C EnableDropShadow            ( ModelPrimitiveType bool bool bool Bool )
            value.DepthBufferBits                           = (DepthBits)GetInt32(new IntPtr(p + 0x020)); // 0x20 DepthBufferBits             ( ModelEnumType DepthBits DepthBits DepthBits Int32 )
            value.Enable3DFPSLimit                          = GetBool(new IntPtr(p + 0x024)); // 0x24 Enable3DFPSLimit            ( ModelPrimitiveType bool bool bool Bool )
            value.GrabTextureDownSampling                   = (Downsampling)GetInt32(new IntPtr(p + 0x028)); // 0x28 GrabTextureDownSampling     ( ModelEnumType Downsampling Downsampling Downsampling Int32 )
            value.FilterMode                                = (FilterMode)GetInt32(new IntPtr(p + 0x02C)); // 0x2C FilterMode                  ( ModelEnumType FilterMode FilterMode FilterMode Int32 )
            value.ReservedBufferScale                       = GetSingle(new IntPtr(p + 0x030)); // 0x30 ReservedBufferScale         ( ModelPrimitiveType float float float Single )
            value.CharacterPassNames                        = GetStringList(new IntPtr(p + 0x038)); // 0x38 CharacterPassNames          ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DropShadowPass                            = GetStringList(new IntPtr(p + 0x040)); // 0x40 DropShadowPass              ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OpaquePassNames                           = GetStringList(new IntPtr(p + 0x048)); // 0x48 OpaquePassNames             ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Is3DRenderingStart                        = GetBool(new IntPtr(p + 0x050)); // 0x50 Is3DRenderingStart          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
