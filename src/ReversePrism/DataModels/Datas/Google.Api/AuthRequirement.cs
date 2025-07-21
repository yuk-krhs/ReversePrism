using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AuthRequirement> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProviderIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 ProviderId                               ModelPrimitiveType string string string String
    // 000 AudiencesFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Audiences                                ModelPrimitiveType string string string String
    public partial class AuthRequirement : DataModel
    {
        public string                                   ProviderId                              { get; set; }
        public string                                   Audiences                               { get; set; }

        public static AuthRequirement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthRequirement() { Pointer= p0 };

            value.ProviderId                                = GetString(new IntPtr(p + 0x018)); // 0x18 ProviderId                  ( ModelPrimitiveType string string string String )
            value.Audiences                                 = GetString(new IntPtr(p + 0x020)); // 0x20 Audiences                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
