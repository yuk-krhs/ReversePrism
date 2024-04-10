using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Trusted                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 User_denied                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 Error_code                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 policy_errors                            Nullable`1<MonoSslPolicyErrors> IL2CPP_TYPE_GENERICINST
    public partial class ValidationResult : DataModel
    {
        public bool                                     Trusted                                 { get; set; }
        public bool                                     User_denied                             { get; set; }
        public int                                      Error_code                              { get; set; }

        public static ValidationResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValidationResult() { Pointer= p0 };

            value.Trusted                                   = GetBool(new IntPtr(p + 0x010)); // 02466797E1D8 0x10 Trusted                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.User_denied                               = GetBool(new IntPtr(p + 0x011)); // 02466797E1F8 0x11 User_denied                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Error_code                                = GetInt32(new IntPtr(p + 0x014)); // 02466797E218 0x14 Error_code                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
