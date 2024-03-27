using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target_type                              000186692F60 ModelClassType Type Type Type Pointer
    // 018 Method_name                              0001866722E0 ModelPrimitiveType string string string String
    // 020 Curried_first_arg                        000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class DelegateData
    {
        public Type?                                    Target_type                             { get; set; }
        public string                                   Method_name                             { get; set; }
        public bool                                     Curried_first_arg                       { get; set; }

        public static DelegateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelegateData();

            value.Target_type                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027003DC63A0 0x10 Target_type                 ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Method_name                               = GetString(new IntPtr(p + 0x018)); // 027003DC63C0 0x18 Method_name                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Curried_first_arg                         = GetBool(new IntPtr(p + 0x020)); // 027003DC63E0 0x20 Curried_first_arg           ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
