using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OrderId                                  000186671910 ModelPrimitiveType string string string String
    public partial class CreateRequestModel
    {
        public string                                   OrderId                                 { get; set; }

        public static CreateRequestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateRequestModel();

            value.OrderId                                   = GetString(new IntPtr(p + 0x010)); // 0270DB47A6A0 0x10 OrderId                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
