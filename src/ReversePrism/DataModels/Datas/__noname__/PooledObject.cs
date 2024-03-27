using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_ToReturn                               <var> IL2CPP_TYPE_VAR
    // 000 m_Pool                                   ObjectPool`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class PooledObject
    {

        public static PooledObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PooledObject();


            return value;
        }
    }
}
