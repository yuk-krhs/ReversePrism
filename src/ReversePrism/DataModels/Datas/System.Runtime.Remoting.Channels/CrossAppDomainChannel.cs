using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_lock                                   <object> IL2CPP_TYPE_OBJECT
    public partial class CrossAppDomainChannel
    {

        public static CrossAppDomainChannel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CrossAppDomainChannel();


            return value;
        }
    }
}
