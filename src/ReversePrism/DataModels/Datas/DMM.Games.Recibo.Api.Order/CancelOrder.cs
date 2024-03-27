using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 OrderId                                  000186672F10 ModelPrimitiveType string string string String
    public partial class CancelOrder
    {
        public string                                   OrderId                                 { get; set; }

        public static CancelOrder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancelOrder();

            value.OrderId                                   = GetString(new IntPtr(p + 0x038)); // 0270DB47B0C8 0x38 OrderId                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
