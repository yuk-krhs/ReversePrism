using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OrderId                                  ModelPrimitiveType string string string String
    public partial class CreateRequestModel : DataModel
    {
        public string                                   OrderId                                 { get; set; }

        public static CreateRequestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateRequestModel() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 OrderId                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
