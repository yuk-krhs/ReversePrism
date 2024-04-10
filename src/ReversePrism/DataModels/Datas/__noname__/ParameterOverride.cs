using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectRegistrationName                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Parameter                                0001866722E0 ModelPrimitiveType string string string String
    // 020 BindingMask                              0001865EA2C0 ModelEnumType InputBinding InputBinding InputBinding Int32
    // 078 Value                                    0001865149E0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    public partial class ParameterOverride : DataModel
    {
        public string                                   ObjectRegistrationName                  { get; set; }
        public string                                   Parameter                               { get; set; }
        public InputBinding                             BindingMask                             { get; set; }
        public PrimitiveValue                           Value                                   { get; set; }

        public static ParameterOverride? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterOverride() { Pointer= p0 };

            value.ObjectRegistrationName                    = GetString(new IntPtr(p + 0x010)); // 0246676B83B0 0x10 ObjectRegistrationName      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Parameter                                 = GetString(new IntPtr(p + 0x018)); // 0246676B83D0 0x18 Parameter                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.BindingMask                               = (InputBinding)GetInt32(new IntPtr(p + 0x020)); // 0246676B83F0 0x20 BindingMask                 ( 0001865EA2C0 ModelEnumType InputBinding InputBinding InputBinding Int32 )
            value.Value                                     = (PrimitiveValue)GetInt32(new IntPtr(p + 0x078)); // 0246676B8410 0x78 Value                       ( 0001865149E0 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )

            return value;
        }
    }
}
