using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidConsumeResponseListenerClassName string IL2CPP_TYPE_STRING
    // 020 m_OnConsumeResponse                      Action`1<IGoogleBillingResult> IL2CPP_TYPE_GENERICINST
    public partial class GoogleConsumeResponseListener : DataModel
    {

        public static GoogleConsumeResponseListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleConsumeResponseListener() { Pointer= p0 };


            return value;
        }
    }
}
