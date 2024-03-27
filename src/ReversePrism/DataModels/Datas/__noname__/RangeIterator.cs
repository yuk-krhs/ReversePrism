using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 owner                                    DynamicArray`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 index                                    int IL2CPP_TYPE_I4
    // 000 first                                    int IL2CPP_TYPE_I4
    // 000 last                                     int IL2CPP_TYPE_I4
    public partial class RangeIterator
    {

        public static RangeIterator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeIterator();


            return value;
        }
    }
}
