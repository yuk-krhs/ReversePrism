using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Json                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Signature                                0001866722E0 ModelPrimitiveType string string string String
    public partial class GoogleReceipt
    {
        public string                                   Json                                    { get; set; }
        public string                                   Signature                               { get; set; }

        public static GoogleReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleReceipt();

            value.Json                                      = GetString(new IntPtr(p + 0x010)); // 02700692E5A8 0x10 Json                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Signature                                 = GetString(new IntPtr(p + 0x018)); // 02700692E5C8 0x18 Signature                   ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
