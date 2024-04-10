using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   FirstObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 notPublished                             bool IL2CPP_TYPE_BOOLEAN
    public partial class First : DataModel
    {

        public static First? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new First() { Pointer= p0 };


            return value;
        }
    }
}
