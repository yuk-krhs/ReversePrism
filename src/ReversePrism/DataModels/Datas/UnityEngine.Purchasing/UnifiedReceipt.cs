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

            value.Payload                                   = GetString(new IntPtr(p + 0x010)); // 0245A68F2C68 0x10 Payload                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Store                                     = GetString(new IntPtr(p + 0x018)); // 0245A68F2C88 0x18 Store                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x020)); // 0245A68F2CA8 0x20 TransactionID               ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
