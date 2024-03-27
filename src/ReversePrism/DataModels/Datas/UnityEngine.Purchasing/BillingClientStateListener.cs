using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_AndroidBillingClientStateListenerClassName string IL2CPP_TYPE_STRING
    // 020 M_OnConnected                            0001866792B0 ModelClassType Action Action Action Pointer
    // 028 m_Disconnect                             Action`1<GoogleBillingResponseCode> IL2CPP_TYPE_GENERICINST
    public partial class BillingClientStateListener
    {
        public Action?                                  M_OnConnected                           { get; set; }

        public static BillingClientStateListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BillingClientStateListener();

            value.M_OnConnected                             = GetObject<Action>(new IntPtr(p + 0x020), ReversePrism.DataModels.Action.FromPointer); // 0270069054F0 0x20 M_OnConnected               ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
