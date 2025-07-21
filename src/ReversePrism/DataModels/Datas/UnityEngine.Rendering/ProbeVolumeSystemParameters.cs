using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemoryBudget                             ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32
    // 014 BlendingMemoryBudget                     ModelEnumType ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget Int32
    // 018 ProbeDebugMesh                           ModelClassType Mesh Mesh Mesh Pointer
    // 020 ProbeDebugShader                         ModelClassType Shader Shader Shader Pointer
    // 028 OffsetDebugMesh                          ModelClassType Mesh Mesh Mesh Pointer
    // 030 OffsetDebugShader                        ModelClassType Shader Shader Shader Pointer
    // 038 ScenarioBlendingShader                   ModelClassType ComputeShader ComputeShader ComputeShader Pointer
    // 040 SceneData                                ModelClassType ProbeVolumeSceneData ProbeVolumeSceneData ProbeVolumeSceneData Pointer
    // 048 ShBands                                  ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    // 04C SupportsRuntimeDebug                     ModelPrimitiveType bool bool bool Bool
    // 04D SupportStreaming                         ModelPrimitiveType bool bool bool Bool
    public partial class ProbeVolumeSystemParameters : DataModel
    {
        public ProbeVolumeTextureMemoryBudget           MemoryBudget                            { get; set; }
        public ProbeVolumeBlendingTextureMemoryBudget   BlendingMemoryBudget                    { get; set; }
        public Mesh?                                    ProbeDebugMesh                          { get; set; }
        public Shader?                                  ProbeDebugShader                        { get; set; }
        public Mesh?                                    OffsetDebugMesh                         { get; set; }
        public Shader?                                  OffsetDebugShader                       { get; set; }
        public ComputeShader?                           ScenarioBlendingShader                  { get; set; }
        public ProbeVolumeSceneData?                    SceneData                               { get; set; }
        public ProbeVolumeSHBands                       ShBands                                 { get; set; }
        public bool                                     SupportsRuntimeDebug                    { get; set; }
        public bool                                     SupportStreaming                        { get; set; }

        public static ProbeVolumeSystemParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeVolumeSystemParameters() { Pointer= p0 };

            value.MemoryBudget                              = (ProbeVolumeTextureMemoryBudget)GetInt32(new IntPtr(p + 0x010)); // 0x10 MemoryBudget                ( ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32 )
            value.BlendingMemoryBudget                      = (ProbeVolumeBlendingTextureMemoryBudget)GetInt32(new IntPtr(p + 0x014)); // 0x14 BlendingMemoryBudget        ( ModelEnumType ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget Int32 )
            value.ProbeDebugMesh                            = GetObject<Mesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.Mesh.FromPointer); // 0x18 ProbeDebugMesh              ( ModelClassType Mesh Mesh Mesh Pointer )
            value.ProbeDebugShader                          = GetObject<Shader>(new IntPtr(p + 0x020), ReversePrism.DataModels.Shader.FromPointer); // 0x20 ProbeDebugShader            ( ModelClassType Shader Shader Shader Pointer )
            value.OffsetDebugMesh                           = GetObject<Mesh>(new IntPtr(p + 0x028), ReversePrism.DataModels.Mesh.FromPointer); // 0x28 OffsetDebugMesh             ( ModelClassType Mesh Mesh Mesh Pointer )
            value.OffsetDebugShader                         = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0x30 OffsetDebugShader           ( ModelClassType Shader Shader Shader Pointer )
            value.ScenarioBlendingShader                    = GetObject<ComputeShader>(new IntPtr(p + 0x038), ReversePrism.DataModels.ComputeShader.FromPointer); // 0x38 ScenarioBlendingShader      ( ModelClassType ComputeShader ComputeShader ComputeShader Pointer )
            value.SceneData                                 = GetObject<ProbeVolumeSceneData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProbeVolumeSceneData.FromPointer); // 0x40 SceneData                   ( ModelClassType ProbeVolumeSceneData ProbeVolumeSceneData ProbeVolumeSceneData Pointer )
            value.ShBands                                   = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x048)); // 0x48 ShBands                     ( ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )
            value.SupportsRuntimeDebug                      = GetBool(new IntPtr(p + 0x04C)); // 0x4C SupportsRuntimeDebug        ( ModelPrimitiveType bool bool bool Bool )
            value.SupportStreaming                          = GetBool(new IntPtr(p + 0x04D)); // 0x4D SupportStreaming            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
