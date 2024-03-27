using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   0001866E2620 ModelEnumType OpenTransactionDialogResult OpenTransactionDialogResult OpenTransactionDialogResult Int32
    // 018 PaymentId                                0001866722E0 ModelPrimitiveType string string string String
    // 020 Error                                    0001865C8690 ModelClassType Error Error Error Pointer
    public partial class OpenTransactionDialogData
    {
        public OpenTransactionDialogResult              Status                                  { get; set; }
        public string                                   PaymentId                               { get; set; }
        public Error?                                   Error                                   { get; set; }

        public static OpenTransactionDialogData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpenTransactionDialogData();

            value.Status                                    = (OpenTransactionDialogResult)GetInt32(new IntPtr(p + 0x010)); // 0270DB49B080 0x10 Status                      ( 0001866E2620 ModelEnumType OpenTransactionDialogResult OpenTransactionDialogResult OpenTransactionDialogResult Int32 )
            value.PaymentId                                 = GetString(new IntPtr(p + 0x018)); // 0270DB49B0A0 0x18 PaymentId                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x020), ReversePrism.DataModels.Error.FromPointer); // 0270DB49B0C0 0x20 Error                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
