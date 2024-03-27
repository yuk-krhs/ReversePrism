using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Binder                                 000186604190 ModelClassType IPurchasingBinder IPurchasingBinder IPurchasingBinder Pointer
    public partial class AbstractPurchasingModule
    {
        public IPurchasingBinder?                       M_Binder                                { get; set; }

        public static AbstractPurchasingModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AbstractPurchasingModule();

            value.M_Binder                                  = GetObject<IPurchasingBinder>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPurchasingBinder.FromPointer); // 027004BA7F80 0x10 M_Binder                    ( 000186604190 ModelClassType IPurchasingBinder IPurchasingBinder IPurchasingBinder Pointer )

            return value;
        }
    }
}
