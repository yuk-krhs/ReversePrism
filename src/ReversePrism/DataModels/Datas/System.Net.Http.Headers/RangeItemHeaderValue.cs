using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <From>k__BackingField                    Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 020 <To>k__BackingField                      Nullable`1<long> IL2CPP_TYPE_GENERICINST
    public partial class RangeItemHeaderValue
    {

        public static RangeItemHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeItemHeaderValue();


            return value;
        }
    }
}
