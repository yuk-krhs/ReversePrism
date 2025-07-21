using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType string string string String
    // 018 Name                                     ModelPrimitiveType string string string String
    public partial class NameValueHeaderValue : DataModel
    {
        public string                                   Value                                   { get; set; }
        public string                                   Name                                    { get; set; }

        public static NameValueHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameValueHeaderValue() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
