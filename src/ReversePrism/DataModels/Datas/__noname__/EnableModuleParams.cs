using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CppModuleName                            000186671910 ModelPrimitiveType string string string String
    // 018 CSharpClassName                          000186671910 ModelPrimitiveType string string string String
    // 020 AlwaysEnable                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EnableModuleParams
    {
        public string                                   CppModuleName                           { get; set; }
        public string                                   CSharpClassName                         { get; set; }
        public bool                                     AlwaysEnable                            { get; set; }

        public static EnableModuleParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnableModuleParams();

            value.CppModuleName                             = GetString(new IntPtr(p + 0x010)); // 0270DB76D5D8 0x10 CppModuleName               ( 000186671910 ModelPrimitiveType string string string String )
            value.CSharpClassName                           = GetString(new IntPtr(p + 0x018)); // 0270DB76D5F8 0x18 CSharpClassName             ( 000186671910 ModelPrimitiveType string string string String )
            value.AlwaysEnable                              = GetBool(new IntPtr(p + 0x020)); // 0270DB76D618 0x20 AlwaysEnable                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
