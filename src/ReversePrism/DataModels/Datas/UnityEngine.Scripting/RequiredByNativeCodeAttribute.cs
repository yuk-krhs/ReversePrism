using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Optional                                 ModelPrimitiveType bool bool bool Bool
    // 019 GenerateProxy                            ModelPrimitiveType bool bool bool Bool
    public partial class RequiredByNativeCodeAttribute : DataModel
    {
        public string                                   Name                                    { get; set; }
        public bool                                     Optional                                { get; set; }
        public bool                                     GenerateProxy                           { get; set; }

        public static RequiredByNativeCodeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequiredByNativeCodeAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Optional                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 Optional                    ( ModelPrimitiveType bool bool bool Bool )
            value.GenerateProxy                             = GetBool(new IntPtr(p + 0x019)); // 0x19 GenerateProxy               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
