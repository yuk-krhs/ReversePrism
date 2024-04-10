using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Category                                 string IL2CPP_TYPE_STRING
    public partial class PrivacyOptionMlKeyConst : DataModel
    {

        public static PrivacyOptionMlKeyConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionMlKeyConst() { Pointer= p0 };


            return value;
        }
    }
}
