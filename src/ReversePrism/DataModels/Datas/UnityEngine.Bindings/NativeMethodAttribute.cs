using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 IsThreadSafe                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 IsFreeFunction                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A ThrowsException                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01B HasExplicitThis                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NativeMethodAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     IsThreadSafe                            { get; set; }
        public bool                                     IsFreeFunction                          { get; set; }
        public bool                                     ThrowsException                         { get; set; }
        public bool                                     HasExplicitThis                         { get; set; }

        public static NativeMethodAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeMethodAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0245A692B938 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.IsThreadSafe                              = GetBool(new IntPtr(p + 0x018)); // 0245A692B958 0x18 IsThreadSafe                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFreeFunction                            = GetBool(new IntPtr(p + 0x019)); // 0245A692B978 0x19 IsFreeFunction              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ThrowsException                           = GetBool(new IntPtr(p + 0x01A)); // 0245A692B998 0x1A ThrowsException             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasExplicitThis                           = GetBool(new IntPtr(p + 0x01B)); // 0245A692B9B8 0x1B HasExplicitThis             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
