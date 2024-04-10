using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidPriceChangeConfirmationListenerClassName string IL2CPP_TYPE_STRING
    // 020 m_OnPriceChangeConfirmationResult        Action`1<IGoogleBillingResult> IL2CPP_TYPE_GENERICINST
    public partial class GooglePriceChangeConfirmationListener : DataModel
    {

        public static GooglePriceChangeConfirmationListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePriceChangeConfirmationListener() { Pointer= p0 };


            return value;
        }
    }
}
