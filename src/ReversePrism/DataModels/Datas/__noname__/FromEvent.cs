using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   FromEventObservable_`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 observer                                 IObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 handler                                  Action`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class FromEvent
    {

        public static FromEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FromEvent();


            return value;
        }
    }
}
