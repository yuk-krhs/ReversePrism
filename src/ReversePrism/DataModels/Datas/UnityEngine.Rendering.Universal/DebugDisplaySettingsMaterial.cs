using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AlbedoDebugValidationPresetData        ModelEnumListType AlbedoDebugValidationPresetData[] AlbedoDebugValidationPresetData[] List<AlbedoDebugValidationPresetData> Pointer
    // 018 M_AlbedoValidationPreset                 ModelEnumType AlbedoDebugValidationPreset AlbedoDebugValidationPreset AlbedoDebugValidationPreset Int32
    // 01C AlbedoMinLuminance                       ModelPrimitiveType float float float Single
    // 020 AlbedoMaxLuminance                       ModelPrimitiveType float float float Single
    // 024 M_AlbedoHueTolerance                     ModelPrimitiveType float float float Single
    // 028 M_AlbedoSaturationTolerance              ModelPrimitiveType float float float Single
    // 02C AlbedoCompareColor                       ModelEnumType Color Color Color Int32
    // 03C MetallicMinValue                         ModelPrimitiveType float float float Single
    // 040 MetallicMaxValue                         ModelPrimitiveType float float float Single
    // 044 MaterialValidationMode                   ModelEnumType DebugMaterialValidationMode DebugMaterialValidationMode DebugMaterialValidationMode Int32
    // 048 MaterialDebugMode                        ModelEnumType DebugMaterialMode DebugMaterialMode DebugMaterialMode Int32
    // 04C VertexAttributeDebugMode                 ModelEnumType DebugVertexAttributeMode DebugVertexAttributeMode DebugVertexAttributeMode Int32
    public partial class DebugDisplaySettingsMaterial : DataModel
    {
        public List<AlbedoDebugValidationPresetData>?   M_AlbedoDebugValidationPresetData       { get; set; }
        public AlbedoDebugValidationPreset              M_AlbedoValidationPreset                { get; set; }
        public float                                    AlbedoMinLuminance                      { get; set; }
        public float                                    AlbedoMaxLuminance                      { get; set; }
        public float                                    M_AlbedoHueTolerance                    { get; set; }
        public float                                    M_AlbedoSaturationTolerance             { get; set; }
        public Color                                    AlbedoCompareColor                      { get; set; }
        public float                                    MetallicMinValue                        { get; set; }
        public float                                    MetallicMaxValue                        { get; set; }
        public DebugMaterialValidationMode              MaterialValidationMode                  { get; set; }
        public DebugMaterialMode                        MaterialDebugMode                       { get; set; }
        public DebugVertexAttributeMode                 VertexAttributeDebugMode                { get; set; }

        public static DebugDisplaySettingsMaterial? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugDisplaySettingsMaterial() { Pointer= p0 };

            value.M_AlbedoDebugValidationPresetData         = GetEnumList<AlbedoDebugValidationPresetData>(new IntPtr(p + 0x010)); // 0x10 M_AlbedoDebugValidationPresetData ( ModelEnumListType AlbedoDebugValidationPresetData[] AlbedoDebugValidationPresetData[] List<AlbedoDebugValidationPresetData> Pointer )
            value.M_AlbedoValidationPreset                  = (AlbedoDebugValidationPreset)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_AlbedoValidationPreset    ( ModelEnumType AlbedoDebugValidationPreset AlbedoDebugValidationPreset AlbedoDebugValidationPreset Int32 )
            value.AlbedoMinLuminance                        = GetSingle(new IntPtr(p + 0x01C)); // 0x1C AlbedoMinLuminance          ( ModelPrimitiveType float float float Single )
            value.AlbedoMaxLuminance                        = GetSingle(new IntPtr(p + 0x020)); // 0x20 AlbedoMaxLuminance          ( ModelPrimitiveType float float float Single )
            value.M_AlbedoHueTolerance                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_AlbedoHueTolerance        ( ModelPrimitiveType float float float Single )
            value.M_AlbedoSaturationTolerance               = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_AlbedoSaturationTolerance ( ModelPrimitiveType float float float Single )
            value.AlbedoCompareColor                        = (Color)GetInt32(new IntPtr(p + 0x02C)); // 0x2C AlbedoCompareColor          ( ModelEnumType Color Color Color Int32 )
            value.MetallicMinValue                          = GetSingle(new IntPtr(p + 0x03C)); // 0x3C MetallicMinValue            ( ModelPrimitiveType float float float Single )
            value.MetallicMaxValue                          = GetSingle(new IntPtr(p + 0x040)); // 0x40 MetallicMaxValue            ( ModelPrimitiveType float float float Single )
            value.MaterialValidationMode                    = (DebugMaterialValidationMode)GetInt32(new IntPtr(p + 0x044)); // 0x44 MaterialValidationMode      ( ModelEnumType DebugMaterialValidationMode DebugMaterialValidationMode DebugMaterialValidationMode Int32 )
            value.MaterialDebugMode                         = (DebugMaterialMode)GetInt32(new IntPtr(p + 0x048)); // 0x48 MaterialDebugMode           ( ModelEnumType DebugMaterialMode DebugMaterialMode DebugMaterialMode Int32 )
            value.VertexAttributeDebugMode                  = (DebugVertexAttributeMode)GetInt32(new IntPtr(p + 0x04C)); // 0x4C VertexAttributeDebugMode    ( ModelEnumType DebugVertexAttributeMode DebugVertexAttributeMode DebugVertexAttributeMode Int32 )

            return value;
        }
    }
}
