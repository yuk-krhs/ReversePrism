using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Formatted                                ModelPrimitiveType string string string String
    public partial class Address : DataModel
    {
        public string                                   Formatted                               { get; set; }

        public static Address? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Address() { Pointer= p0 };

            value.Formatted                                 = GetString(new IntPtr(p + 0x010)); // 0x10 Formatted                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
