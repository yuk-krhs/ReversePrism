using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AuthProvider> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdFieldNumber                            int IL2CPP_TYPE_I4
    // 018 Id                                       000186671910 ModelPrimitiveType string string string String
    // 000 IssuerFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Issuer                                   000186671910 ModelPrimitiveType string string string String
    // 000 JwksUriFieldNumber                       int IL2CPP_TYPE_I4
    // 028 JwksUri                                  000186671910 ModelPrimitiveType string string string String
    // 000 AudiencesFieldNumber                     int IL2CPP_TYPE_I4
    // 030 Audiences                                000186671910 ModelPrimitiveType string string string String
    // 000 AuthorizationUrlFieldNumber              int IL2CPP_TYPE_I4
    // 038 AuthorizationUrl                         000186671910 ModelPrimitiveType string string string String
    // 000 JwtLocationsFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_jwtLocations_codec             FieldCodec`1<JwtLocation> IL2CPP_TYPE_GENERICINST
    // 040 JwtLocations                             000185CE25B8 ModelClassListType RepeatedField`1<JwtLocation> RepeatedField`1<JwtLocation> List<JwtLocation> Pointer
    public partial class AuthProvider : DataModel
    {
        public string                                   Id                                      { get; set; }
        public string                                   Issuer                                  { get; set; }
        public string                                   JwksUri                                 { get; set; }
        public string                                   Audiences                               { get; set; }
        public string                                   AuthorizationUrl                        { get; set; }
        public List<JwtLocation>?                       JwtLocations                            { get; set; }

        public static AuthProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthProvider() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 02466A78ACB8 0x18 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Issuer                                    = GetString(new IntPtr(p + 0x020)); // 02466A78ACF8 0x20 Issuer                      ( 000186671910 ModelPrimitiveType string string string String )
            value.JwksUri                                   = GetString(new IntPtr(p + 0x028)); // 02466A78AD38 0x28 JwksUri                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Audiences                                 = GetString(new IntPtr(p + 0x030)); // 02466A78AD78 0x30 Audiences                   ( 000186671910 ModelPrimitiveType string string string String )
            value.AuthorizationUrl                          = GetString(new IntPtr(p + 0x038)); // 02466A78ADB8 0x38 AuthorizationUrl            ( 000186671910 ModelPrimitiveType string string string String )
            value.JwtLocations                              = GetObjectList<JwtLocation>(new IntPtr(p + 0x040), ReversePrism.DataModels.JwtLocation.FromPointer); // 02466A78AE18 0x40 JwtLocations                ( 000185CE25B8 ModelClassListType RepeatedField`1<JwtLocation> RepeatedField`1<JwtLocation> List<JwtLocation> Pointer )

            return value;
        }
    }
}
