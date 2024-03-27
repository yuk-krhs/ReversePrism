using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortingCriteria                          000186534080 ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32
    // 014 RendererConfiguration                    00018672F390 ModelEnumType PerObjectData PerObjectData PerObjectData Int32
    // 018 RenderQueueRange                         000186659540 ModelEnumType RenderQueueRange RenderQueueRange RenderQueueRange Int32
    // 020 stateBlock                               Nullable`1<RenderStateBlock> IL2CPP_TYPE_GENERICINST
    // 090 OverrideShader                           00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 098 OverrideMaterial                         00018660C4B0 ModelClassType Material Material Material Pointer
    // 0A0 ExcludeObjectMotionVectors               000186595960 ModelPrimitiveType bool bool bool Bool
    // 0A4 LayerMask                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A8 RenderingLayerMask                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 0AC OverrideMaterialPassIndex                0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B0 OverrideShaderPassIndex                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B8 CullingResult                            0001866656C0 ModelEnumType CullingResults CullingResults CullingResults Int32
    // 0C8 Camera                                   0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 0D0 PassName                                 000186664410 ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 0D8 PassNames                                000185CA3AB8 ModelEnumListType ShaderTagId[] ShaderTagId[] List<ShaderTagId> Pointer
    // 000 s_EmptyName                              ShaderTagId IL2CPP_TYPE_VALUETYPE
    public partial class RendererListDesc
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
            var value   = new RendererListDesc();

            value.SortingCriteria                           = (SortingCriteria)GetInt32(new IntPtr(p + 0x010)); // 0270068D58A8 0x10 SortingCriteria             ( 000186534080 ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32 )
            value.RendererConfiguration                     = (PerObjectData)GetInt32(new IntPtr(p + 0x014)); // 0270068D58C8 0x14 RendererConfiguration       ( 00018672F390 ModelEnumType PerObjectData PerObjectData PerObjectData Int32 )
            value.RenderQueueRange                          = (RenderQueueRange)GetInt32(new IntPtr(p + 0x018)); // 0270068D58E8 0x18 RenderQueueRange            ( 000186659540 ModelEnumType RenderQueueRange RenderQueueRange RenderQueueRange Int32 )
            value.OverrideShader                            = GetObject<Shader>(new IntPtr(p + 0x090), ReversePrism.DataModels.Shader.FromPointer); // 0270068D5928 0x90 OverrideShader              ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.OverrideMaterial                          = GetObject<Material>(new IntPtr(p + 0x098), ReversePrism.DataModels.Material.FromPointer); // 0270068D5948 0x98 OverrideMaterial            ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.ExcludeObjectMotionVectors                = GetBool(new IntPtr(p + 0x0A0)); // 0270068D5968 0xA0 ExcludeObjectMotionVectors  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LayerMask                                 = GetInt32(new IntPtr(p + 0x0A4)); // 0270068D5988 0xA4 LayerMask                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RenderingLayerMask                        = GetUInt32(new IntPtr(p + 0x0A8)); // 0270068D59A8 0xA8 RenderingLayerMask          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.OverrideMaterialPassIndex                 = GetInt32(new IntPtr(p + 0x0AC)); // 0270068D59C8 0xAC OverrideMaterialPassIndex   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OverrideShaderPassIndex                   = GetInt32(new IntPtr(p + 0x0B0)); // 0270068D59E8 0xB0 OverrideShaderPassIndex     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CullingResult                             = (CullingResults)GetInt32(new IntPtr(p + 0x0B8)); // 0270068D5A08 0xB8 CullingResult               ( 0001866656C0 ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Camera.FromPointer); // 0270068D5A28 0xC8 Camera                      ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.PassName                                  = (ShaderTagId)GetInt32(new IntPtr(p + 0x0D0)); // 0270068D5A48 0xD0 PassName                    ( 000186664410 ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.PassNames                                 = GetEnumList<ShaderTagId>(new IntPtr(p + 0x0D8)); // 0270068D5A68 0xD8 PassNames                   ( 000185CA3AB8 ModelEnumListType ShaderTagId[] ShaderTagId[] List<ShaderTagId> Pointer )

            return value;
        }
    }
}
