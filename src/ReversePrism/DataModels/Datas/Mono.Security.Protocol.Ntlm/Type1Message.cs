using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Host                                     000186671910 ModelPrimitiveType string string string String
    // 020 Domain                                   000186671910 ModelPrimitiveType string string string String
    public partial class Type1Message : DataModel
    {
        public string                                   Host                                    { get; set; }
        public string                                   Domain                                  { get; set; }

        public static Type1Message? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Type1Message() { Pointer= p0 };

            value.Host                                      = GetString(new IntPtr(p + 0x018)); // 02466B40D200 0x18 Host                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Domain                                    = GetString(new IntPtr(p + 0x020)); // 02466B40D220 0x20 Domain                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
