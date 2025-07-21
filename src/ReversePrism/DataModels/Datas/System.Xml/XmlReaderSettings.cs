using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 ModelPrimitiveType bool bool bool Bool
    // 018 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 028 LineNumberOffset                         ModelPrimitiveType int int int Int32
    // 02C LinePositionOffset                       ModelPrimitiveType int int int Int32
    // 030 ConformanceLevel                         ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    // 034 CheckCharacters                          ModelPrimitiveType bool bool bool Bool
    // 038 MaxCharactersInDocument                  ModelPrimitiveType long long long Int64
    // 040 MaxCharactersFromEntities                ModelPrimitiveType long long long Int64
    // 048 IgnoreWhitespace                         ModelPrimitiveType bool bool bool Bool
    // 049 IgnorePIs                                ModelPrimitiveType bool bool bool Bool
    // 04A IgnoreComments                           ModelPrimitiveType bool bool bool Bool
    // 04C DtdProcessing                            ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32
    // 050 ValidationType                           ModelEnumType ValidationType ValidationType ValidationType Int32
    // 054 ValidationFlags                          ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32
    // 058 Schemas                                  ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 060 ValEventHandler                          ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 068 CloseInput                               ModelPrimitiveType bool bool bool Bool
    // 069 IsReadOnly                               ModelPrimitiveType bool bool bool Bool
    // 06A IsXmlResolverSet                         ModelPrimitiveType bool bool bool Bool
    // 000 s_enableLegacyXmlSettings                Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class XmlReaderSettings : DataModel
    {
        public bool                                     UseAsync                                { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }
        public int                                      LineNumberOffset                        { get; set; }
        public int                                      LinePositionOffset                      { get; set; }
        public ConformanceLevel                         ConformanceLevel                        { get; set; }
        public bool                                     CheckCharacters                         { get; set; }
        public long                                     MaxCharactersInDocument                 { get; set; }
        public long                                     MaxCharactersFromEntities               { get; set; }
        public bool                                     IgnoreWhitespace                        { get; set; }
        public bool                                     IgnorePIs                               { get; set; }
        public bool                                     IgnoreComments                          { get; set; }
        public DtdProcessing                            DtdProcessing                           { get; set; }
        public ValidationType                           ValidationType                          { get; set; }
        public XmlSchemaValidationFlags                 ValidationFlags                         { get; set; }
        public XmlSchemaSet?                            Schemas                                 { get; set; }
        public ValidationEventHandler?                  ValEventHandler                         { get; set; }
        public bool                                     CloseInput                              { get; set; }
        public bool                                     IsReadOnly                              { get; set; }
        public bool                                     IsXmlResolverSet                        { get; set; }

        public static XmlReaderSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlReaderSettings() { Pointer= p0 };

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 UseAsync                    ( ModelPrimitiveType bool bool bool Bool )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x18 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x20 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.LineNumberOffset                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 LineNumberOffset            ( ModelPrimitiveType int int int Int32 )
            value.LinePositionOffset                        = GetInt32(new IntPtr(p + 0x02C)); // 0x2C LinePositionOffset          ( ModelPrimitiveType int int int Int32 )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x030)); // 0x30 ConformanceLevel            ( ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x034)); // 0x34 CheckCharacters             ( ModelPrimitiveType bool bool bool Bool )
            value.MaxCharactersInDocument                   = GetInt64(new IntPtr(p + 0x038)); // 0x38 MaxCharactersInDocument     ( ModelPrimitiveType long long long Int64 )
            value.MaxCharactersFromEntities                 = GetInt64(new IntPtr(p + 0x040)); // 0x40 MaxCharactersFromEntities   ( ModelPrimitiveType long long long Int64 )
            value.IgnoreWhitespace                          = GetBool(new IntPtr(p + 0x048)); // 0x48 IgnoreWhitespace            ( ModelPrimitiveType bool bool bool Bool )
            value.IgnorePIs                                 = GetBool(new IntPtr(p + 0x049)); // 0x49 IgnorePIs                   ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreComments                            = GetBool(new IntPtr(p + 0x04A)); // 0x4A IgnoreComments              ( ModelPrimitiveType bool bool bool Bool )
            value.DtdProcessing                             = (DtdProcessing)GetInt32(new IntPtr(p + 0x04C)); // 0x4C DtdProcessing               ( ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32 )
            value.ValidationType                            = (ValidationType)GetInt32(new IntPtr(p + 0x050)); // 0x50 ValidationType              ( ModelEnumType ValidationType ValidationType ValidationType Int32 )
            value.ValidationFlags                           = (XmlSchemaValidationFlags)GetInt32(new IntPtr(p + 0x054)); // 0x54 ValidationFlags             ( ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32 )
            value.Schemas                                   = GetObject<XmlSchemaSet>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0x58 Schemas                     ( ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.ValEventHandler                           = GetObject<ValidationEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0x60 ValEventHandler             ( ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.CloseInput                                = GetBool(new IntPtr(p + 0x068)); // 0x68 CloseInput                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x069)); // 0x69 IsReadOnly                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsXmlResolverSet                          = GetBool(new IntPtr(p + 0x06A)); // 0x6A IsXmlResolverSet            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
