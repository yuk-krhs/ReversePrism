using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 pool                                     Queue`1<Queue`1<<var>>> IL2CPP_TYPE_GENERICINST
    public partial class QueuePool
    {

        public static QueuePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueuePool();


            return value;
        }
    }
}
