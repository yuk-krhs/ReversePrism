using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 OrderId                                  000186672F10 ModelPrimitiveType string string string String
    public partial class CancelOrder : DataModel
    {
        public string                                   OrderId                                 { get; set; }

        public static CancelOrder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancelOrder() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x038)); // 02466B4EFF40 0x38 OrderId                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
