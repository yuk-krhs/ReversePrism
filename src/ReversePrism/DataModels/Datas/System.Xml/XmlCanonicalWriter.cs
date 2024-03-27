using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Writer                                   0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    // 018 ElementStream                            0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer
    // 020 ElementBuffer                            000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 ElementWriter                            0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    // 030 InStartElement                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Scopes                                   000185CC7168 ModelEnumListType Scope[] Scope[] List<Scope> Pointer
    // 040 XmlnsAttributeCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 XmlnsAttributes                          000185CC7388 ModelEnumListType XmlnsAttribute[] XmlnsAttribute[] List<XmlnsAttribute> Pointer
    // 050 AttributeCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 Attributes                               000185CC6F48 ModelEnumListType Attribute[] Attribute[] List<Attribute> Pointer
    // 060 Attribute                                000186720E60 ModelEnumType Attribute Attribute Attribute Int32
    // 080 Element                                  000186730E70 ModelEnumType Element Element Element Int32
    // 090 XmlnsBuffer                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 098 XmlnsOffset                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 maxBytesPerChar                          int IL2CPP_TYPE_I4
    // 09C XmlnsStartOffset                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 IncludeComments                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 InclusivePrefixes                        000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 000 xmlnsNamespace                           string IL2CPP_TYPE_STRING
    // 000 isEscapedAttributeChar                   bool[] IL2CPP_TYPE_SZARRAY
    // 008 isEscapedElementChar                     bool[] IL2CPP_TYPE_SZARRAY
    public partial class XmlCanonicalWriter
    {
        public XmlUTF8NodeWriter?                       Writer                                  { get; set; }
        public MemoryStream?                            ElementStream                           { get; set; }
        public List<sbyte>?                             ElementBuffer                           { get; set; }
        public XmlUTF8NodeWriter?                       ElementWriter                           { get; set; }
        public bool                                     InStartElement                          { get; set; }
        public int                                      Depth                                   { get; set; }
        public List<Scope>?                             Scopes                                  { get; set; }
        public int                                      XmlnsAttributeCount                     { get; set; }
        public List<XmlnsAttribute>?                    XmlnsAttributes                         { get; set; }
        public int                                      AttributeCount                          { get; set; }
        public List<Attribute>?                         Attributes                              { get; set; }
        public Attribute                                Attribute                               { get; set; }
        public Element                                  Element                                 { get; set; }
        public List<sbyte>?                             XmlnsBuffer                             { get; set; }
        public int                                      XmlnsOffset                             { get; set; }
        public int                                      XmlnsStartOffset                        { get; set; }
        public bool                                     IncludeComments                         { get; set; }
        public List<string>?                            InclusivePrefixes                       { get; set; }

        public static XmlCanonicalWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlCanonicalWriter();

            value.Writer                                    = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 0270D7C15D18 0x10 Writer                      ( 0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )
            value.ElementStream                             = GetObject<MemoryStream>(new IntPtr(p + 0x018), ReversePrism.DataModels.MemoryStream.FromPointer); // 0270D7C15D38 0x18 ElementStream               ( 0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer )
            value.ElementBuffer                             = GetSByteList(new IntPtr(p + 0x020)); // 0270D7C15D58 0x20 ElementBuffer               ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ElementWriter                             = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 0270D7C15D78 0x28 ElementWriter               ( 0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )
            value.InStartElement                            = GetBool(new IntPtr(p + 0x030)); // 0270D7C15D98 0x30 InStartElement              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x034)); // 0270D7C15DB8 0x34 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Scopes                                    = GetEnumList<Scope>(new IntPtr(p + 0x038)); // 0270D7C15DD8 0x38 Scopes                      ( 000185CC7168 ModelEnumListType Scope[] Scope[] List<Scope> Pointer )
            value.XmlnsAttributeCount                       = GetInt32(new IntPtr(p + 0x040)); // 0270D7C15DF8 0x40 XmlnsAttributeCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.XmlnsAttributes                           = GetEnumList<XmlnsAttribute>(new IntPtr(p + 0x048)); // 0270D7C15E18 0x48 XmlnsAttributes             ( 000185CC7388 ModelEnumListType XmlnsAttribute[] XmlnsAttribute[] List<XmlnsAttribute> Pointer )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x050)); // 0270D7C15E38 0x50 AttributeCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetEnumList<Attribute>(new IntPtr(p + 0x058)); // 0270D7C15E58 0x58 Attributes                  ( 000185CC6F48 ModelEnumListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.Attribute                                 = (Attribute)GetInt32(new IntPtr(p + 0x060)); // 0270D7C15E78 0x60 Attribute                   ( 000186720E60 ModelEnumType Attribute Attribute Attribute Int32 )
            value.Element                                   = (Element)GetInt32(new IntPtr(p + 0x080)); // 0270D7C15E98 0x80 Element                     ( 000186730E70 ModelEnumType Element Element Element Int32 )
            value.XmlnsBuffer                               = GetSByteList(new IntPtr(p + 0x090)); // 0270D7C15EB8 0x90 XmlnsBuffer                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.XmlnsOffset                               = GetInt32(new IntPtr(p + 0x098)); // 0270D7C15ED8 0x98 XmlnsOffset                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.XmlnsStartOffset                          = GetInt32(new IntPtr(p + 0x09C)); // 0270D7C15F18 0x9C XmlnsStartOffset            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IncludeComments                           = GetBool(new IntPtr(p + 0x0A0)); // 0270D7C15F38 0xA0 IncludeComments             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InclusivePrefixes                         = GetStringList(new IntPtr(p + 0x0A8)); // 0270D7C15F58 0xA8 InclusivePrefixes           ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
