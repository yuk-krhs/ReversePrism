using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CppModuleName                            ModelPrimitiveType string string string String
    // 018 CSharpClassName                          ModelPrimitiveType string string string String
    // 020 AlwaysEnable                             ModelPrimitiveType bool bool bool Bool
    public partial class EnableModuleParams : DataModel
    {
        public string                                   CppModuleName                           { get; set; }
        public string                                   CSharpClassName                         { get; set; }
        public bool                                     AlwaysEnable                            { get; set; }

        public static EnableModuleParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnableModuleParams() { Pointer= p0 };

            value.CppModuleName                             = GetString(new IntPtr(p + 0x010)); // 0x10 CppModuleName               ( ModelPrimitiveType string string string String )
            value.CSharpClassName                           = GetString(new IntPtr(p + 0x018)); // 0x18 CSharpClassName             ( ModelPrimitiveType string string string String )
            value.AlwaysEnable                              = GetBool(new IntPtr(p + 0x020)); // 0x20 AlwaysEnable                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
