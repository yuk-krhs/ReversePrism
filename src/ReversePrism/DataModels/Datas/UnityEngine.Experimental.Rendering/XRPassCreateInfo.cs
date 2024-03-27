using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderTarget                             000186655700 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 038 RenderTargetDesc                         0001866575B0 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 070 CullingParameters                        000186660FE0 ModelEnumType ScriptableCullingParameters ScriptableCullingParameters ScriptableCullingParameters Int32
    // 6A0 OcclusionMeshMaterial                    00018660BFD0 ModelClassType Material Material Material Pointer
    // 6A8 foveatedRenderingInfo                    <int> IL2CPP_TYPE_I
    // 6B0 MultipassId                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 6B4 CullingPassId                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 6B8 CopyDepth                                000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class XRPassCreateInfo
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
            var value   = new XRPassCreateInfo();

            value.RenderTarget                              = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x010)); // 0270D9077700 0x10 RenderTarget                ( 000186655700 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.RenderTargetDesc                          = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x038)); // 0270D9077720 0x38 RenderTargetDesc            ( 0001866575B0 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.CullingParameters                         = (ScriptableCullingParameters)GetInt32(new IntPtr(p + 0x070)); // 0270D9077740 0x70 CullingParameters           ( 000186660FE0 ModelEnumType ScriptableCullingParameters ScriptableCullingParameters ScriptableCullingParameters Int32 )
            value.OcclusionMeshMaterial                     = GetObject<Material>(new IntPtr(p + 0x6A0), ReversePrism.DataModels.Material.FromPointer); // 0270D9077760 0x6A0 OcclusionMeshMaterial       ( 00018660BFD0 ModelClassType Material Material Material Pointer )
            value.MultipassId                               = GetInt32(new IntPtr(p + 0x6B0)); // 0270D90777A0 0x6B0 MultipassId                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CullingPassId                             = GetInt32(new IntPtr(p + 0x6B4)); // 0270D90777C0 0x6B4 CullingPassId               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CopyDepth                                 = GetBool(new IntPtr(p + 0x6B8)); // 0270D90777E0 0x6B8 CopyDepth                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
