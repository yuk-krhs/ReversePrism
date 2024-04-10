using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 maxShaderPasses                          int IL2CPP_TYPE_I4
    // 010 M_SortingSettings                        00018666A380 ModelEnumType SortingSettings SortingSettings SortingSettings Int32
    // 070 ShaderPassNames                          0001865B7AA0 ModelEnumType <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer Int32
    // 0B0 M_PerObjectData                          00018672F130 ModelEnumType PerObjectData PerObjectData PerObjectData Int32
    // 0B4 M_Flags                                  0001866F9E30 ModelEnumType DrawRendererFlags DrawRendererFlags DrawRendererFlags Int32
    // 0B8 M_OverrideShaderID                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0BC M_OverrideShaderPassIndex                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C0 M_OverrideMaterialInstanceId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C4 M_OverrideMaterialPassIndex              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C8 M_fallbackMaterialInstanceId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0CC M_MainLightIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 M_UseSrpBatcher                          0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.M_SortingSettings                         = (SortingSettings)GetInt32(new IntPtr(p + 0x010)); // 024660F36F58 0x10 M_SortingSettings           ( 00018666A380 ModelEnumType SortingSettings SortingSettings SortingSettings Int32 )
            value.ShaderPassNames                           = (<shaderPassNames>e__FixedBuffer)GetInt32(new IntPtr(p + 0x070)); // 024660F36F78 0x70 ShaderPassNames             ( 0001865B7AA0 ModelEnumType <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer Int32 )
            value.M_PerObjectData                           = (PerObjectData)GetInt32(new IntPtr(p + 0x0B0)); // 024660F36F98 0xB0 M_PerObjectData             ( 00018672F130 ModelEnumType PerObjectData PerObjectData PerObjectData Int32 )
            value.M_Flags                                   = (DrawRendererFlags)GetInt32(new IntPtr(p + 0x0B4)); // 024660F36FB8 0xB4 M_Flags                     ( 0001866F9E30 ModelEnumType DrawRendererFlags DrawRendererFlags DrawRendererFlags Int32 )
            value.M_OverrideShaderID                        = GetInt32(new IntPtr(p + 0x0B8)); // 024660F36FD8 0xB8 M_OverrideShaderID          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OverrideShaderPassIndex                 = GetInt32(new IntPtr(p + 0x0BC)); // 024660F36FF8 0xBC M_OverrideShaderPassIndex   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OverrideMaterialInstanceId              = GetInt32(new IntPtr(p + 0x0C0)); // 024660F37018 0xC0 M_OverrideMaterialInstanceId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OverrideMaterialPassIndex               = GetInt32(new IntPtr(p + 0x0C4)); // 024660F37038 0xC4 M_OverrideMaterialPassIndex ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_fallbackMaterialInstanceId              = GetInt32(new IntPtr(p + 0x0C8)); // 024660F37058 0xC8 M_fallbackMaterialInstanceId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MainLightIndex                          = GetInt32(new IntPtr(p + 0x0CC)); // 024660F37078 0xCC M_MainLightIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_UseSrpBatcher                           = GetInt32(new IntPtr(p + 0x0D0)); // 024660F37098 0xD0 M_UseSrpBatcher             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
