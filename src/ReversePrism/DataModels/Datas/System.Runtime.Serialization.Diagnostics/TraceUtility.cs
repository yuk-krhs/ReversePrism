using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 traceCodes                               Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    public partial class TraceUtility
    {

        public static TraceUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TraceUtility();


            return value;
        }
    }
}
