using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidSkuDetailsResponseListenerClassName string IL2CPP_TYPE_STRING
    // 020 m_OnQueryPurchasesResponse               Action`2<IGoogleBillingResult, IEnumerable`1<IAndroidJavaObjectWrapper>> IL2CPP_TYPE_GENERICINST
    public partial class GooglePurchasesResponseListener : DataModel
    {

        public static GooglePurchasesResponseListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePurchasesResponseListener() { Pointer= p0 };


            return value;
        }
    }
}
