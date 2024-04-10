using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Success                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Error                                    0001865C8690 ModelClassType Error Error Error Pointer
    public partial class SendSpendEventResult : DataModel
    {
        public bool                                     Success                                 { get; set; }
        public Error?                                   Error                                   { get; set; }

        public static SendSpendEventResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SendSpendEventResult() { Pointer= p0 };

            value.Success                                   = GetBool(new IntPtr(p + 0x010)); // 02466B5306E0 0x10 Success                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Error                                     = GetObject<Error>(new IntPtr(p + 0x018), ReversePrism.DataModels.Error.FromPointer); // 02466B530700 0x18 Error                       ( 0001865C8690 ModelClassType Error Error Error Pointer )

            return value;
        }
    }
}
