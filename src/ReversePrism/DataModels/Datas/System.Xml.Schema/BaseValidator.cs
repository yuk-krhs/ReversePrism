using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaCollection                         0001865AF840 ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer
    // 018 EventHandling                            000186691150 ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer
    // 020 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 028 SchemaNames                              0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 030 PositionInfo                             000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer
    // 038 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 040 BaseUri                                  0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 048 SchemaInfo                               0001866EA0D0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 050 Reader                                   0001865D4760 ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer
    // 058 ElementName                              0001866BCCE0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 060 Context                                  0001867666B0 ModelClassType ValidationState ValidationState ValidationState Pointer
    // 068 TextValue                                000186676D50 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 070 TextString                               000186671E00 ModelPrimitiveType string string string String
    // 078 HasSibling                               000186595480 ModelPrimitiveType bool bool bool Bool
    // 079 CheckDatatype                            000186595480 ModelPrimitiveType bool bool bool Bool
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

            value.SchemaCollection                          = GetObject<XmlSchemaCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaCollection.FromPointer); // 024667463A30 0x10 SchemaCollection            ( 0001865AF840 ModelClassType XmlSchemaCollection XmlSchemaCollection XmlSchemaCollection Pointer )
            value.EventHandling                             = GetObject<IValidationEventHandling>(new IntPtr(p + 0x018), ReversePrism.DataModels.IValidationEventHandling.FromPointer); // 024667463A50 0x18 EventHandling               ( 000186691150 ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlNameTable.FromPointer); // 024667463A70 0x20 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x028), ReversePrism.DataModels.SchemaNames.FromPointer); // 024667463A90 0x28 SchemaNames                 ( 0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.PositionInfo                              = GetObject<PositionInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.PositionInfo.FromPointer); // 024667463AB0 0x30 PositionInfo                ( 000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlResolver.FromPointer); // 024667463AD0 0x38 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.BaseUri                                   = GetObject<Uri>(new IntPtr(p + 0x040), ReversePrism.DataModels.Uri.FromPointer); // 024667463AF0 0x40 BaseUri                     ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.SchemaInfo.FromPointer); // 024667463B10 0x48 SchemaInfo                  ( 0001866EA0D0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.Reader                                    = GetObject<XmlValidatingReaderImpl>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlValidatingReaderImpl.FromPointer); // 024667463B30 0x50 Reader                      ( 0001865D4760 ModelClassType XmlValidatingReaderImpl XmlValidatingReaderImpl XmlValidatingReaderImpl Pointer )
            value.ElementName                               = GetObject<XmlQualifiedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667463B50 0x58 ElementName                 ( 0001866BCCE0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Context                                   = GetObject<ValidationState>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValidationState.FromPointer); // 024667463B70 0x60 Context                     ( 0001867666B0 ModelClassType ValidationState ValidationState ValidationState Pointer )
            value.TextValue                                 = GetObject<StringBuilder>(new IntPtr(p + 0x068), ReversePrism.DataModels.StringBuilder.FromPointer); // 024667463B90 0x68 TextValue                   ( 000186676D50 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.TextString                                = GetString(new IntPtr(p + 0x070)); // 024667463BB0 0x70 TextString                  ( 000186671E00 ModelPrimitiveType string string string String )
            value.HasSibling                                = GetBool(new IntPtr(p + 0x078)); // 024667463BD0 0x78 HasSibling                  ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.CheckDatatype                             = GetBool(new IntPtr(p + 0x079)); // 024667463BF0 0x79 CheckDatatype               ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
