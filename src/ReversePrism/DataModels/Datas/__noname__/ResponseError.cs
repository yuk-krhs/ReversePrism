using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class ResponseError : DataModel
    {
        public string                                   Message                                 { get; set; }

        public static ResponseError? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseError() { Pointer= p0 };

            value.Message                                   = GetString(new IntPtr(p + 0x010)); // 02466BE60B88 0x10 Message                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
