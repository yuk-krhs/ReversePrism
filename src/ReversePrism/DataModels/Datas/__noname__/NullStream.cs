using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_zeroTask                               Task`1<int> IL2CPP_TYPE_GENERICINST
    public partial class NullStream : DataModel
    {

        public static NullStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NullStream() { Pointer= p0 };


            return value;
        }
    }
}
