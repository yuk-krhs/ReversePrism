using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalName                                000186671910 ModelPrimitiveType string string string String
    // 018 NamespaceUri                             000186671910 ModelPrimitiveType string string string String
    // 020 Prefix                                   000186671910 ModelPrimitiveType string string string String
    // 028 NameWPrefix                              000186671910 ModelPrimitiveType string string string String
    // 030 RawValue                                 000186671910 ModelPrimitiveType string string string String
    // 038 OriginalStringValue                      000186671910 ModelPrimitiveType string string string String
    // 040 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 AttributePSVIInfo                        000186712D60 ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer
    // 050 NodeType                                 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 054 LineNo                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 LinePos                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ValidatingReaderNodeData
    {
        public string                                   LocalName                               { get; set; }
        public string                                   NamespaceUri                            { get; set; }
        public string                                   Prefix                                  { get; set; }
        public string                                   NameWPrefix                             { get; set; }
        public string                                   RawValue                                { get; set; }
        public string                                   OriginalStringValue                     { get; set; }
        public int                                      Depth                                   { get; set; }
        public AttributePSVIInfo?                       AttributePSVIInfo                       { get; set; }
        public XmlNodeType                              NodeType                                { get; set; }
        public int                                      LineNo                                  { get; set; }
        public int                                      LinePos                                 { get; set; }

        public static ValidatingReaderNodeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValidatingReaderNodeData();

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0270D737F738 0x10 LocalName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0270D737F758 0x18 NamespaceUri                ( 000186671910 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0270D737F778 0x20 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.NameWPrefix                               = GetString(new IntPtr(p + 0x028)); // 0270D737F798 0x28 NameWPrefix                 ( 000186671910 ModelPrimitiveType string string string String )
            value.RawValue                                  = GetString(new IntPtr(p + 0x030)); // 0270D737F7B8 0x30 RawValue                    ( 000186671910 ModelPrimitiveType string string string String )
            value.OriginalStringValue                       = GetString(new IntPtr(p + 0x038)); // 0270D737F7D8 0x38 OriginalStringValue         ( 000186671910 ModelPrimitiveType string string string String )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x040)); // 0270D737F7F8 0x40 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributePSVIInfo                         = GetObject<AttributePSVIInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.AttributePSVIInfo.FromPointer); // 0270D737F818 0x48 AttributePSVIInfo           ( 000186712D60 ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x050)); // 0270D737F838 0x50 NodeType                    ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.LineNo                                    = GetInt32(new IntPtr(p + 0x054)); // 0270D737F858 0x54 LineNo                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x058)); // 0270D737F878 0x58 LinePos                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
