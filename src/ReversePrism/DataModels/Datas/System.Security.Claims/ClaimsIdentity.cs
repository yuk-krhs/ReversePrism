using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_userSerializationData                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 M_instanceClaims                         ModelClassListType List`1<Claim> List`1<Claim> List<Claim> Pointer
    // 020 m_externalClaims                         Collection`1<IEnumerable`1<Claim>> IL2CPP_TYPE_GENERICINST
    // 028 M_nameType                               ModelPrimitiveType string string string String
    // 030 M_roleType                               ModelPrimitiveType string string string String
    // 038 M_version                                ModelPrimitiveType string string string String
    // 040 M_actor                                  ModelClassType ClaimsIdentity ClaimsIdentity ClaimsIdentity Pointer
    // 048 M_authenticationType                     ModelPrimitiveType string string string String
    // 050 m_bootstrapContext                       <object> IL2CPP_TYPE_OBJECT
    // 058 M_label                                  ModelPrimitiveType string string string String
    // 060 M_serializedNameType                     ModelPrimitiveType string string string String
    // 068 M_serializedRoleType                     ModelPrimitiveType string string string String
    // 070 M_serializedClaims                       ModelPrimitiveType string string string String
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

            value.M_userSerializationData                   = GetSByteList(new IntPtr(p + 0x010)); // 0x10 M_userSerializationData     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_instanceClaims                          = GetObjectList<Claim>(new IntPtr(p + 0x018), ReversePrism.DataModels.Claim.FromPointer); // 0x18 M_instanceClaims            ( ModelClassListType List`1<Claim> List`1<Claim> List<Claim> Pointer )
            value.M_nameType                                = GetString(new IntPtr(p + 0x028)); // 0x28 M_nameType                  ( ModelPrimitiveType string string string String )
            value.M_roleType                                = GetString(new IntPtr(p + 0x030)); // 0x30 M_roleType                  ( ModelPrimitiveType string string string String )
            value.M_version                                 = GetString(new IntPtr(p + 0x038)); // 0x38 M_version                   ( ModelPrimitiveType string string string String )
            value.M_actor                                   = GetObject<ClaimsIdentity>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClaimsIdentity.FromPointer); // 0x40 M_actor                     ( ModelClassType ClaimsIdentity ClaimsIdentity ClaimsIdentity Pointer )
            value.M_authenticationType                      = GetString(new IntPtr(p + 0x048)); // 0x48 M_authenticationType        ( ModelPrimitiveType string string string String )
            value.M_label                                   = GetString(new IntPtr(p + 0x058)); // 0x58 M_label                     ( ModelPrimitiveType string string string String )
            value.M_serializedNameType                      = GetString(new IntPtr(p + 0x060)); // 0x60 M_serializedNameType        ( ModelPrimitiveType string string string String )
            value.M_serializedRoleType                      = GetString(new IntPtr(p + 0x068)); // 0x68 M_serializedRoleType        ( ModelPrimitiveType string string string String )
            value.M_serializedClaims                        = GetString(new IntPtr(p + 0x070)); // 0x70 M_serializedClaims          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
