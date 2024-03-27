using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Unity.Services.Core.Telemetry.Internal.IMetricsFactory.CommonTags>k__BackingField IReadOnlyDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class DisabledMetricsFactory
    {

        public static DisabledMetricsFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisabledMetricsFactory();


            return value;
        }
    }
}
