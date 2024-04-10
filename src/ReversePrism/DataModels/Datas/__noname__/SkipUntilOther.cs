using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SkipUntilOuterObserver<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 sourceObserver                           SkipUntil<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 subscription                             IDisposable IL2CPP_TYPE_CLASS
    public partial class SkipUntilOther : DataModel
    {

        public static SkipUntilOther? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipUntilOther() { Pointer= p0 };


            return value;
        }
    }
}
