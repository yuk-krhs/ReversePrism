using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Enabled                                ModelPrimitiveType bool bool bool Bool
    // 01C M_Scale                                  ModelPrimitiveType float float float Single
    // 020 M_VisualImpact                           ModelEnumType ScalerVisualImpact ScalerVisualImpact ScalerVisualImpact Int32
    // 024 M_Target                                 ModelEnumType ScalerTarget ScalerTarget ScalerTarget Int32
    // 028 M_MaxLevel                               ModelPrimitiveType int int int Int32
    // 02C M_MinBound                               ModelPrimitiveType float float float Single
    // 030 M_MaxBound                               ModelPrimitiveType float float float Single
    public partial class AdaptivePerformanceScalerSettingsBase : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public bool                                     M_Enabled                               { get; set; }
        public float                                    M_Scale                                 { get; set; }
        public ScalerVisualImpact                       M_VisualImpact                          { get; set; }
        public ScalerTarget                             M_Target                                { get; set; }
        public int                                      M_MaxLevel                              { get; set; }
        public float                                    M_MinBound                              { get; set; }
        public float                                    M_MaxBound                              { get; set; }

        public static AdaptivePerformanceScalerSettingsBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceScalerSettingsBase() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 M_Enabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_Scale                     ( ModelPrimitiveType float float float Single )
            value.M_VisualImpact                            = (ScalerVisualImpact)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_VisualImpact              ( ModelEnumType ScalerVisualImpact ScalerVisualImpact ScalerVisualImpact Int32 )
            value.M_Target                                  = (ScalerTarget)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_Target                    ( ModelEnumType ScalerTarget ScalerTarget ScalerTarget Int32 )
            value.M_MaxLevel                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_MaxLevel                  ( ModelPrimitiveType int int int Int32 )
            value.M_MinBound                                = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_MinBound                  ( ModelPrimitiveType float float float Single )
            value.M_MaxBound                                = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_MaxBound                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
