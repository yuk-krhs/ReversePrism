using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Payload                                  0001866722E0 ModelPrimitiveType string string string String
    // 018 Store                                    0001866722E0 ModelPrimitiveType string string string String
    // 020 TransactionID                            0001866722E0 ModelPrimitiveType string string string String
    public partial class UnifiedReceipt
    {
        public string                                   Payload                                 { get; set; }
        public string                                   Store                                   { get; set; }
        public string                                   TransactionID                           { get; set; }

        public static UnifiedReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnifiedReceipt();

            value.Payload                                   = GetString(new IntPtr(p + 0x010)); // 02700692F480 0x10 Payload                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Store                                     = GetString(new IntPtr(p + 0x018)); // 02700692F4A0 0x18 Store                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x020)); // 02700692F4C0 0x20 TransactionID               ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
