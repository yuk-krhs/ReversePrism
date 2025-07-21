using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Settings                               ModelClassType ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings Pointer
    // 028 M_BlueNoise256Textures                   ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 030 M_Shader                                 ModelClassType Shader Shader Shader Pointer
    // 038 M_Material                               ModelClassType Material Material Material Pointer
    // 040 M_SSAOPass                               ModelClassType ScreenSpaceAmbientOcclusionPass ScreenSpaceAmbientOcclusionPass ScreenSpaceAmbientOcclusionPass Pointer
    // 000 k_AOInterleavedGradientKeyword           string IL2CPP_TYPE_STRING
    // 000 k_AOBlueNoiseKeyword                     string IL2CPP_TYPE_STRING
    // 000 k_OrthographicCameraKeyword              string IL2CPP_TYPE_STRING
    // 000 k_SourceDepthLowKeyword                  string IL2CPP_TYPE_STRING
    // 000 k_SourceDepthMediumKeyword               string IL2CPP_TYPE_STRING
    // 000 k_SourceDepthHighKeyword                 string IL2CPP_TYPE_STRING
    // 000 k_SourceDepthNormalsKeyword              string IL2CPP_TYPE_STRING
    // 000 k_SampleCountLowKeyword                  string IL2CPP_TYPE_STRING
    // 000 k_SampleCountMediumKeyword               string IL2CPP_TYPE_STRING
    // 000 k_SampleCountHighKeyword                 string IL2CPP_TYPE_STRING
    public partial class ScreenSpaceAmbientOcclusion : DataModel
    {
        public ScreenSpaceAmbientOcclusionSettings?     M_Settings                              { get; set; }
        public List<Texture2D>?                         M_BlueNoise256Textures                  { get; set; }
        public Shader?                                  M_Shader                                { get; set; }
        public Material?                                M_Material                              { get; set; }
        public ScreenSpaceAmbientOcclusionPass?         M_SSAOPass                              { get; set; }

        public static ScreenSpaceAmbientOcclusion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenSpaceAmbientOcclusion() { Pointer= p0 };

            value.M_Settings                                = GetObject<ScreenSpaceAmbientOcclusionSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScreenSpaceAmbientOcclusionSettings.FromPointer); // 0x20 M_Settings                  ( ModelClassType ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings ScreenSpaceAmbientOcclusionSettings Pointer )
            value.M_BlueNoise256Textures                    = GetObjectList<Texture2D>(new IntPtr(p + 0x028), ReversePrism.DataModels.Texture2D.FromPointer); // 0x28 M_BlueNoise256Textures      ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.M_Shader                                  = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0x30 M_Shader                    ( ModelClassType Shader Shader Shader Pointer )
            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 M_Material                  ( ModelClassType Material Material Material Pointer )
            value.M_SSAOPass                                = GetObject<ScreenSpaceAmbientOcclusionPass>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScreenSpaceAmbientOcclusionPass.FromPointer); // 0x40 M_SSAOPass                  ( ModelClassType ScreenSpaceAmbientOcclusionPass ScreenSpaceAmbientOcclusionPass ScreenSpaceAmbientOcclusionPass Pointer )

            return value;
        }
    }
}
