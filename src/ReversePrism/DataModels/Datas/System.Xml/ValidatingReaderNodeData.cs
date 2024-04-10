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
    public partial class ValidatingReaderNodeData : DataModel
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
            var value   = new ValidatingReaderNodeData() { Pointer= p0 };

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0246673D7738 0x10 LocalName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0246673D7758 0x18 NamespaceUri                ( 000186671910 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0246673D7778 0x20 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.NameWPrefix                               = GetString(new IntPtr(p + 0x028)); // 0246673D7798 0x28 NameWPrefix                 ( 000186671910 ModelPrimitiveType string string string String )
            value.RawValue                                  = GetString(new IntPtr(p + 0x030)); // 0246673D77B8 0x30 RawValue                    ( 000186671910 ModelPrimitiveType string string string String )
            value.OriginalStringValue                       = GetString(new IntPtr(p + 0x038)); // 0246673D77D8 0x38 OriginalStringValue         ( 000186671910 ModelPrimitiveType string string string String )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x040)); // 0246673D77F8 0x40 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributePSVIInfo                         = GetObject<AttributePSVIInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.AttributePSVIInfo.FromPointer); // 0246673D7818 0x48 AttributePSVIInfo           ( 000186712D60 ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x050)); // 0246673D7838 0x50 NodeType                    ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.LineNo                                    = GetInt32(new IntPtr(p + 0x054)); // 0246673D7858 0x54 LineNo                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x058)); // 0246673D7878 0x58 LinePos                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
