using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 sessionStateChanged                      SessionStateChanged IL2CPP_TYPE_CLASS
    // 008 identityTokenChanged                     IdentityTokenChanged IL2CPP_TYPE_CLASS
    public partial class AnalyticsSessionInfo : DataModel
    {

        public static AnalyticsSessionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsSessionInfo() { Pointer= p0 };


            return value;
        }
    }
}
