using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 PurchaseToken                            000186672F10 ModelPrimitiveType string string string String
    public partial class DeleteReceipt
    {
        public string                                   PurchaseToken                           { get; set; }

        public static DeleteReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteReceipt();

            value.PurchaseToken                             = GetString(new IntPtr(p + 0x038)); // 0270DB47AA28 0x38 PurchaseToken               ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
