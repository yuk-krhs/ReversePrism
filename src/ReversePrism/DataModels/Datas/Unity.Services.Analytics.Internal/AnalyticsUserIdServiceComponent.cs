using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AnalyticsService                       ModelClassType IAnalyticsService IAnalyticsService IAnalyticsService Pointer
    public partial class AnalyticsUserIdServiceComponent : DataModel
    {
        public IAnalyticsService?                       M_AnalyticsService                      { get; set; }

        public static AnalyticsUserIdServiceComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsUserIdServiceComponent() { Pointer= p0 };

            value.M_AnalyticsService                        = GetObject<IAnalyticsService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnalyticsService.FromPointer); // 0x10 M_AnalyticsService          ( ModelClassType IAnalyticsService IAnalyticsService IAnalyticsService Pointer )

            return value;
        }
    }
}
