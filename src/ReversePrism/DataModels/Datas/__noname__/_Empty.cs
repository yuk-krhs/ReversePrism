using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 IUniTaskAsyncEnumerator`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class _Empty
    {

        public static _Empty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Empty();


            return value;
        }
    }
}
