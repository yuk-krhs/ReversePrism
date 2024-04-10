using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Key                                      0001866722E0 ModelPrimitiveType string string string String
    // 018 Value                                    0001866722E0 ModelPrimitiveType string string string String
    public partial class Condition : DataModel
    {
        public string                                   Key                                     { get; set; }
        public string                                   Value                                   { get; set; }

        public static Condition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Condition() { Pointer= p0 };

            value.Key                                       = GetString(new IntPtr(p + 0x010)); // 024664DCCCF0 0x10 Key                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x018)); // 024664DCCD10 0x18 Value                       ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
