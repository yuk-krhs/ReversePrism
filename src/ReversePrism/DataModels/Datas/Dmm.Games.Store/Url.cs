using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    0001866722E0 ModelPrimitiveType string string string String
    // 018 Type                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class Url : DataModel
    {
        public string                                   Value                                   { get; set; }
        public string                                   Type                                    { get; set; }

        public static Url? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Url() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 02466B53D650 0x10 Value                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 02466B53D670 0x18 Type                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
