using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 020 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 028 LineNumberOffset                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C LinePositionOffset                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 ConformanceLevel                         000186600120 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    // 034 CheckCharacters                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 MaxCharactersInDocument                  0001865F7700 ModelPrimitiveType long long long Int64
    // 040 MaxCharactersFromEntities                0001865F7700 ModelPrimitiveType long long long Int64
    // 048 IgnoreWhitespace                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 IgnorePIs                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04A IgnoreComments                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C DtdProcessing                            000186708FB0 ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32
    // 050 ValidationType                           000186766BD0 ModelEnumType ValidationType ValidationType ValidationType Int32
    // 054 ValidationFlags                          0001865C2980 ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32
    // 058 Schemas                                  0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 060 ValEventHandler                          000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 068 CloseInput                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 IsReadOnly                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 06A IsXmlResolverSet                         000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 0246673B5928 0x10 UseAsync                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0246673B5948 0x18 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlResolver.FromPointer); // 0246673B5968 0x20 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.LineNumberOffset                          = GetInt32(new IntPtr(p + 0x028)); // 0246673B5988 0x28 LineNumberOffset            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePositionOffset                        = GetInt32(new IntPtr(p + 0x02C)); // 0246673B59A8 0x2C LinePositionOffset          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x030)); // 0246673B59C8 0x30 ConformanceLevel            ( 000186600120 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x034)); // 0246673B59E8 0x34 CheckCharacters             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxCharactersInDocument                   = GetInt64(new IntPtr(p + 0x038)); // 0246673B5A08 0x38 MaxCharactersInDocument     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.MaxCharactersFromEntities                 = GetInt64(new IntPtr(p + 0x040)); // 0246673B5A28 0x40 MaxCharactersFromEntities   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IgnoreWhitespace                          = GetBool(new IntPtr(p + 0x048)); // 0246673B5A48 0x48 IgnoreWhitespace            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnorePIs                                 = GetBool(new IntPtr(p + 0x049)); // 0246673B5A68 0x49 IgnorePIs                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreComments                            = GetBool(new IntPtr(p + 0x04A)); // 0246673B5A88 0x4A IgnoreComments              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DtdProcessing                             = (DtdProcessing)GetInt32(new IntPtr(p + 0x04C)); // 0246673B5AA8 0x4C DtdProcessing               ( 000186708FB0 ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32 )
            value.ValidationType                            = (ValidationType)GetInt32(new IntPtr(p + 0x050)); // 0246673B5AC8 0x50 ValidationType              ( 000186766BD0 ModelEnumType ValidationType ValidationType ValidationType Int32 )
            value.ValidationFlags                           = (XmlSchemaValidationFlags)GetInt32(new IntPtr(p + 0x054)); // 0246673B5AE8 0x54 ValidationFlags             ( 0001865C2980 ModelEnumType XmlSchemaValidationFlags XmlSchemaValidationFlags XmlSchemaValidationFlags Int32 )
            value.Schemas                                   = GetObject<XmlSchemaSet>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0246673B5B08 0x58 Schemas                     ( 0001865BEE30 ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.ValEventHandler                           = GetObject<ValidationEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0246673B5B28 0x60 ValEventHandler             ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.CloseInput                                = GetBool(new IntPtr(p + 0x068)); // 0246673B5B48 0x68 CloseInput                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x069)); // 0246673B5B68 0x69 IsReadOnly                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsXmlResolverSet                          = GetBool(new IntPtr(p + 0x06A)); // 0246673B5B88 0x6A IsXmlResolverSet            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
