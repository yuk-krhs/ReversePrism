using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _arrays                                  <var>[][] IL2CPP_TYPE_SZARRAY
    // 000 _count                                   int IL2CPP_TYPE_I4
    // 000 _firstStackItemMS                        uint IL2CPP_TYPE_U4
    public partial class LockedStack
    {

        public static LockedStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LockedStack();


            return value;
        }
    }
}
