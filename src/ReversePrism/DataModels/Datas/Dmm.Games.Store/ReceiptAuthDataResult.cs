using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DmmAccessToken                           0001866722E0 ModelPrimitiveType string string string String
    // 018 DmmOpenId                                0001866722E0 ModelPrimitiveType string string string String
    // 020 Error                                    0001865C8690 ModelClassType Error Error Error Pointer
    public partial class ReceiptAuthDataResult
    {
        public string                                   DmmAccessToken                          { get; set; }
        public string                                   DmmOpenId                               { get; set; }
        public Error?                                   Error                                   { get; set; }

        public static ReceiptAuthDataResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiptAuthDataResult();

            value.DmmAccessToken                            = GetString(new IntPtr(p + 0x010)); // 0270DB4821E0 0x10 DmmAccessToken              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DmmOpenId                                 = GetString(new IntPtr(p + 0x018)); // 0270DB482200 0x18 DmmOpenId                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x020), ReversePrism.DataModels.Error.FromPointer); // 0270DB482220 0x20 Error                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
