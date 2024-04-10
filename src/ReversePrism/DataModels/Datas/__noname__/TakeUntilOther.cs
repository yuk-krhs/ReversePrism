using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 sourceObserver                           TakeUntil<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 subscription                             IDisposable IL2CPP_TYPE_CLASS
    public partial class TakeUntilOther : DataModel
    {

        public static TakeUntilOther? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TakeUntilOther() { Pointer= p0 };


            return value;
        }
    }
}
