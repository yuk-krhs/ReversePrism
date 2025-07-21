using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortingCriteria                          ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32
    // 014 RendererConfiguration                    ModelEnumType PerObjectData PerObjectData PerObjectData Int32
    // 018 RenderQueueRange                         ModelEnumType RenderQueueRange RenderQueueRange RenderQueueRange Int32
    // 020 stateBlock                               Nullable`1<RenderStateBlock> IL2CPP_TYPE_GENERICINST
    // 090 OverrideShader                           ModelClassType Shader Shader Shader Pointer
    // 098 OverrideMaterial                         ModelClassType Material Material Material Pointer
    // 0A0 ExcludeObjectMotionVectors               ModelPrimitiveType bool bool bool Bool
    // 0A4 LayerMask                                ModelPrimitiveType int int int Int32
    // 0A8 RenderingLayerMask                       ModelPrimitiveType uint uint uint UInt32
    // 0AC OverrideMaterialPassIndex                ModelPrimitiveType int int int Int32
    // 0B0 OverrideShaderPassIndex                  ModelPrimitiveType int int int Int32
    // 0B8 CullingResult                            ModelEnumType CullingResults CullingResults CullingResults Int32
    // 0C8 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 0D0 PassName                                 ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 0D8 PassNames                                ModelEnumListType ShaderTagId[] ShaderTagId[] List<ShaderTagId> Pointer
    // 000 s_EmptyName                              ShaderTagId IL2CPP_TYPE_VALUETYPE
    public partial class RendererListDesc : DataModel
    {
        public SortingCriteria                          SortingCriteria                         { get; set; }
        public PerObjectData                            RendererConfiguration                   { get; set; }
        public RenderQueueRange                         RenderQueueRange                        { get; set; }
        public Shader?                                  OverrideShader                          { get; set; }
        public Material?                                OverrideMaterial                        { get; set; }
        public bool                                     ExcludeObjectMotionVectors              { get; set; }
        public int                                      LayerMask                               { get; set; }
        public uint                                     RenderingLayerMask                      { get; set; }
        public int                                      OverrideMaterialPassIndex               { get; set; }
        public int                                      OverrideShaderPassIndex                 { get; set; }
        public CullingResults                           CullingResult                           { get; set; }
        public Camera?                                  Camera                                  { get; set; }
        public ShaderTagId                              PassName                                { get; set; }
        public List<ShaderTagId>?                       PassNames                               { get; set; }

        public static RendererListDesc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererListDesc() { Pointer= p0 };

            value.SortingCriteria                           = (SortingCriteria)GetInt32(new IntPtr(p + 0x010)); // 0x10 SortingCriteria             ( ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32 )
            value.RendererConfiguration                     = (PerObjectData)GetInt32(new IntPtr(p + 0x014)); // 0x14 RendererConfiguration       ( ModelEnumType PerObjectData PerObjectData PerObjectData Int32 )
            value.RenderQueueRange                          = (RenderQueueRange)GetInt32(new IntPtr(p + 0x018)); // 0x18 RenderQueueRange            ( ModelEnumType RenderQueueRange RenderQueueRange RenderQueueRange Int32 )
            value.OverrideShader                            = GetObject<Shader>(new IntPtr(p + 0x090), ReversePrism.DataModels.Shader.FromPointer); // 0x90 OverrideShader              ( ModelClassType Shader Shader Shader Pointer )
            value.OverrideMaterial                          = GetObject<Material>(new IntPtr(p + 0x098), ReversePrism.DataModels.Material.FromPointer); // 0x98 OverrideMaterial            ( ModelClassType Material Material Material Pointer )
            value.ExcludeObjectMotionVectors                = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 ExcludeObjectMotionVectors  ( ModelPrimitiveType bool bool bool Bool )
            value.LayerMask                                 = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 LayerMask                   ( ModelPrimitiveType int int int Int32 )
            value.RenderingLayerMask                        = GetUInt32(new IntPtr(p + 0x0A8)); // 0xA8 RenderingLayerMask          ( ModelPrimitiveType uint uint uint UInt32 )
            value.OverrideMaterialPassIndex                 = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC OverrideMaterialPassIndex   ( ModelPrimitiveType int int int Int32 )
            value.OverrideShaderPassIndex                   = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 OverrideShaderPassIndex     ( ModelPrimitiveType int int int Int32 )
            value.CullingResult                             = (CullingResults)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 CullingResult               ( ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Camera.FromPointer); // 0xC8 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.PassName                                  = (ShaderTagId)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 PassName                    ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.PassNames                                 = GetEnumList<ShaderTagId>(new IntPtr(p + 0x0D8)); // 0xD8 PassNames                   ( ModelEnumListType ShaderTagId[] ShaderTagId[] List<ShaderTagId> Pointer )

            return value;
        }
    }
}
