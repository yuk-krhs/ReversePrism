using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 Initialized                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 ActiveProvider                           0001866722E0 ModelPrimitiveType string string string String
    // 020 ProviderData                             000185CB5628 ModelEnumListType ProviderData[] ProviderData[] List<ProviderData> Pointer
    // 028 CtrlMode                                 0001866722E0 ModelPrimitiveType string string string String
    // 030 FeatureData                              000185CB5428 ModelEnumListType FeatureData[] FeatureData[] List<FeatureData> Pointer
    public partial class AdaptivePerformanceAnalyticsEvent : DataModel
    {
        public bool                                     Enabled                                 { get; set; }
        public bool                                     Initialized                             { get; set; }
        public string                                   ActiveProvider                          { get; set; }
        public List<ProviderData>?                      ProviderData                            { get; set; }
        public string                                   CtrlMode                                { get; set; }
        public List<FeatureData>?                       FeatureData                             { get; set; }

        public static AdaptivePerformanceAnalyticsEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceAnalyticsEvent() { Pointer= p0 };

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 024660912F38 0x10 Enabled                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Initialized                               = GetBool(new IntPtr(p + 0x011)); // 024660912F58 0x11 Initialized                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ActiveProvider                            = GetString(new IntPtr(p + 0x018)); // 024660912F78 0x18 ActiveProvider              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ProviderData                              = GetEnumList<ProviderData>(new IntPtr(p + 0x020)); // 024660912F98 0x20 ProviderData                ( 000185CB5628 ModelEnumListType ProviderData[] ProviderData[] List<ProviderData> Pointer )
            value.CtrlMode                                  = GetString(new IntPtr(p + 0x028)); // 024660912FB8 0x28 CtrlMode                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FeatureData                               = GetEnumList<FeatureData>(new IntPtr(p + 0x030)); // 024660912FD8 0x30 FeatureData                 ( 000185CB5428 ModelEnumListType FeatureData[] FeatureData[] List<FeatureData> Pointer )

            return value;
        }
    }
}
