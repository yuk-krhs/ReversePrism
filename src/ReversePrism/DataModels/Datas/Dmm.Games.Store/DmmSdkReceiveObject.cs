using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _callbackInitialize                      Action`1<InitializeData> IL2CPP_TYPE_GENERICINST
    // 008 _callbackPayment                         Action`1<OpenTransactionDialogData> IL2CPP_TYPE_GENERICINST
    // 010 PaymentId                                000186672530 ModelPrimitiveType string string string String
    public partial class DmmSdkReceiveObject : DataModel
    {
        public string                                   PaymentId                               { get; set; }

        public static DmmSdkReceiveObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmSdkReceiveObject() { Pointer= p0 };

            value.PaymentId                                 = GetString(new IntPtr(p + 0x010)); // 02466B511A78 0x10 PaymentId                   ( 000186672530 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
