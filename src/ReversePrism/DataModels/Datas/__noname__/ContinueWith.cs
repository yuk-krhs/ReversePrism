using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   ContinueWithObservable`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 serialDisposable                         SerialDisposable IL2CPP_TYPE_CLASS
    // 000 seenValue                                bool IL2CPP_TYPE_BOOLEAN
    // 000 lastValue                                <var> IL2CPP_TYPE_VAR
    public partial class ContinueWith : DataModel
    {

        public static ContinueWith? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContinueWith() { Pointer= p0 };


            return value;
        }
    }
}
