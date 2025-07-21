using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_GenerateEntries                        ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_ConvertEntriesToCommandsMarker         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_GenerateClosingCommandsMarker          ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_NudgeVerticesMarker                    ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_UpdateOpacityIdMarker                  ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_ComputeTransformMatrixMarker           ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 S_blitMaterial_LinearToGamma             ModelClassType Material Material Material Pointer
    // 038 S_blitMaterial_GammaToLinear             ModelClassType Material Material Material Pointer
    // 040 S_blitMaterial_NoChange                  ModelClassType Material Material Material Pointer
    // 048 S_blitShader                             ModelClassType Shader Shader Shader Pointer
    public partial class CommandGenerator : DataModel
    {
        public ProfilerMarker                           K_GenerateClosingCommandsMarker         { get; set; }
        public ProfilerMarker                           K_NudgeVerticesMarker                   { get; set; }
        public ProfilerMarker                           K_UpdateOpacityIdMarker                 { get; set; }
        public ProfilerMarker                           K_ComputeTransformMatrixMarker          { get; set; }
        public Material?                                S_blitMaterial_LinearToGamma            { get; set; }
        public Material?                                S_blitMaterial_GammaToLinear            { get; set; }
        public Material?                                S_blitMaterial_NoChange                 { get; set; }
        public Shader?                                  S_blitShader                            { get; set; }

        public static CommandGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommandGenerator() { Pointer= p0 };

            value.K_GenerateClosingCommandsMarker           = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 K_GenerateClosingCommandsMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_NudgeVerticesMarker                     = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0x18 K_NudgeVerticesMarker       ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_UpdateOpacityIdMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0x20 K_UpdateOpacityIdMarker     ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ComputeTransformMatrixMarker            = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0x28 K_ComputeTransformMatrixMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_blitMaterial_LinearToGamma              = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0x30 S_blitMaterial_LinearToGamma ( ModelClassType Material Material Material Pointer )
            value.S_blitMaterial_GammaToLinear              = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 S_blitMaterial_GammaToLinear ( ModelClassType Material Material Material Pointer )
            value.S_blitMaterial_NoChange                   = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0x40 S_blitMaterial_NoChange     ( ModelClassType Material Material Material Pointer )
            value.S_blitShader                              = GetObject<Shader>(new IntPtr(p + 0x048), ReversePrism.DataModels.Shader.FromPointer); // 0x48 S_blitShader                ( ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
