using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResponseCode                             ModelPrimitiveType string string string String
    // 018 PaymentId                                ModelPrimitiveType string string string String
    // 020 Cancel                                   ModelPrimitiveType bool bool bool Bool
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

            value.ResponseCode                              = GetString(new IntPtr(p + 0x010)); // 0x10 ResponseCode                ( ModelPrimitiveType string string string String )
            value.PaymentId                                 = GetString(new IntPtr(p + 0x018)); // 0x18 PaymentId                   ( ModelPrimitiveType string string string String )
            value.Cancel                                    = GetBool(new IntPtr(p + 0x020)); // 0x20 Cancel                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
