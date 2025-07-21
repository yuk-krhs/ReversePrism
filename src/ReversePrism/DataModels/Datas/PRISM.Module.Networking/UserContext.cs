using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 userId                                   string IL2CPP_TYPE_STRING
    // 008 loginToken                               string IL2CPP_TYPE_STRING
    // 010 Authorization                            ModelPrimitiveType string string string String
    // 010 UserLanguage                             ModelPrimitiveType string string string String
    // 018 UserCountry                              ModelPrimitiveType string string string String
    public partial class UserContext : DataModel
    {
        public string                                   Authorization                           { get; set; }
        public string                                   UserLanguage                            { get; set; }
        public string                                   UserCountry                             { get; set; }

        public static UserContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserContext() { Pointer= p0 };

            value.Authorization                             = GetString(new IntPtr(p + 0x010)); // 0x10 Authorization               ( ModelPrimitiveType string string string String )
            value.UserLanguage                              = GetString(new IntPtr(p + 0x010)); // 0x10 UserLanguage                ( ModelPrimitiveType string string string String )
            value.UserCountry                               = GetString(new IntPtr(p + 0x018)); // 0x18 UserCountry                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
