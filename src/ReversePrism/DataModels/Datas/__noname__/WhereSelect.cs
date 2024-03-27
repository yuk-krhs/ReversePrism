using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   WhereSelectObservable`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    public partial class WhereSelect
    {

        public static WhereSelect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhereSelect();


            return value;
        }
    }
}
