using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Authentication> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RulesFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _repeated_rules_codec                    FieldCodec`1<AuthenticationRule> IL2CPP_TYPE_GENERICINST
    // 018 Rules                                    ModelClassListType RepeatedField`1<AuthenticationRule> RepeatedField`1<AuthenticationRule> List<AuthenticationRule> Pointer
    // 000 ProvidersFieldNumber                     int IL2CPP_TYPE_I4
    // 010 _repeated_providers_codec                FieldCodec`1<AuthProvider> IL2CPP_TYPE_GENERICINST
    // 020 Providers                                ModelClassListType RepeatedField`1<AuthProvider> RepeatedField`1<AuthProvider> List<AuthProvider> Pointer
    public partial class Authentication : DataModel
    {
        public List<AuthenticationRule>?                Rules                                   { get; set; }
        public List<AuthProvider>?                      Providers                               { get; set; }

        public static Authentication? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Authentication() { Pointer= p0 };

            value.Rules                                     = GetObjectList<AuthenticationRule>(new IntPtr(p + 0x018), ReversePrism.DataModels.AuthenticationRule.FromPointer); // 0x18 Rules                       ( ModelClassListType RepeatedField`1<AuthenticationRule> RepeatedField`1<AuthenticationRule> List<AuthenticationRule> Pointer )
            value.Providers                                 = GetObjectList<AuthProvider>(new IntPtr(p + 0x020), ReversePrism.DataModels.AuthProvider.FromPointer); // 0x20 Providers                   ( ModelClassListType RepeatedField`1<AuthProvider> RepeatedField`1<AuthProvider> List<AuthProvider> Pointer )

            return value;
        }
    }
}
