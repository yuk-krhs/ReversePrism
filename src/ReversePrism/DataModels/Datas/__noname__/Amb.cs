using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 targetObserver                           IObserver`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 targetDisposable                         IDisposable IL2CPP_TYPE_CLASS
    public partial class Amb : DataModel
    {

        public static Amb? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Amb() { Pointer= p0 };


            return value;
        }
    }
}
