using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _buckets                                 Node<<var>, <var>>[] IL2CPP_TYPE_SZARRAY
    // 000 _locks                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 000 _countPerLock                            int[] IL2CPP_TYPE_SZARRAY
    public partial class Tables
    {

        public static Tables? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tables();


            return value;
        }
    }
}
