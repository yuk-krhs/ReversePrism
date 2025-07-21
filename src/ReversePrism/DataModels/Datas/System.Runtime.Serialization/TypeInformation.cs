using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FullTypeName                             ModelPrimitiveType string string string String
    // 018 AssemblyString                           ModelPrimitiveType string string string String
    // 020 HasTypeForwardedFrom                     ModelPrimitiveType bool bool bool Bool
    public partial class TypeInformation : DataModel
    {
        public string                                   FullTypeName                            { get; set; }
        public string                                   AssemblyString                          { get; set; }
        public bool                                     HasTypeForwardedFrom                    { get; set; }

        public static TypeInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInformation() { Pointer= p0 };

            value.FullTypeName                              = GetString(new IntPtr(p + 0x010)); // 0x10 FullTypeName                ( ModelPrimitiveType string string string String )
            value.AssemblyString                            = GetString(new IntPtr(p + 0x018)); // 0x18 AssemblyString              ( ModelPrimitiveType string string string String )
            value.HasTypeForwardedFrom                      = GetBool(new IntPtr(p + 0x020)); // 0x20 HasTypeForwardedFrom        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
