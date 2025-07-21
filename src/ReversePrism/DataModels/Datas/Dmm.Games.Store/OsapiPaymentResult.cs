using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 ModelClassType PaymentResult PaymentResult PaymentResult Pointer
    // 048 Callback                                 ModelClassType Callback Callback Callback Pointer
    // 050 RequestCode                              ModelPrimitiveType int int int Int32
    public partial class OsapiPaymentResult : DataModel
    {
        public PaymentResult?                           Response                                { get; set; }
        public Callback?                                Callback                                { get; set; }
        public int                                      RequestCode                             { get; set; }

        public static OsapiPaymentResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiPaymentResult() { Pointer= p0 };

            value.Response                                  = GetObject<PaymentResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.PaymentResult.FromPointer); // 0x40 Response                    ( ModelClassType PaymentResult PaymentResult PaymentResult Pointer )
            value.Callback                                  = GetObject<Callback>(new IntPtr(p + 0x048), ReversePrism.DataModels.Callback.FromPointer); // 0x48 Callback                    ( ModelClassType Callback Callback Callback Pointer )
            value.RequestCode                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 RequestCode                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
