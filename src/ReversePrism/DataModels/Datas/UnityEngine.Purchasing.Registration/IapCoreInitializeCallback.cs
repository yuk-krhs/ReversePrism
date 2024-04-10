using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_PurchasingPackageName                  string IL2CPP_TYPE_STRING
    public partial class IapCoreInitializeCallback : DataModel
    {

        public static IapCoreInitializeCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IapCoreInitializeCallback() { Pointer= p0 };


            return value;
        }
    }
}
