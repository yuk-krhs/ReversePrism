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
    public partial class DrawingSettings
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
            var value   = new DrawingSettings();

            value.M_SortingSettings                         = (SortingSettings)GetInt32(new IntPtr(p + 0x010)); // 0270041B97E0 0x10 M_SortingSettings           ( 00018666A380 ModelEnumType SortingSettings SortingSettings SortingSettings Int32 )
            value.ShaderPassNames                           = (<shaderPassNames>e__FixedBuffer)GetInt32(new IntPtr(p + 0x070)); // 0270041B9800 0x70 ShaderPassNames             ( 0001865B7AA0 ModelEnumType <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer <shaderPassNames>e__FixedBuffer Int32 )
            value.M_PerObjectData                           = (PerObjectData)GetInt32(new IntPtr(p + 0x0B0)); // 0270041B9820 0xB0 M_PerObjectData             ( 00018672F130 ModelEnumType PerObjectData PerObjectData PerObjectData Int32 )
            value.M_Flags                                   = (DrawRendererFlags)GetInt32(new IntPtr(p + 0x0B4)); // 0270041B9840 0xB4 M_Flags                     ( 0001866F9E30 ModelEnumType DrawRendererFlags DrawRendererFlags DrawRendererFlags Int32 )
            value.M_OverrideShaderID                        = GetInt32(new IntPtr(p + 0x0B8)); // 0270041B9860 0xB8 M_OverrideShaderID          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OverrideShaderPassIndex                 = GetInt32(new IntPtr(p + 0x0BC)); // 0270041B9880 0xBC M_OverrideShaderPassIndex   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OverrideMaterialInstanceId              = GetInt32(new IntPtr(p + 0x0C0)); // 0270041B98A0 0xC0 M_OverrideMaterialInstanceId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OverrideMaterialPassIndex               = GetInt32(new IntPtr(p + 0x0C4)); // 0270041B98C0 0xC4 M_OverrideMaterialPassIndex ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_fallbackMaterialInstanceId              = GetInt32(new IntPtr(p + 0x0C8)); // 0270041B98E0 0xC8 M_fallbackMaterialInstanceId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MainLightIndex                          = GetInt32(new IntPtr(p + 0x0CC)); // 0270041B9900 0xCC M_MainLightIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_UseSrpBatcher                           = GetInt32(new IntPtr(p + 0x0D0)); // 0270041B9920 0xD0 M_UseSrpBatcher             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
