using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_userSerializationData                  000185B7A5B0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 M_instanceClaims                         000185CD2678 ModelClassListType List`1<Claim> List`1<Claim> List<Claim> Pointer
    // 020 m_externalClaims                         Collection`1<IEnumerable`1<Claim>> IL2CPP_TYPE_GENERICINST
    // 028 M_nameType                               0001866742E0 ModelPrimitiveType string string string String
    // 030 M_roleType                               0001866742E0 ModelPrimitiveType string string string String
    // 038 M_version                                000186671910 ModelPrimitiveType string string string String
    // 040 M_actor                                  0001865AEA70 ModelClassType ClaimsIdentity ClaimsIdentity ClaimsIdentity Pointer
    // 048 M_authenticationType                     000186671910 ModelPrimitiveType string string string String
    // 050 m_bootstrapContext                       <object> IL2CPP_TYPE_OBJECT
    // 058 M_label                                  000186671910 ModelPrimitiveType string string string String
    // 060 M_serializedNameType                     000186671910 ModelPrimitiveType string string string String
    // 068 M_serializedRoleType                     000186671910 ModelPrimitiveType string string string String
    // 070 M_serializedClaims                       000186671910 ModelPrimitiveType string string string String
    public partial class ClaimsIdentity : DataModel
    {
        public List<sbyte>?                             M_userSerializationData                 { get; set; }
        public List<Claim>?                             M_instanceClaims                        { get; set; }
        public string                                   M_nameType                              { get; set; }
        public string                                   M_roleType                              { get; set; }
        public string                                   M_version                               { get; set; }
        public ClaimsIdentity?                          M_actor                                 { get; set; }
        public string                                   M_authenticationType                    { get; set; }
        public string                                   M_label                                 { get; set; }
        public string                                   M_serializedNameType                    { get; set; }
        public string                                   M_serializedRoleType                    { get; set; }
        public string                                   M_serializedClaims                      { get; set; }

        public static ClaimsIdentity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClaimsIdentity() { Pointer= p0 };

            value.M_userSerializationData                   = GetSByteList(new IntPtr(p + 0x010)); // 0245A4D57FA8 0x10 M_userSerializationData     ( 000185B7A5B0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_instanceClaims                          = GetObjectList<Claim>(new IntPtr(p + 0x018), ReversePrism.DataModels.Claim.FromPointer); // 0245A4D57FC8 0x18 M_instanceClaims            ( 000185CD2678 ModelClassListType List`1<Claim> List`1<Claim> List<Claim> Pointer )
            value.M_nameType                                = GetString(new IntPtr(p + 0x028)); // 0245A4D58008 0x28 M_nameType                  ( 0001866742E0 ModelPrimitiveType string string string String )
            value.M_roleType                                = GetString(new IntPtr(p + 0x030)); // 0245A4D58028 0x30 M_roleType                  ( 0001866742E0 ModelPrimitiveType string string string String )
            value.M_version                                 = GetString(new IntPtr(p + 0x038)); // 0245A4D58048 0x38 M_version                   ( 000186671910 ModelPrimitiveType string string string String )
            value.M_actor                                   = GetObject<ClaimsIdentity>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClaimsIdentity.FromPointer); // 0245A4D58068 0x40 M_actor                     ( 0001865AEA70 ModelClassType ClaimsIdentity ClaimsIdentity ClaimsIdentity Pointer )
            value.M_authenticationType                      = GetString(new IntPtr(p + 0x048)); // 0245A4D58088 0x48 M_authenticationType        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_label                                   = GetString(new IntPtr(p + 0x058)); // 0245A4D580C8 0x58 M_label                     ( 000186671910 ModelPrimitiveType string string string String )
            value.M_serializedNameType                      = GetString(new IntPtr(p + 0x060)); // 0245A4D580E8 0x60 M_serializedNameType        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_serializedRoleType                      = GetString(new IntPtr(p + 0x068)); // 0245A4D58108 0x68 M_serializedRoleType        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_serializedClaims                        = GetString(new IntPtr(p + 0x070)); // 0245A4D58128 0x70 M_serializedClaims          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
