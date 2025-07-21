using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target_type                              ModelClassType Type Type Type Pointer
    // 018 Method_name                              ModelPrimitiveType string string string String
    // 020 Curried_first_arg                        ModelPrimitiveType bool bool bool Bool
    public partial class DelegateData : DataModel
    {
        public Type?                                    Target_type                             { get; set; }
        public string                                   Method_name                             { get; set; }
        public bool                                     Curried_first_arg                       { get; set; }

        public static DelegateData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DelegateData() { Pointer= p0 };

            value.Target_type                               = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Target_type                 ( ModelClassType Type Type Type Pointer )
            value.Method_name                               = GetString(new IntPtr(p + 0x018)); // 0x18 Method_name                 ( ModelPrimitiveType string string string String )
            value.Curried_first_arg                         = GetBool(new IntPtr(p + 0x020)); // 0x20 Curried_first_arg           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
