using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyString                              XmlDictionaryString IL2CPP_TYPE_CLASS
    // 008 SchemaInstanceNamespace                  XmlDictionaryString IL2CPP_TYPE_CLASS
    // 010 SchemaNamespace                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 018 SerializationNamespace                   0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 020 XmlnsNamespace                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 028 XsiTypeLocalName                         0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 030 XsiNilLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 038 ClrTypeLocalName                         0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 040 ClrAssemblyLocalName                     0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 048 ArraySizeLocalName                       0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 050 IdLocalName                              0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 058 RefLocalName                             0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 060 ISerializableFactoryTypeLocalName        0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 068 CharLocalName                            0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 070 BooleanLocalName                         0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 078 SignedByteLocalName                      0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 080 UnsignedByteLocalName                    0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 088 ShortLocalName                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 090 UnsignedShortLocalName                   0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 098 IntLocalName                             0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0A0 UnsignedIntLocalName                     0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0A8 LongLocalName                            0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0B0 UnsignedLongLocalName                    0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0B8 FloatLocalName                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0C0 DoubleLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0C8 DecimalLocalName                         0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0D0 DateTimeLocalName                        0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0D8 StringLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0E0 ByteArrayLocalName                       0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0E8 ObjectLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0F0 TimeSpanLocalName                        0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 0F8 GuidLocalName                            0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 100 UriLocalName                             0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 108 QNameLocalName                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 110 Space                                    0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 118 TimeLocalName                            0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 120 DateLocalName                            0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 128 HexBinaryLocalName                       0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 130 GYearMonthLocalName                      0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 138 GYearLocalName                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 140 GMonthDayLocalName                       0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 148 GDayLocalName                            0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 150 GMonthLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 158 IntegerLocalName                         0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 160 PositiveIntegerLocalName                 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 168 NegativeIntegerLocalName                 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 170 NonPositiveIntegerLocalName              0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 178 NonNegativeIntegerLocalName              0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 180 NormalizedStringLocalName                0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 188 TokenLocalName                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 190 LanguageLocalName                        0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 198 NameLocalName                            0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1A0 NCNameLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1A8 XSDIDLocalName                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1B0 IDREFLocalName                           0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1B8 IDREFSLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1C0 ENTITYLocalName                          0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1C8 ENTITIESLocalName                        0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1D0 NMTOKENLocalName                         0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1D8 NMTOKENSLocalName                        0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 1E0 AsmxTypesNamespace                       0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    public partial class DictionaryGlobals : DataModel
    {
        public XmlDictionaryString?                     SchemaNamespace                         { get; set; }
        public XmlDictionaryString?                     SerializationNamespace                  { get; set; }
        public XmlDictionaryString?                     XmlnsNamespace                          { get; set; }
        public XmlDictionaryString?                     XsiTypeLocalName                        { get; set; }
        public XmlDictionaryString?                     XsiNilLocalName                         { get; set; }
        public XmlDictionaryString?                     ClrTypeLocalName                        { get; set; }
        public XmlDictionaryString?                     ClrAssemblyLocalName                    { get; set; }
        public XmlDictionaryString?                     ArraySizeLocalName                      { get; set; }
        public XmlDictionaryString?                     IdLocalName                             { get; set; }
        public XmlDictionaryString?                     RefLocalName                            { get; set; }
        public XmlDictionaryString?                     ISerializableFactoryTypeLocalName       { get; set; }
        public XmlDictionaryString?                     CharLocalName                           { get; set; }
        public XmlDictionaryString?                     BooleanLocalName                        { get; set; }
        public XmlDictionaryString?                     SignedByteLocalName                     { get; set; }
        public XmlDictionaryString?                     UnsignedByteLocalName                   { get; set; }
        public XmlDictionaryString?                     ShortLocalName                          { get; set; }
        public XmlDictionaryString?                     UnsignedShortLocalName                  { get; set; }
        public XmlDictionaryString?                     IntLocalName                            { get; set; }
        public XmlDictionaryString?                     UnsignedIntLocalName                    { get; set; }
        public XmlDictionaryString?                     LongLocalName                           { get; set; }
        public XmlDictionaryString?                     UnsignedLongLocalName                   { get; set; }
        public XmlDictionaryString?                     FloatLocalName                          { get; set; }
        public XmlDictionaryString?                     DoubleLocalName                         { get; set; }
        public XmlDictionaryString?                     DecimalLocalName                        { get; set; }
        public XmlDictionaryString?                     DateTimeLocalName                       { get; set; }
        public XmlDictionaryString?                     StringLocalName                         { get; set; }
        public XmlDictionaryString?                     ByteArrayLocalName                      { get; set; }
        public XmlDictionaryString?                     ObjectLocalName                         { get; set; }
        public XmlDictionaryString?                     TimeSpanLocalName                       { get; set; }
        public XmlDictionaryString?                     GuidLocalName                           { get; set; }
        public XmlDictionaryString?                     UriLocalName                            { get; set; }
        public XmlDictionaryString?                     QNameLocalName                          { get; set; }
        public XmlDictionaryString?                     Space                                   { get; set; }
        public XmlDictionaryString?                     TimeLocalName                           { get; set; }
        public XmlDictionaryString?                     DateLocalName                           { get; set; }
        public XmlDictionaryString?                     HexBinaryLocalName                      { get; set; }
        public XmlDictionaryString?                     GYearMonthLocalName                     { get; set; }
        public XmlDictionaryString?                     GYearLocalName                          { get; set; }
        public XmlDictionaryString?                     GMonthDayLocalName                      { get; set; }
        public XmlDictionaryString?                     GDayLocalName                           { get; set; }
        public XmlDictionaryString?                     GMonthLocalName                         { get; set; }
        public XmlDictionaryString?                     IntegerLocalName                        { get; set; }
        public XmlDictionaryString?                     PositiveIntegerLocalName                { get; set; }
        public XmlDictionaryString?                     NegativeIntegerLocalName                { get; set; }
        public XmlDictionaryString?                     NonPositiveIntegerLocalName             { get; set; }
        public XmlDictionaryString?                     NonNegativeIntegerLocalName             { get; set; }
        public XmlDictionaryString?                     NormalizedStringLocalName               { get; set; }
        public XmlDictionaryString?                     TokenLocalName                          { get; set; }
        public XmlDictionaryString?                     LanguageLocalName                       { get; set; }
        public XmlDictionaryString?                     NameLocalName                           { get; set; }
        public XmlDictionaryString?                     NCNameLocalName                         { get; set; }
        public XmlDictionaryString?                     XSDIDLocalName                          { get; set; }
        public XmlDictionaryString?                     IDREFLocalName                          { get; set; }
        public XmlDictionaryString?                     IDREFSLocalName                         { get; set; }
        public XmlDictionaryString?                     ENTITYLocalName                         { get; set; }
        public XmlDictionaryString?                     ENTITIESLocalName                       { get; set; }
        public XmlDictionaryString?                     NMTOKENLocalName                        { get; set; }
        public XmlDictionaryString?                     NMTOKENSLocalName                       { get; set; }
        public XmlDictionaryString?                     AsmxTypesNamespace                      { get; set; }

        public static DictionaryGlobals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DictionaryGlobals() { Pointer= p0 };

            value.SchemaNamespace                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9A50 0x10 SchemaNamespace             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.SerializationNamespace                    = GetObject<XmlDictionaryString>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9A70 0x18 SerializationNamespace      ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.XmlnsNamespace                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9A90 0x20 XmlnsNamespace              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.XsiTypeLocalName                          = GetObject<XmlDictionaryString>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9AB0 0x28 XsiTypeLocalName            ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.XsiNilLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9AD0 0x30 XsiNilLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ClrTypeLocalName                          = GetObject<XmlDictionaryString>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9AF0 0x38 ClrTypeLocalName            ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ClrAssemblyLocalName                      = GetObject<XmlDictionaryString>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9B10 0x40 ClrAssemblyLocalName        ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ArraySizeLocalName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9B30 0x48 ArraySizeLocalName          ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IdLocalName                               = GetObject<XmlDictionaryString>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9B50 0x50 IdLocalName                 ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.RefLocalName                              = GetObject<XmlDictionaryString>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9B70 0x58 RefLocalName                ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ISerializableFactoryTypeLocalName         = GetObject<XmlDictionaryString>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9B90 0x60 ISerializableFactoryTypeLocalName ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.CharLocalName                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9BB0 0x68 CharLocalName               ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.BooleanLocalName                          = GetObject<XmlDictionaryString>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9BD0 0x70 BooleanLocalName            ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.SignedByteLocalName                       = GetObject<XmlDictionaryString>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9BF0 0x78 SignedByteLocalName         ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.UnsignedByteLocalName                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9C10 0x80 UnsignedByteLocalName       ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ShortLocalName                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9C30 0x88 ShortLocalName              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.UnsignedShortLocalName                    = GetObject<XmlDictionaryString>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9C50 0x90 UnsignedShortLocalName      ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IntLocalName                              = GetObject<XmlDictionaryString>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9C70 0x98 IntLocalName                ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.UnsignedIntLocalName                      = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9C90 0xA0 UnsignedIntLocalName        ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.LongLocalName                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9CB0 0xA8 LongLocalName               ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.UnsignedLongLocalName                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9CD0 0xB0 UnsignedLongLocalName       ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.FloatLocalName                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9CF0 0xB8 FloatLocalName              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.DoubleLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9D10 0xC0 DoubleLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.DecimalLocalName                          = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9D30 0xC8 DecimalLocalName            ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.DateTimeLocalName                         = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9D50 0xD0 DateTimeLocalName           ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.StringLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9D70 0xD8 StringLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ByteArrayLocalName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9D90 0xE0 ByteArrayLocalName          ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ObjectLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9DB0 0xE8 ObjectLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.TimeSpanLocalName                         = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9DD0 0xF0 TimeSpanLocalName           ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.GuidLocalName                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9DF0 0xF8 GuidLocalName               ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.UriLocalName                              = GetObject<XmlDictionaryString>(new IntPtr(p + 0x100), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9E10 0x100 UriLocalName                ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.QNameLocalName                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x108), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9E30 0x108 QNameLocalName              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.Space                                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x110), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9E50 0x110 Space                       ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.TimeLocalName                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x118), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9E70 0x118 TimeLocalName               ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.DateLocalName                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x120), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9E90 0x120 DateLocalName               ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.HexBinaryLocalName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x128), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9EB0 0x128 HexBinaryLocalName          ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.GYearMonthLocalName                       = GetObject<XmlDictionaryString>(new IntPtr(p + 0x130), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9ED0 0x130 GYearMonthLocalName         ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.GYearLocalName                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9EF0 0x138 GYearLocalName              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.GMonthDayLocalName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x140), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9F10 0x140 GMonthDayLocalName          ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.GDayLocalName                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x148), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9F30 0x148 GDayLocalName               ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.GMonthLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x150), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9F50 0x150 GMonthLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IntegerLocalName                          = GetObject<XmlDictionaryString>(new IntPtr(p + 0x158), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9F70 0x158 IntegerLocalName            ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.PositiveIntegerLocalName                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x160), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9F90 0x160 PositiveIntegerLocalName    ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NegativeIntegerLocalName                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x168), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9FB0 0x168 NegativeIntegerLocalName    ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NonPositiveIntegerLocalName               = GetObject<XmlDictionaryString>(new IntPtr(p + 0x170), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9FD0 0x170 NonPositiveIntegerLocalName ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NonNegativeIntegerLocalName               = GetObject<XmlDictionaryString>(new IntPtr(p + 0x178), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC9FF0 0x178 NonNegativeIntegerLocalName ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NormalizedStringLocalName                 = GetObject<XmlDictionaryString>(new IntPtr(p + 0x180), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA010 0x180 NormalizedStringLocalName   ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.TokenLocalName                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x188), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA030 0x188 TokenLocalName              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.LanguageLocalName                         = GetObject<XmlDictionaryString>(new IntPtr(p + 0x190), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA050 0x190 LanguageLocalName           ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NameLocalName                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x198), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA070 0x198 NameLocalName               ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NCNameLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA090 0x1A0 NCNameLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.XSDIDLocalName                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA0B0 0x1A8 XSDIDLocalName              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IDREFLocalName                            = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA0D0 0x1B0 IDREFLocalName              ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IDREFSLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA0F0 0x1B8 IDREFSLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ENTITYLocalName                           = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA110 0x1C0 ENTITYLocalName             ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ENTITIESLocalName                         = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA130 0x1C8 ENTITIESLocalName           ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NMTOKENLocalName                          = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA150 0x1D0 NMTOKENLocalName            ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.NMTOKENSLocalName                         = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA170 0x1D8 NMTOKENSLocalName           ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.AsmxTypesNamespace                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CCA190 0x1E0 AsmxTypesNamespace          ( 0001866BA3C0 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )

            return value;
        }
    }
}
