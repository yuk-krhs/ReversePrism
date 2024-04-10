using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 m_OSSynchronizationContext               <object> IL2CPP_TYPE_OBJECT
    // 000 s_ContextCache                           ConditionalWeakTable`2<<object>, OSSpecificSynchronizationContext> IL2CPP_TYPE_GENERICINST
    public partial class OSSpecificSynchronizationContext : DataModel
    {

        public static OSSpecificSynchronizationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OSSpecificSynchronizationContext() { Pointer= p0 };


            return value;
        }
    }
}
