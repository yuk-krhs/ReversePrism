using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866BCCE0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Prefix                                   000186671E00 ModelPrimitiveType string string string String
    // 020 IsDeclaredInExternal                     000186595480 ModelPrimitiveType bool bool bool Bool
    // 024 Presence                                 000186733600 ModelEnumType Use Use Use Int32
    // 028 SchemaType                               0001866C0460 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 030 Datatype                                 0001865B3D10 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 038 DefaultValueRaw                          000186671E00 ModelPrimitiveType string string string String
    // 040 defaultValueTyped                        <object> IL2CPP_TYPE_OBJECT
    // 048 MaxLength                                0001865F7BC0 ModelPrimitiveType long long long Int64
    // 050 MinLength                                0001865F7BC0 ModelPrimitiveType long long long Int64
    // 058 Values                                   000185D0D618 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class SchemaDeclBase : DataModel
    {
        public XmlQualifiedName?                        Name                                    { get; set; }
        public string                                   Prefix                                  { get; set; }
        public bool                                     IsDeclaredInExternal                    { get; set; }
        public Use                                      Presence                                { get; set; }
        public XmlSchemaType?                           SchemaType                              { get; set; }
        public XmlSchemaDatatype?                       Datatype                                { get; set; }
        public string                                   DefaultValueRaw                         { get; set; }
        public long                                     MaxLength                               { get; set; }
        public long                                     MinLength                               { get; set; }
        public List<string>?                            Values                                  { get; set; }

        public static SchemaDeclBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaDeclBase() { Pointer= p0 };

            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246674449A8 0x10 Name                        ( 0001866BCCE0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0246674449C8 0x18 Prefix                      ( 000186671E00 ModelPrimitiveType string string string String )
            value.IsDeclaredInExternal                      = GetBool(new IntPtr(p + 0x020)); // 0246674449E8 0x20 IsDeclaredInExternal        ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Presence                                  = (Use)GetInt32(new IntPtr(p + 0x024)); // 024667444A08 0x24 Presence                    ( 000186733600 ModelEnumType Use Use Use Int32 )
            value.SchemaType                                = GetObject<XmlSchemaType>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 024667444A28 0x28 SchemaType                  ( 0001866C0460 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.Datatype                                  = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 024667444A48 0x30 Datatype                    ( 0001865B3D10 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.DefaultValueRaw                           = GetString(new IntPtr(p + 0x038)); // 024667444A68 0x38 DefaultValueRaw             ( 000186671E00 ModelPrimitiveType string string string String )
            value.MaxLength                                 = GetInt64(new IntPtr(p + 0x048)); // 024667444AA8 0x48 MaxLength                   ( 0001865F7BC0 ModelPrimitiveType long long long Int64 )
            value.MinLength                                 = GetInt64(new IntPtr(p + 0x050)); // 024667444AC8 0x50 MinLength                   ( 0001865F7BC0 ModelPrimitiveType long long long Int64 )
            value.Values                                    = GetStringList(new IntPtr(p + 0x058)); // 024667444AE8 0x58 Values                      ( 000185D0D618 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
