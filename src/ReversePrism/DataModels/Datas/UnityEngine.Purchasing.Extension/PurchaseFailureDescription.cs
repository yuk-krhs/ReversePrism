using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductId                                000186671910 ModelPrimitiveType string string string String
    // 018 Reason                                   0001865DBE10 ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32
    // 020 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class PurchaseFailureDescription
    {
        public string                                   ProductId                               { get; set; }
        public PurchaseFailureReason                    Reason                                  { get; set; }
        public string                                   Message                                 { get; set; }

        public static PurchaseFailureDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseFailureDescription();

            value.ProductId                                 = GetString(new IntPtr(p + 0x010)); // 027006930FD0 0x10 ProductId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Reason                                    = (PurchaseFailureReason)GetInt32(new IntPtr(p + 0x018)); // 027006930FF0 0x18 Reason                      ( 0001865DBE10 ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 027006931010 0x20 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
