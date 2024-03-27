using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 018 M_Enabled                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C M_Scale                                  0001866656B0 ModelPrimitiveType float float float Single
    // 020 M_VisualImpact                           0001866C3340 ModelEnumType ScalerVisualImpact ScalerVisualImpact ScalerVisualImpact Int32
    // 024 M_Target                                 0001866C2BF0 ModelEnumType ScalerTarget ScalerTarget ScalerTarget Int32
    // 028 M_MaxLevel                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_MinBound                               0001866656B0 ModelPrimitiveType float float float Single
    // 030 M_MaxBound                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class AdaptivePerformanceScalerSettingsBase
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
            var value   = new AdaptivePerformanceScalerSettingsBase();

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0270032DADB0 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Enabled                                 = GetBool(new IntPtr(p + 0x018)); // 0270032DADD0 0x18 M_Enabled                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x01C)); // 0270032DADF0 0x1C M_Scale                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_VisualImpact                            = (ScalerVisualImpact)GetInt32(new IntPtr(p + 0x020)); // 0270032DAE10 0x20 M_VisualImpact              ( 0001866C3340 ModelEnumType ScalerVisualImpact ScalerVisualImpact ScalerVisualImpact Int32 )
            value.M_Target                                  = (ScalerTarget)GetInt32(new IntPtr(p + 0x024)); // 0270032DAE30 0x24 M_Target                    ( 0001866C2BF0 ModelEnumType ScalerTarget ScalerTarget ScalerTarget Int32 )
            value.M_MaxLevel                                = GetInt32(new IntPtr(p + 0x028)); // 0270032DAE50 0x28 M_MaxLevel                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MinBound                                = GetSingle(new IntPtr(p + 0x02C)); // 0270032DAE70 0x2C M_MinBound                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MaxBound                                = GetSingle(new IntPtr(p + 0x030)); // 0270032DAE90 0x30 M_MaxBound                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
