using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 RestrictionErrorMsg                      000186671910 ModelPrimitiveType string string string String
    // 048 Attributes                               0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 050 AttributeGroups                          0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 058 Elements                                 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 060 SchemaTypes                              0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 068 Groups                                   0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 070 Notations                                0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 078 Examplars                                0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 080 IdentityConstraints                      0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer
    // 088 ComplexTypeStack                         00018655EBF0 ModelClassType Stack Stack Stack Pointer
    // 090 SchemasToCompile                         0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 098 ImportedSchemas                          0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0A0 SchemaForSchema                          0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
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

            value.RestrictionErrorMsg                       = GetString(new IntPtr(p + 0x040)); // 0246675F35A8 0x40 RestrictionErrorMsg         ( 000186671910 ModelPrimitiveType string string string String )
            value.Attributes                                = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F35C8 0x48 Attributes                  ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.AttributeGroups                           = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F35E8 0x50 AttributeGroups             ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Elements                                  = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F3608 0x58 Elements                    ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.SchemaTypes                               = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F3628 0x60 SchemaTypes                 ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Groups                                    = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F3648 0x68 Groups                      ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Notations                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F3668 0x70 Notations                   ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.Examplars                                 = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F3688 0x78 Examplars                   ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.IdentityConstraints                       = GetObject<XmlSchemaObjectTable>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaObjectTable.FromPointer); // 0246675F36A8 0x80 IdentityConstraints         ( 0001865BCD20 ModelClassType XmlSchemaObjectTable XmlSchemaObjectTable XmlSchemaObjectTable Pointer )
            value.ComplexTypeStack                          = GetObject<Stack>(new IntPtr(p + 0x088), ReversePrism.DataModels.Stack.FromPointer); // 0246675F36C8 0x88 ComplexTypeStack            ( 00018655EBF0 ModelClassType Stack Stack Stack Pointer )
            value.SchemasToCompile                          = GetObject<Hashtable>(new IntPtr(p + 0x090), ReversePrism.DataModels.Hashtable.FromPointer); // 0246675F36E8 0x90 SchemasToCompile            ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ImportedSchemas                           = GetObject<Hashtable>(new IntPtr(p + 0x098), ReversePrism.DataModels.Hashtable.FromPointer); // 0246675F3708 0x98 ImportedSchemas             ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SchemaForSchema                           = GetObject<XmlSchema>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSchema.FromPointer); // 0246675F3728 0xA0 SchemaForSchema             ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}
