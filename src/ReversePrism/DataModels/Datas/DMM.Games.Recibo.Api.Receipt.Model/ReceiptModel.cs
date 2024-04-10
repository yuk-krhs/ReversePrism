using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InappPurchaseData                        000186671910 ModelPrimitiveType string string string String
    // 018 <ReceiptInfo>k__BackingField             Nullable`1<ReceiptInfo> IL2CPP_TYPE_GENERICINST
    // 068 InappDataSignature                       000186671910 ModelPrimitiveType string string string String
    public partial class ReceiptModel : DataModel
    {
        public string                                   InappPurchaseData                       { get; set; }
        public string                                   InappDataSignature                      { get; set; }

        public static ReceiptModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiptModel() { Pointer= p0 };

            value.InappPurchaseData                         = GetString(new IntPtr(p + 0x010)); // 0245A4BFF090 0x10 InappPurchaseData           ( 000186671910 ModelPrimitiveType string string string String )
            value.InappDataSignature                        = GetString(new IntPtr(p + 0x068)); // 0245A4BFF0D0 0x68 InappDataSignature          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
