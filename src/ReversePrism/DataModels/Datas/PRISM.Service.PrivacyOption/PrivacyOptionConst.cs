using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UserNotExistText                         string IL2CPP_TYPE_STRING
    public partial class PrivacyOptionConst
    {

        public static PrivacyOptionConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionConst();


            return value;
        }
    }
}
