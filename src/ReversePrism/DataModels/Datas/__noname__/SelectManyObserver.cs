using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SelectManyObserverWithIndex<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 sourceValue                              <var> IL2CPP_TYPE_VAR
    // 000 sourceIndex                              int IL2CPP_TYPE_I4
    // 000 cancel                                   IDisposable IL2CPP_TYPE_CLASS
    // 000 index                                    int IL2CPP_TYPE_I4
    public partial class SelectManyObserver
    {

        public static SelectManyObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectManyObserver();


            return value;
        }
    }
}
