using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 450 M_UpdateTextFromValue                    000186595210 ModelPrimitiveType bool bool bool Bool
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 labelUssClassName                        string IL2CPP_TYPE_STRING
    // 010 InputUssClassName                        000186674040 ModelPrimitiveType string string string String
    public partial class Hash128Field : DataModel
    {
        public bool                                     M_UpdateTextFromValue                   { get; set; }
        public string                                   InputUssClassName                       { get; set; }

        public static Hash128Field? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hash128Field() { Pointer= p0 };

            value.M_UpdateTextFromValue                     = GetBool(new IntPtr(p + 0x450)); // 0245A50C9980 0x450 M_UpdateTextFromValue       ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.InputUssClassName                         = GetString(new IntPtr(p + 0x010)); // 0245A50C99E0 0x10 InputUssClassName           ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
