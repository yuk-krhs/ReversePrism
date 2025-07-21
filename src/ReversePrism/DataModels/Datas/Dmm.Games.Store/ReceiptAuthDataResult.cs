using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DmmAccessToken                           ModelPrimitiveType string string string String
    // 018 DmmOpenId                                ModelPrimitiveType string string string String
    // 020 Error                                    ModelClassType Error Error Error Pointer
    public partial class ReceiptAuthDataResult : DataModel
    {
        public string                                   DmmAccessToken                          { get; set; }
        public string                                   DmmOpenId                               { get; set; }
        public Error?                                   Error                                   { get; set; }

        public static ReceiptAuthDataResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiptAuthDataResult() { Pointer= p0 };

            value.DmmAccessToken                            = GetString(new IntPtr(p + 0x010)); // 0x10 DmmAccessToken              ( ModelPrimitiveType string string string String )
            value.DmmOpenId                                 = GetString(new IntPtr(p + 0x018)); // 0x18 DmmOpenId                   ( ModelPrimitiveType string string string String )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x020), ReversePrism.DataModels.Error.FromPointer); // 0x20 Error                       ( ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
