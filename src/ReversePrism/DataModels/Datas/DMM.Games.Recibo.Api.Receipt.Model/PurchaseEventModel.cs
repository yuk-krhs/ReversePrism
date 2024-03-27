using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Store                                    000186671910 ModelPrimitiveType string string string String
    // 018 TransactionId                            000186671910 ModelPrimitiveType string string string String
    // 020 Payload                                  000186671910 ModelPrimitiveType string string string String
    public partial class PurchaseEventModel
    {
        public string                                   Store                                   { get; set; }
        public string                                   TransactionId                           { get; set; }
        public string                                   Payload                                 { get; set; }

        public static PurchaseEventModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseEventModel();

            value.Store                                     = GetString(new IntPtr(p + 0x010)); // 0270DB47AC58 0x10 Store                       ( 000186671910 ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x018)); // 0270DB47AC78 0x18 TransactionId               ( 000186671910 ModelPrimitiveType string string string String )
            value.Payload                                   = GetString(new IntPtr(p + 0x020)); // 0270DB47AC98 0x20 Payload                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
