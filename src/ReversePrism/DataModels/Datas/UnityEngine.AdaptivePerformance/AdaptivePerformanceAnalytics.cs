using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_VendorKey                              string IL2CPP_TYPE_STRING
    // 000 k_MaxEventsPerHour                       int IL2CPP_TYPE_I4
    // 000 k_MaxNumberOfElementsInStruct            int IL2CPP_TYPE_I4
    // 000 s_AdaptivePerformanceEvent               AdaptivePerformanceAnalyticsEvent IL2CPP_TYPE_CLASS
    // 008 s_AdaptivePerformanceThermalEvent        AdaptivePerformanceThermalAnalyticsEvent IL2CPP_TYPE_VALUETYPE
    // 028 S_Features                               ModelEnumListType List`1<FeatureData> List`1<FeatureData> List<FeatureData> Pointer
    // 030 S_LastWarningLevel                       ModelEnumType WarningLevel WarningLevel WarningLevel Int32
    // 034 S_IsRegistered                           ModelPrimitiveType bool bool bool Bool
    public partial class AdaptivePerformanceAnalytics : DataModel
    {
        public List<FeatureData>?                       S_Features                              { get; set; }
        public WarningLevel                             S_LastWarningLevel                      { get; set; }
        public bool                                     S_IsRegistered                          { get; set; }

        public static AdaptivePerformanceAnalytics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceAnalytics() { Pointer= p0 };

            value.S_Features                                = GetEnumList<FeatureData>(new IntPtr(p + 0x028)); // 0x28 S_Features                  ( ModelEnumListType List`1<FeatureData> List`1<FeatureData> List<FeatureData> Pointer )
            value.S_LastWarningLevel                        = (WarningLevel)GetInt32(new IntPtr(p + 0x030)); // 0x30 S_LastWarningLevel          ( ModelEnumType WarningLevel WarningLevel WarningLevel Int32 )
            value.S_IsRegistered                            = GetBool(new IntPtr(p + 0x034)); // 0x34 S_IsRegistered              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
