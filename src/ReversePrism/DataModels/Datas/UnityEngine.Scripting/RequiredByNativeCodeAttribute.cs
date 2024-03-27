using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Optional                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 GenerateProxy                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RequiredByNativeCodeAttribute
    {
        public string                                   Name                                    { get; set; }
        public bool                                     Optional                                { get; set; }
        public bool                                     GenerateProxy                           { get; set; }

        public static RequiredByNativeCodeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiredByNativeCodeAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027006979C10 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Optional                                  = GetBool(new IntPtr(p + 0x018)); // 027006979C30 0x18 Optional                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GenerateProxy                             = GetBool(new IntPtr(p + 0x019)); // 027006979C50 0x19 GenerateProxy               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
