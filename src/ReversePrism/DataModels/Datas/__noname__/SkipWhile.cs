using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SkipWhileObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 endSkip                                  bool IL2CPP_TYPE_BOOLEAN
    public partial class SkipWhile : DataModel
    {

        public static SkipWhile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipWhile() { Pointer= p0 };


            return value;
        }
    }
}
