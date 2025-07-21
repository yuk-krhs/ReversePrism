using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaCollection                         ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer
    // 018 EventHandling                            ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer
    // 020 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 028 SchemaNames                              ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 030 PositionInfo                             ModelClassType PositionInfo PositionInfo PositionInfo Pointer
    // 038 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 040 BaseUri                                  ModelClassType Uri Uri Uri Pointer
    // 048 SchemaInfo                               ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 050 Reader                                   ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer
    // 058 ElementName                              ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 060 Context                                  ModelClassType ValidationState ValidationState ValidationState Pointer
    // 068 TextValue                                ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 070 TextString                               ModelPrimitiveType string string string String
    // 078 HasSibling                               ModelPrimitiveType bool bool bool Bool
    // 079 CheckDatatype                            ModelPrimitiveType bool bool bool Bool
    public partial class BaseValidator : DataModel
    {
        public XmlSchemaCollection?                     SchemaCollection                        { get; set; }
        public IValidationEventHandling?                EventHandling                           { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public SchemaNames?                             SchemaNames                             { get; set; }
        public PositionInfo?                            PositionInfo                            { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }
        public Uri?                                     BaseUri                                 { get; set; }
        public SchemaInfo?                              SchemaInfo                              { get; set; }
        public XmlValidatingReaderImpl?                 Reader                                  { get; set; }
        public XmlQualifiedName?                        ElementName                             { get; set; }
        public ValidationState?                         Context                                 { get; set; }
        public StringBuilder?                           TextValue                               { get; set; }
        public string                                   TextString                              { get; set; }
        public bool                                     HasSibling                              { get; set; }
        public bool                                     CheckDatatype                           { get; set; }

        public static BaseValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseValidator() { Pointer= p0 };

            value.SchemaCollection                          = GetObject<XmlSchemaCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaCollection.FromPointer); // 0x10 SchemaCollection            ( ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer )
            value.EventHandling                             = GetObject<IValidationEventHandling>(new IntPtr(p + 0x018), ReversePrism.DataModels.IValidationEventHandling.FromPointer); // 0x18 EventHandling               ( ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x20 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x028), ReversePrism.DataModels.SchemaNames.FromPointer); // 0x28 SchemaNames                 ( ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.PositionInfo                              = GetObject<PositionInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.PositionInfo.FromPointer); // 0x30 PositionInfo                ( ModelClassType PositionInfo PositionInfo PositionInfo Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x38 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.BaseUri                                   = GetObject<Uri>(new IntPtr(p + 0x040), ReversePrism.DataModels.Uri.FromPointer); // 0x40 BaseUri                     ( ModelClassType Uri Uri Uri Pointer )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0x48 SchemaInfo                  ( ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.Reader                                    = GetObject<XmlValidatingReaderImpl>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlValidatingReaderImpl.FromPointer); // 0x50 Reader                      ( ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer )
            value.ElementName                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x58 ElementName                 ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Context                                   = GetObject<ValidationState>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValidationState.FromPointer); // 0x60 Context                     ( ModelClassType ValidationState ValidationState ValidationState Pointer )
            value.TextValue                                 = GetObject<StringBuilder>(new IntPtr(p + 0x068), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x68 TextValue                   ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.TextString                                = GetString(new IntPtr(p + 0x070)); // 0x70 TextString                  ( ModelPrimitiveType string string string String )
            value.HasSibling                                = GetBool(new IntPtr(p + 0x078)); // 0x78 HasSibling                  ( ModelPrimitiveType bool bool bool Bool )
            value.CheckDatatype                             = GetBool(new IntPtr(p + 0x079)); // 0x79 CheckDatatype               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
