using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyArray                               <var>[] IL2CPP_TYPE_SZARRAY
    // 000 parent                                   BufferObservable`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 list                                     List`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class Buffer
    {

        public static Buffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Buffer();


            return value;
        }
    }
}
