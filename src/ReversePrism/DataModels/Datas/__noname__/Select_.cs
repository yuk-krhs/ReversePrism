using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SelectObservable`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 index                                    int IL2CPP_TYPE_I4
    public partial class Select_
    {

        public static Select_? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Select_();


            return value;
        }
    }
}
