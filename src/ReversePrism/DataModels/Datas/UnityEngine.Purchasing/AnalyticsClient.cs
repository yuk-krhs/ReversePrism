using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Analytics                              0001866F1E60 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer
    // 018 M_LegacyAnalytics                        0001866F1E60 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer
    public partial class AnalyticsClient : DataModel
    {
        public IAnalyticsAdapter?                       M_Analytics                             { get; set; }
        public IAnalyticsAdapter?                       M_LegacyAnalytics                       { get; set; }

        public static AnalyticsClient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsClient() { Pointer= p0 };

            value.M_Analytics                               = GetObject<IAnalyticsAdapter>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnalyticsAdapter.FromPointer); // 0245A4C17780 0x10 M_Analytics                 ( 0001866F1E60 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer )
            value.M_LegacyAnalytics                         = GetObject<IAnalyticsAdapter>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAnalyticsAdapter.FromPointer); // 0245A4C177A0 0x18 M_LegacyAnalytics           ( 0001866F1E60 ModelClassType IAnalyticsAdapter IAnalyticsAdapter IAnalyticsAdapter Pointer )

            return value;
        }
    }
}
