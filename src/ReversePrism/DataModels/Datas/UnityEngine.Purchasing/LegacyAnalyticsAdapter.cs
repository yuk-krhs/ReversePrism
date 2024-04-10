using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LegacyAnalytics                        00018658F220 ModelClassType ILegacyUnityAnalytics ILegacyUnityAnalytics ILegacyUnityAnalytics Pointer
    public partial class LegacyAnalyticsAdapter : DataModel
    {
        public ILegacyUnityAnalytics?                   M_LegacyAnalytics                       { get; set; }

        public static LegacyAnalyticsAdapter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyAnalyticsAdapter() { Pointer= p0 };

            value.M_LegacyAnalytics                         = GetObject<ILegacyUnityAnalytics>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILegacyUnityAnalytics.FromPointer); // 0245A68F0760 0x10 M_LegacyAnalytics           ( 00018658F220 ModelClassType ILegacyUnityAnalytics ILegacyUnityAnalytics ILegacyUnityAnalytics Pointer )

            return value;
        }
    }
}
