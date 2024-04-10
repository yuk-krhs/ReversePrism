using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ja                                       0001866722E0 ModelPrimitiveType string string string String
    // 018 En                                       0001866722E0 ModelPrimitiveType string string string String
    public partial class URL : DataModel
    {
        public string                                   Ja                                      { get; set; }
        public string                                   En                                      { get; set; }

        public static URL? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new URL() { Pointer= p0 };

            value.Ja                                        = GetString(new IntPtr(p + 0x010)); // 0245A4E725E8 0x10 Ja                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.En                                        = GetString(new IntPtr(p + 0x018)); // 0245A4E72608 0x18 En                          ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
