using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_issuer                                 000186671910 ModelPrimitiveType string string string String
    // 018 M_originalIssuer                         000186671910 ModelPrimitiveType string string string String
    // 020 M_type                                   000186671910 ModelPrimitiveType string string string String
    // 028 M_value                                  000186671910 ModelPrimitiveType string string string String
    // 030 M_valueType                              000186671910 ModelPrimitiveType string string string String
    // 038 M_userSerializationData                  000185B7A5B0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 m_properties                             Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 048 m_propertyLock                           <object> IL2CPP_TYPE_OBJECT
    // 050 M_subject                                0001865AEF30 ModelClassType ClaimsIdentity ClaimsIdentity ClaimsIdentity Pointer
    public partial class Claim
    {
        public string                                   M_issuer                                { get; set; }
        public string                                   M_originalIssuer                        { get; set; }
        public string                                   M_type                                  { get; set; }
        public string                                   M_value                                 { get; set; }
        public string                                   M_valueType                             { get; set; }
        public List<sbyte>?                             M_userSerializationData                 { get; set; }
        public ClaimsIdentity?                          M_subject                               { get; set; }

        public static Claim? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Claim();

            value.M_issuer                                  = GetString(new IntPtr(p + 0x010)); // 027004D1E238 0x10 M_issuer                    ( 000186671910 ModelPrimitiveType string string string String )
            value.M_originalIssuer                          = GetString(new IntPtr(p + 0x018)); // 027004D1E258 0x18 M_originalIssuer            ( 000186671910 ModelPrimitiveType string string string String )
            value.M_type                                    = GetString(new IntPtr(p + 0x020)); // 027004D1E278 0x20 M_type                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_value                                   = GetString(new IntPtr(p + 0x028)); // 027004D1E298 0x28 M_value                     ( 000186671910 ModelPrimitiveType string string string String )
            value.M_valueType                               = GetString(new IntPtr(p + 0x030)); // 027004D1E2B8 0x30 M_valueType                 ( 000186671910 ModelPrimitiveType string string string String )
            value.M_userSerializationData                   = GetSByteList(new IntPtr(p + 0x038)); // 027004D1E2D8 0x38 M_userSerializationData     ( 000185B7A5B0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_subject                                 = GetObject<ClaimsIdentity>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClaimsIdentity.FromPointer); // 027004D1E338 0x50 M_subject                   ( 0001865AEF30 ModelClassType ClaimsIdentity ClaimsIdentity ClaimsIdentity Pointer )

            return value;
        }
    }
}
