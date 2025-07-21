using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransactionReceipt                       ModelPrimitiveType string string string String
    // 018 TransactionReceiptSignature              ModelPrimitiveType string string string String
    // 020 <transactionServer>k__BackingField       Nullable`1<TransactionServer> IL2CPP_TYPE_GENERICINST
    public partial class AnalyticsTransactionReceipt : DataModel
    {
        public string                                   TransactionReceipt                      { get; set; }
        public string                                   TransactionReceiptSignature             { get; set; }

        public static AnalyticsTransactionReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsTransactionReceipt() { Pointer= p0 };

            value.TransactionReceipt                        = GetString(new IntPtr(p + 0x010)); // 0x10 TransactionReceipt          ( ModelPrimitiveType string string string String )
            value.TransactionReceiptSignature               = GetString(new IntPtr(p + 0x018)); // 0x18 TransactionReceiptSignature ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
