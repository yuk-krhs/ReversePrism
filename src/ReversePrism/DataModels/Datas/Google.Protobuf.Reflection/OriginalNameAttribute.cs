using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 PreferredAlias                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OriginalNameAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     PreferredAlias                          { get; set; }

        public static OriginalNameAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OriginalNameAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02466A6010D0 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.PreferredAlias                            = GetBool(new IntPtr(p + 0x018)); // 02466A6010F0 0x18 PreferredAlias              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
