using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidPurchaseStateClassName          string IL2CPP_TYPE_STRING
    public partial class GooglePurchaseStateEnum : DataModel
    {

        public static GooglePurchaseStateEnum? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePurchaseStateEnum() { Pointer= p0 };


            return value;
        }
    }
}
