using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransactionReceipt                       000186671910 ModelPrimitiveType string string string String
    // 018 TransactionReceiptSignature              000186671910 ModelPrimitiveType string string string String
    // 020 <transactionServer>k__BackingField       Nullable`1<TransactionServer> IL2CPP_TYPE_GENERICINST
    public partial class AnalyticsTransactionReceipt
    {
        public string                                   TransactionReceipt                      { get; set; }
        public string                                   TransactionReceiptSignature             { get; set; }

        public static AnalyticsTransactionReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnalyticsTransactionReceipt();

            value.TransactionReceipt                        = GetString(new IntPtr(p + 0x010)); // 02700692DCC8 0x10 TransactionReceipt          ( 000186671910 ModelPrimitiveType string string string String )
            value.TransactionReceiptSignature               = GetString(new IntPtr(p + 0x018)); // 02700692DCE8 0x18 TransactionReceiptSignature ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
