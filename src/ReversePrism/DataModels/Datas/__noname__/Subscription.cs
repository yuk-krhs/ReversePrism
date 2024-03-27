using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   StackableSubject`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 unsubscribeTarget                        IObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class Subscription
    {

        public static Subscription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Subscription();


            return value;
        }
    }
}
