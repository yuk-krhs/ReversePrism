using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Payload                                  ModelPrimitiveType string string string String
    // 018 Store                                    ModelPrimitiveType string string string String
    // 020 TransactionID                            ModelPrimitiveType string string string String
    public partial class UnifiedReceipt : DataModel
    {
        public string                                   Payload                                 { get; set; }
        public string                                   Store                                   { get; set; }
        public string                                   TransactionID                           { get; set; }

        public static UnifiedReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnifiedReceipt() { Pointer= p0 };

            value.Payload                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Payload                     ( ModelPrimitiveType string string string String )
            value.Store                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Store                       ( ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x020)); // 0x20 TransactionID               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
