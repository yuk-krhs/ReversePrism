using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderTarget                             ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 038 RenderTargetDesc                         ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 070 CullingParameters                        ModelEnumType ScriptableCullingParameters ScriptableCullingParameters ScriptableCullingParameters Int32
    // 6A0 OcclusionMeshMaterial                    ModelClassType Material Material Material Pointer
    // 6A8 foveatedRenderingInfo                    <int> IL2CPP_TYPE_I
    // 6B0 MultipassId                              ModelPrimitiveType int int int Int32
    // 6B4 CullingPassId                            ModelPrimitiveType int int int Int32
    // 6B8 CopyDepth                                ModelPrimitiveType bool bool bool Bool
    public partial class XRPassCreateInfo : DataModel
    {
        public RenderTargetIdentifier                   RenderTarget                            { get; set; }
        public RenderTextureDescriptor                  RenderTargetDesc                        { get; set; }
        public ScriptableCullingParameters              CullingParameters                       { get; set; }
        public Material?                                OcclusionMeshMaterial                   { get; set; }
        public int                                      MultipassId                             { get; set; }
        public int                                      CullingPassId                           { get; set; }
        public bool                                     CopyDepth                               { get; set; }

        public static XRPassCreateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRPassCreateInfo() { Pointer= p0 };

            value.RenderTarget                              = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderTarget                ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.RenderTargetDesc                          = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x038)); // 0x38 RenderTargetDesc            ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.CullingParameters                         = (ScriptableCullingParameters)GetInt32(new IntPtr(p + 0x070)); // 0x70 CullingParameters           ( ModelEnumType ScriptableCullingParameters ScriptableCullingParameters ScriptableCullingParameters Int32 )
            value.OcclusionMeshMaterial                     = GetObject<Material>(new IntPtr(p + 0x6A0), ReversePrism.DataModels.Material.FromPointer); // 0x6A0 OcclusionMeshMaterial       ( ModelClassType Material Material Material Pointer )
            value.MultipassId                               = GetInt32(new IntPtr(p + 0x6B0)); // 0x6B0 MultipassId                 ( ModelPrimitiveType int int int Int32 )
            value.CullingPassId                             = GetInt32(new IntPtr(p + 0x6B4)); // 0x6B4 CullingPassId               ( ModelPrimitiveType int int int Int32 )
            value.CopyDepth                                 = GetBool(new IntPtr(p + 0x6B8)); // 0x6B8 CopyDepth                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
