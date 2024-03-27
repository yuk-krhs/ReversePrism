using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FullTypeName                             000186671910 ModelPrimitiveType string string string String
    // 018 AssemblyString                           000186671910 ModelPrimitiveType string string string String
    // 020 HasTypeForwardedFrom                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TypeInformation
    {
        public string                                   FullTypeName                            { get; set; }
        public string                                   AssemblyString                          { get; set; }
        public bool                                     HasTypeForwardedFrom                    { get; set; }

        public static TypeInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInformation();

            value.FullTypeName                              = GetString(new IntPtr(p + 0x010)); // 0270D7D40158 0x10 FullTypeName                ( 000186671910 ModelPrimitiveType string string string String )
            value.AssemblyString                            = GetString(new IntPtr(p + 0x018)); // 0270D7D40178 0x18 AssemblyString              ( 000186671910 ModelPrimitiveType string string string String )
            value.HasTypeForwardedFrom                      = GetBool(new IntPtr(p + 0x020)); // 0270D7D40198 0x20 HasTypeForwardedFrom        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
