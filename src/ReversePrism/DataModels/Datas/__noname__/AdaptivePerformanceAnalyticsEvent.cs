using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  ModelPrimitiveType bool bool bool Bool
    // 011 Initialized                              ModelPrimitiveType bool bool bool Bool
    // 018 ActiveProvider                           ModelPrimitiveType string string string String
    // 020 ProviderData                             ModelEnumListType ProviderData[] ProviderData[] List<ProviderData> Pointer
    // 028 CtrlMode                                 ModelPrimitiveType string string string String
    // 030 FeatureData                              ModelEnumListType FeatureData[] FeatureData[] List<FeatureData> Pointer
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

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 Enabled                     ( ModelPrimitiveType bool bool bool Bool )
            value.Initialized                               = GetBool(new IntPtr(p + 0x011)); // 0x11 Initialized                 ( ModelPrimitiveType bool bool bool Bool )
            value.ActiveProvider                            = GetString(new IntPtr(p + 0x018)); // 0x18 ActiveProvider              ( ModelPrimitiveType string string string String )
            value.ProviderData                              = GetEnumList<ProviderData>(new IntPtr(p + 0x020)); // 0x20 ProviderData                ( ModelEnumListType ProviderData[] ProviderData[] List<ProviderData> Pointer )
            value.CtrlMode                                  = GetString(new IntPtr(p + 0x028)); // 0x28 CtrlMode                    ( ModelPrimitiveType string string string String )
            value.FeatureData                               = GetEnumList<FeatureData>(new IntPtr(p + 0x030)); // 0x30 FeatureData                 ( ModelEnumListType FeatureData[] FeatureData[] List<FeatureData> Pointer )

            return value;
        }
    }
}
