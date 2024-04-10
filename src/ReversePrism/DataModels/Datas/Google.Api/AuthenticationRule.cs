using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AuthenticationRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 000186671910 ModelPrimitiveType string string string String
    // 000 OauthFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Oauth                                    0001866C4630 ModelClassType OAuthRequirements OAuthRequirements OAuthRequirements Pointer
    // 000 AllowWithoutCredentialFieldNumber        int IL2CPP_TYPE_I4
    // 028 AllowWithoutCredential                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 RequirementsFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_requirements_codec             FieldCodec`1<AuthRequirement> IL2CPP_TYPE_GENERICINST
    // 030 Requirements                             000185CCF268 ModelClassListType RepeatedField`1<AuthRequirement> RepeatedField`1<AuthRequirement> List<AuthRequirement> Pointer
    public partial class AuthenticationRule : DataModel
    {
        public string                                   Selector                                { get; set; }
        public OAuthRequirements?                       Oauth                                   { get; set; }
        public bool                                     AllowWithoutCredential                  { get; set; }
        public List<AuthRequirement>?                   Requirements                            { get; set; }

        public static AuthenticationRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticationRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 02466A783DD8 0x18 Selector                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Oauth                                     = GetObject<OAuthRequirements>(new IntPtr(p + 0x020), ReversePrism.DataModels.OAuthRequirements.FromPointer); // 02466A783E18 0x20 Oauth                       ( 0001866C4630 ModelClassType OAuthRequirements OAuthRequirements OAuthRequirements Pointer )
            value.AllowWithoutCredential                    = GetBool(new IntPtr(p + 0x028)); // 02466A783E58 0x28 AllowWithoutCredential      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Requirements                              = GetObjectList<AuthRequirement>(new IntPtr(p + 0x030), ReversePrism.DataModels.AuthRequirement.FromPointer); // 02466A783EB8 0x30 Requirements                ( 000185CCF268 ModelClassListType RepeatedField`1<AuthRequirement> RepeatedField`1<AuthRequirement> List<AuthRequirement> Pointer )

            return value;
        }
    }
}
