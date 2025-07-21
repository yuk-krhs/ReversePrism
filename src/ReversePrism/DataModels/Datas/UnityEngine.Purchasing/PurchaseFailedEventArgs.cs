using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchasedProduct                         ModelClassType Product Product Product Pointer
    // 018 Reason                                   ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32
    // 020 Message                                  ModelPrimitiveType string string string String
    public partial class PurchaseFailedEventArgs : DataModel
    {
        public Product?                                 PurchasedProduct                        { get; set; }
        public PurchaseFailureReason                    Reason                                  { get; set; }
        public string                                   Message                                 { get; set; }

        public static PurchaseFailedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchaseFailedEventArgs() { Pointer= p0 };

            value.PurchasedProduct                          = GetObject<Product>(new IntPtr(p + 0x010), ReversePrism.DataModels.Product.FromPointer); // 0x10 PurchasedProduct            ( ModelClassType Product Product Product Pointer )
            value.Reason                                    = (PurchaseFailureReason)GetInt32(new IntPtr(p + 0x018)); // 0x18 Reason                      ( ModelEnumType PurchaseFailureReason PurchaseFailureReason PurchaseFailureReason Int32 )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Message                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
