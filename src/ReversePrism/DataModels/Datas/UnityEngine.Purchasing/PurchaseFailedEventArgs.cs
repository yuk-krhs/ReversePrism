using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchasedProduct                         00018659E6D0 ModelClassType Product Product Product Pointer
    // 018 Reason                                   0001865DBE10 ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32
    // 020 Message                                  000186671910 ModelPrimitiveType string string string String
    public partial class PurchaseFailedEventArgs
    {
        public Product?                                 PurchasedProduct                        { get; set; }
        public PurchaseFailureReason                    Reason                                  { get; set; }
        public string                                   Message                                 { get; set; }

        public static PurchaseFailedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseFailedEventArgs();

            value.PurchasedProduct                          = GetObject<Product>(new IntPtr(p + 0x010), ReversePrism.DataModels.Product.FromPointer); // 02700692EF80 0x10 PurchasedProduct            ( 00018659E6D0 ModelClassType Product Product Product Pointer )
            value.Reason                                    = (PurchaseFailureReason)GetInt32(new IntPtr(p + 0x018)); // 02700692EFA0 0x18 Reason                      ( 0001865DBE10 ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 02700692EFC0 0x20 Message                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
