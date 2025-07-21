using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Json                                     ModelPrimitiveType string string string String
    // 018 Signature                                ModelPrimitiveType string string string String
    public partial class GoogleReceipt : DataModel
    {
        public string                                   Json                                    { get; set; }
        public string                                   Signature                               { get; set; }

        public static GoogleReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleReceipt() { Pointer= p0 };

            value.Json                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Json                        ( ModelPrimitiveType string string string String )
            value.Signature                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Signature                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
