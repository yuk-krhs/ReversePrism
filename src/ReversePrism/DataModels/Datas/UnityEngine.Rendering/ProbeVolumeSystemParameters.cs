using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemoryBudget                             000186523550 ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32
    // 014 BlendingMemoryBudget                     000186520BA0 ModelEnumType ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget Int32
    // 018 ProbeDebugMesh                           0001866109A0 ModelClassType Mesh Mesh Mesh Pointer
    // 020 ProbeDebugShader                         00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 028 OffsetDebugMesh                          0001866109A0 ModelClassType Mesh Mesh Mesh Pointer
    // 030 OffsetDebugShader                        00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 038 ScenarioBlendingShader                   0001865F75D0 ModelClassType ComputeShader ComputeShader ComputeShader Pointer
    // 040 SceneData                                000186522B60 ModelClassType ProbeVolumeSceneData ProbeVolumeSceneData ProbeVolumeSceneData Pointer
    // 048 ShBands                                  0001865220A0 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32
    // 04C SupportsRuntimeDebug                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 04D SupportStreaming                         000186595960 ModelPrimitiveType bool bool bool Bool
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

            value.MemoryBudget                              = (ProbeVolumeTextureMemoryBudget)GetInt32(new IntPtr(p + 0x010)); // 024669237448 0x10 MemoryBudget                ( 000186523550 ModelEnumType ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget ProbeVolumeTextureMemoryBudget Int32 )
            value.BlendingMemoryBudget                      = (ProbeVolumeBlendingTextureMemoryBudget)GetInt32(new IntPtr(p + 0x014)); // 024669237468 0x14 BlendingMemoryBudget        ( 000186520BA0 ModelEnumType ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget ProbeVolumeBlendingTextureMemoryBudget Int32 )
            value.ProbeDebugMesh                            = GetObject<Mesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.Mesh.FromPointer); // 024669237488 0x18 ProbeDebugMesh              ( 0001866109A0 ModelClassType Mesh Mesh Mesh Pointer )
            value.ProbeDebugShader                          = GetObject<Shader>(new IntPtr(p + 0x020), ReversePrism.DataModels.Shader.FromPointer); // 0246692374A8 0x20 ProbeDebugShader            ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.OffsetDebugMesh                           = GetObject<Mesh>(new IntPtr(p + 0x028), ReversePrism.DataModels.Mesh.FromPointer); // 0246692374C8 0x28 OffsetDebugMesh             ( 0001866109A0 ModelClassType Mesh Mesh Mesh Pointer )
            value.OffsetDebugShader                         = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0246692374E8 0x30 OffsetDebugShader           ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.ScenarioBlendingShader                    = GetObject<ComputeShader>(new IntPtr(p + 0x038), ReversePrism.DataModels.ComputeShader.FromPointer); // 024669237508 0x38 ScenarioBlendingShader      ( 0001865F75D0 ModelClassType ComputeShader ComputeShader ComputeShader Pointer )
            value.SceneData                                 = GetObject<ProbeVolumeSceneData>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProbeVolumeSceneData.FromPointer); // 024669237528 0x40 SceneData                   ( 000186522B60 ModelClassType ProbeVolumeSceneData ProbeVolumeSceneData ProbeVolumeSceneData Pointer )
            value.ShBands                                   = (ProbeVolumeSHBands)GetInt32(new IntPtr(p + 0x048)); // 024669237548 0x48 ShBands                     ( 0001865220A0 ModelEnumType ProbeVolumeSHBands ProbeVolumeSHBands ProbeVolumeSHBands Int32 )
            value.SupportsRuntimeDebug                      = GetBool(new IntPtr(p + 0x04C)); // 024669237568 0x4C SupportsRuntimeDebug        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SupportStreaming                          = GetBool(new IntPtr(p + 0x04D)); // 024669237588 0x4D SupportStreaming            ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
