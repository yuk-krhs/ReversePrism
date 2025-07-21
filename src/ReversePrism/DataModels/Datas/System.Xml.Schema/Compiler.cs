using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 RestrictionErrorMsg                      ModelPrimitiveType string string string String
    // 048 Attributes                               ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 050 AttributeGroups                          ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 058 Elements                                 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 060 SchemaTypes                              ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 068 Groups                                   ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 070 Notations                                ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 078 Examplars                                ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 080 IdentityConstraints                      ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 088 ComplexTypeStack                         ModelClassType Stack Stack Stack Pointer
    // 090 SchemasToCompile                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 098 ImportedSchemas                          ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0A0 SchemaForSchema                          ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    public partial class Compiler : DataModel
    {
        public string                                   RestrictionErrorMsg                     { get; set; }
        public XmlSchemaObjectTable?                    Attributes                              { get; set; }
        public XmlSchemaObjectTable?                    AttributeGroups                         { get; set; }
        public XmlSchemaObjectTable?                    Elements                                { get; set; }
        public XmlSchemaObjectTable?                    SchemaTypes                             { get; set; }
        public XmlSchemaObjectTable?                    Groups                                  { get; set; }
        public XmlSchemaObjectTable?                    Notations                               { get; set; }
        public XmlSchemaObjectTable?                    Examplars                               { get; set; }
        public XmlSchemaObjectTable?                    IdentityConstraints                     { get; set; }
        public Stack?                                   ComplexTypeStack                        { get; set; }
        public Hashtable?                               SchemasToCompile                        { get; set; }
        public Hashtable?                               ImportedSchemas                         { get; set; }
        public XmlSchema?                               SchemaForSchema                         { get; set; }

        public static Compiler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Compiler() { Pointer= p0 };

            value.RestrictionErrorMsg                       = GetString(new IntPtr(p + 0x040)); // 0x40 RestrictionErrorMsg         ( ModelPrimitiveType string string string String )
            value.Attributes                                = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x48 Attributes                  ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeGroups                           = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x50 AttributeGroups             ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Elements                                  = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x58 Elements                    ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.SchemaTypes                               = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x60 SchemaTypes                 ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Groups                                    = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x68 Groups                      ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Notations                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x70 Notations                   ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Examplars                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x78 Examplars                   ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.IdentityConstraints                       = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0x80 IdentityConstraints         ( ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.ComplexTypeStack                          = GetObject<Stack>(new IntPtr(p + 0x088), ReversePrism.DataModels.Stack.FromPointer); // 0x88 ComplexTypeStack            ( ModelClassType Stack Stack Stack Pointer )
            value.SchemasToCompile                          = GetObject<Hashtable>(new IntPtr(p + 0x090), ReversePrism.DataModels.Hashtable.FromPointer); // 0x90 SchemasToCompile            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ImportedSchemas                           = GetObject<Hashtable>(new IntPtr(p + 0x098), ReversePrism.DataModels.Hashtable.FromPointer); // 0x98 ImportedSchemas             ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SchemaForSchema                           = GetObject<XmlSchema>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchema.FromPointer); // 0xA0 SchemaForSchema             ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}
