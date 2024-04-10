using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 elementDecls                             Dictionary`2<XmlQualifiedName, SchemaElementDecl> IL2CPP_TYPE_GENERICINST
    // 018 undeclaredElementDecls                   Dictionary`2<XmlQualifiedName, SchemaElementDecl> IL2CPP_TYPE_GENERICINST
    // 020 generalEntities                          Dictionary`2<XmlQualifiedName, SchemaEntity> IL2CPP_TYPE_GENERICINST
    // 028 parameterEntities                        Dictionary`2<XmlQualifiedName, SchemaEntity> IL2CPP_TYPE_GENERICINST
    // 030 DocTypeName                              0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 038 InternalDtdSubset                        000186671910 ModelPrimitiveType string string string String
    // 040 HasNonCDataAttributes                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 HasDefaultAttributes                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 targetNamespaces                         Dictionary`2<string, bool> IL2CPP_TYPE_GENERICINST
    // 050 attributeDecls                           Dictionary`2<XmlQualifiedName, SchemaAttDef> IL2CPP_TYPE_GENERICINST
    // 058 ErrorCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C SchemaType                               0001866EB700 ModelEnumType SchemaType SchemaType SchemaType Int32
    // 060 elementDeclsByType                       Dictionary`2<XmlQualifiedName, SchemaElementDecl> IL2CPP_TYPE_GENERICINST
    // 068 notations                                Dictionary`2<string, SchemaNotation> IL2CPP_TYPE_GENERICINST
    public partial class SchemaInfo : DataModel
    {
        public XmlQualifiedName?                        DocTypeName                             { get; set; }
        public string                                   InternalDtdSubset                       { get; set; }
        public bool                                     HasNonCDataAttributes                   { get; set; }
        public bool                                     HasDefaultAttributes                    { get; set; }
        public int                                      ErrorCount                              { get; set; }
        public SchemaType                               SchemaType                              { get; set; }

        public static SchemaInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaInfo() { Pointer= p0 };

            value.DocTypeName                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246674AD880 0x30 DocTypeName                 ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.InternalDtdSubset                         = GetString(new IntPtr(p + 0x038)); // 0246674AD8A0 0x38 InternalDtdSubset           ( 000186671910 ModelPrimitiveType string string string String )
            value.HasNonCDataAttributes                     = GetBool(new IntPtr(p + 0x040)); // 0246674AD8C0 0x40 HasNonCDataAttributes       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasDefaultAttributes                      = GetBool(new IntPtr(p + 0x041)); // 0246674AD8E0 0x41 HasDefaultAttributes        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ErrorCount                                = GetInt32(new IntPtr(p + 0x058)); // 0246674AD940 0x58 ErrorCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SchemaType                                = (SchemaType)GetInt32(new IntPtr(p + 0x05C)); // 0246674AD960 0x5C SchemaType                  ( 0001866EB700 ModelEnumType SchemaType SchemaType SchemaType Int32 )

            return value;
        }
    }
}
