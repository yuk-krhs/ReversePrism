using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 data                                     Notification`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 node                                     LinkedListNode`1<SchedulableAction<<var>>> IL2CPP_TYPE_GENERICINST
    // 000 schedule                                 IDisposable IL2CPP_TYPE_CLASS
    public partial class SchedulableAction
    {

        public static SchedulableAction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchedulableAction();


            return value;
        }
    }
}
