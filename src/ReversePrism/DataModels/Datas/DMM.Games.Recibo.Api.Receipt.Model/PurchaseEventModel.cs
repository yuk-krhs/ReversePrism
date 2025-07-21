using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Store                                    ModelPrimitiveType string string string String
    // 018 TransactionId                            ModelPrimitiveType string string string String
    // 020 Payload                                  ModelPrimitiveType string string string String
    public partial class PurchaseEventModel : DataModel
    {
        public string                                   Store                                   { get; set; }
        public string                                   TransactionId                           { get; set; }
        public string                                   Payload                                 { get; set; }

        public static PurchaseEventModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseEventModel() { Pointer= p0 };

            value.Store                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Store                       ( ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x018)); // 0x18 TransactionId               ( ModelPrimitiveType string string string String )
            value.Payload                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Payload                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
