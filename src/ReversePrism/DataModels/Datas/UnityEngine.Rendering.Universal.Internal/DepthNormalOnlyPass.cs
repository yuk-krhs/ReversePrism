using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 ShaderTagIds                             ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer
    // 0E8 DepthHandle                              ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F0 NormalHandle                             ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F8 RenderingLayersHandle                    ModelClassType RTHandle RTHandle RTHandle Pointer
    // 100 EnableRenderingLayers                    ModelPrimitiveType bool bool bool Bool
    // 104 M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    // 120 M_PassData                               ModelClassType PassData PassData PassData Pointer
    // 000 k_DepthNormals                           List`1<ShaderTagId> IL2CPP_TYPE_GENERICINST
    // 008 k_ColorAttachment1                       RTHandle[] IL2CPP_TYPE_SZARRAY
    // 010 K_ColorAttachment2                       ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    public partial class DepthNormalOnlyPass : DataModel
    {
        public List<ShaderTagId>?                       ShaderTagIds                            { get; set; }
        public RTHandle?                                DepthHandle                             { get; set; }
        public RTHandle?                                NormalHandle                            { get; set; }
        public RTHandle?                                RenderingLayersHandle                   { get; set; }
        public bool                                     EnableRenderingLayers                   { get; set; }
        public FilteringSettings                        M_FilteringSettings                     { get; set; }
        public PassData?                                M_PassData                              { get; set; }
        public List<RTHandle>?                          K_ColorAttachment2                      { get; set; }

        public static DepthNormalOnlyPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthNormalOnlyPass() { Pointer= p0 };

            value.ShaderTagIds                              = GetEnumList<ShaderTagId>(new IntPtr(p + 0x0E0)); // 0xE0 ShaderTagIds                ( ModelEnumListType List`1<ShaderTagId> List`1<ShaderTagId> List<ShaderTagId> Pointer )
            value.DepthHandle                               = GetObject<RTHandle>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE8 DepthHandle                 ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.NormalHandle                              = GetObject<RTHandle>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xF0 NormalHandle                ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.RenderingLayersHandle                     = GetObject<RTHandle>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xF8 RenderingLayersHandle       ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.EnableRenderingLayers                     = GetBool(new IntPtr(p + 0x100)); // 0x100 EnableRenderingLayers       ( ModelPrimitiveType bool bool bool Bool )
            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x104)); // 0x104 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x120), ReversePrism.DataModels.PassData.FromPointer); // 0x120 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )
            value.K_ColorAttachment2                        = GetObjectList<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0x10 K_ColorAttachment2          ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )

            return value;
        }
    }
}
