using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<OAuthRequirements> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CanonicalScopesFieldNumber               int IL2CPP_TYPE_I4
    // 018 CanonicalScopes                          000186671910 ModelPrimitiveType string string string String
    public partial class OAuthRequirements : DataModel
    {
        public string                                   CanonicalScopes                         { get; set; }

        public static OAuthRequirements? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OAuthRequirements() { Pointer= p0 };

            value.CanonicalScopes                           = GetString(new IntPtr(p + 0x018)); // 02466A792968 0x18 CanonicalScopes             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
