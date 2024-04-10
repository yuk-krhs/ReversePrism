using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Date>k__BackingField                    Nullable`1<DateTimeOffset> IL2CPP_TYPE_GENERICINST
    // 028 <Delta>k__BackingField                   Nullable`1<TimeSpan> IL2CPP_TYPE_GENERICINST
    public partial class RetryConditionHeaderValue : DataModel
    {

        public static RetryConditionHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RetryConditionHeaderValue() { Pointer= p0 };


            return value;
        }
    }
}
