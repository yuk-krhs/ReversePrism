using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RequestModel                             ModelEnumType RequestModel RequestModel RequestModel Int32
    public partial class GetProduct : DataModel
    {
        public RequestModel                             RequestModel                            { get; set; }

        public static GetProduct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduct() { Pointer= p0 };

            value.RequestModel                              = (RequestModel)GetInt32(new IntPtr(p + 0x038)); // 0x38 RequestModel                ( ModelEnumType RequestModel RequestModel RequestModel Int32 )

            return value;
        }
    }
}
