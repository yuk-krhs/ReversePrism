using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResponseCode                             0001866722E0 ModelPrimitiveType string string string String
    // 018 PaymentId                                0001866722E0 ModelPrimitiveType string string string String
    // 020 Cancel                                   000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class OpenTransactionDialogModel : DataModel
    {
        public string                                   ResponseCode                            { get; set; }
        public string                                   PaymentId                               { get; set; }
        public bool                                     Cancel                                  { get; set; }

        public static OpenTransactionDialogModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpenTransactionDialogModel() { Pointer= p0 };

            value.ResponseCode                              = GetString(new IntPtr(p + 0x010)); // 02466B535F48 0x10 ResponseCode                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PaymentId                                 = GetString(new IntPtr(p + 0x018)); // 02466B535F68 0x18 PaymentId                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Cancel                                    = GetBool(new IntPtr(p + 0x020)); // 02466B535F88 0x20 Cancel                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
