using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 maxShaderPasses                          int IL2CPP_TYPE_I4
    // 010 M_SortingSettings                        ModelEnumType SortingSettings SortingSettings SortingSettings Int32
    // 070 ShaderPassNames                          ModelEnumType <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer Int32
    // 0B0 M_PerObjectData                          ModelEnumType PerObjectData PerObjectData PerObjectData Int32
    // 0B4 M_Flags                                  ModelEnumType DrawRendererFlags DrawRendererFlags DrawRendererFlags Int32
    // 0B8 M_OverrideShaderID                       ModelPrimitiveType int int int Int32
    // 0BC M_OverrideShaderPassIndex                ModelPrimitiveType int int int Int32
    // 0C0 M_OverrideMaterialInstanceId             ModelPrimitiveType int int int Int32
    // 0C4 M_OverrideMaterialPassIndex              ModelPrimitiveType int int int Int32
    // 0C8 M_fallbackMaterialInstanceId             ModelPrimitiveType int int int Int32
    // 0CC M_MainLightIndex                         ModelPrimitiveType int int int Int32
    // 0D0 M_UseSrpBatcher                          ModelPrimitiveType int int int Int32
    public partial class DrawingSettings : DataModel
    {
        public SortingSettings                          M_SortingSettings                       { get; set; }
        public <shaderPassNames>e__FixedBuffer          ShaderPassNames                         { get; set; }
        public PerObjectData                            M_PerObjectData                         { get; set; }
        public DrawRendererFlags                        M_Flags                                 { get; set; }
        public int                                      M_OverrideShaderID                      { get; set; }
        public int                                      M_OverrideShaderPassIndex               { get; set; }
        public int                                      M_OverrideMaterialInstanceId            { get; set; }
        public int                                      M_OverrideMaterialPassIndex             { get; set; }
        public int                                      M_fallbackMaterialInstanceId            { get; set; }
        public int                                      M_MainLightIndex                        { get; set; }
        public int                                      M_UseSrpBatcher                         { get; set; }

        public static DrawingSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawingSettings() { Pointer= p0 };

            value.M_SortingSettings                         = (SortingSettings)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_SortingSettings           ( ModelEnumType SortingSettings SortingSettings SortingSettings Int32 )
            value.ShaderPassNames                           = (<shaderPassNames>e__FixedBuffer)GetInt32(new IntPtr(p + 0x070)); // 0x70 ShaderPassNames             ( ModelEnumType <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer Int32 )
            value.M_PerObjectData                           = (PerObjectData)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_PerObjectData             ( ModelEnumType PerObjectData PerObjectData PerObjectData Int32 )
            value.M_Flags                                   = (DrawRendererFlags)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 M_Flags                     ( ModelEnumType DrawRendererFlags DrawRendererFlags DrawRendererFlags Int32 )
            value.M_OverrideShaderID                        = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_OverrideShaderID          ( ModelPrimitiveType int int int Int32 )
            value.M_OverrideShaderPassIndex                 = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC M_OverrideShaderPassIndex   ( ModelPrimitiveType int int int Int32 )
            value.M_OverrideMaterialInstanceId              = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 M_OverrideMaterialInstanceId ( ModelPrimitiveType int int int Int32 )
            value.M_OverrideMaterialPassIndex               = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 M_OverrideMaterialPassIndex ( ModelPrimitiveType int int int Int32 )
            value.M_fallbackMaterialInstanceId              = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_fallbackMaterialInstanceId ( ModelPrimitiveType int int int Int32 )
            value.M_MainLightIndex                          = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC M_MainLightIndex            ( ModelPrimitiveType int int int Int32 )
            value.M_UseSrpBatcher                           = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 M_UseSrpBatcher             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
