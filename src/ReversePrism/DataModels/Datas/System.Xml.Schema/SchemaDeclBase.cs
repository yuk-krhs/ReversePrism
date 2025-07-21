using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Prefix                                   ModelPrimitiveType string string string String
    // 020 IsDeclaredInExternal                     ModelPrimitiveType bool bool bool Bool
    // 024 Presence                                 ModelEnumType Use Use Use Int32
    // 028 SchemaType                               ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 030 Datatype                                 ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer
    // 038 DefaultValueRaw                          ModelPrimitiveType string string string String
    // 040 defaultValueTyped                        <object> IL2CPP_TYPE_OBJECT
    // 048 MaxLength                                ModelPrimitiveType long long long Int64
    // 050 MinLength                                ModelPrimitiveType long long long Int64
    // 058 Values                                   ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
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

            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x10 Name                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Prefix                      ( ModelPrimitiveType string string string String )
            value.IsDeclaredInExternal                      = GetBool(new IntPtr(p + 0x020)); // 0x20 IsDeclaredInExternal        ( ModelPrimitiveType bool bool bool Bool )
            value.Presence                                  = (Use)GetInt32(new IntPtr(p + 0x024)); // 0x24 Presence                    ( ModelEnumType Use Use Use Int32 )
            value.SchemaType                                = GetObject<XmlSchemaType>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x28 SchemaType                  ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.Datatype                                  = GetObject<XmlSchemaDatatype>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaDatatype.FromPointer); // 0x30 Datatype                    ( ModelClassType XmlSchemaDatatype XmlSchemaDatatype XmlSchemaDatatype Pointer )
            value.DefaultValueRaw                           = GetString(new IntPtr(p + 0x038)); // 0x38 DefaultValueRaw             ( ModelPrimitiveType string string string String )
            value.MaxLength                                 = GetInt64(new IntPtr(p + 0x048)); // 0x48 MaxLength                   ( ModelPrimitiveType long long long Int64 )
            value.MinLength                                 = GetInt64(new IntPtr(p + 0x050)); // 0x50 MinLength                   ( ModelPrimitiveType long long long Int64 )
            value.Values                                    = GetStringList(new IntPtr(p + 0x058)); // 0x58 Values                      ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
