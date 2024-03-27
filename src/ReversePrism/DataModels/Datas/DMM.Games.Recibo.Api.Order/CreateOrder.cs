using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RequestModel                             0001866683C0 ModelEnumType RequestModel RequestModel RequestModel Int32
    public partial class CreateOrder
    {
        public RequestModel                             RequestModel                            { get; set; }

        public static CreateOrder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateOrder();

            value.RequestModel                              = (RequestModel)GetInt32(new IntPtr(p + 0x038)); // 0270DB47B2F8 0x38 RequestModel                ( 0001866683C0 ModelEnumType RequestModel RequestModel RequestModel Int32 )

            return value;
        }
    }
}
