using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalName                                ModelPrimitiveType string string string String
    // 018 NamespaceUri                             ModelPrimitiveType string string string String
    // 020 Prefix                                   ModelPrimitiveType string string string String
    // 028 NameWPrefix                              ModelPrimitiveType string string string String
    // 030 RawValue                                 ModelPrimitiveType string string string String
    // 038 OriginalStringValue                      ModelPrimitiveType string string string String
    // 040 Depth                                    ModelPrimitiveType int int int Int32
    // 048 AttributePSVIInfo                        ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer
    // 050 NodeType                                 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 054 LineNo                                   ModelPrimitiveType int int int Int32
    // 058 LinePos                                  ModelPrimitiveType int int int Int32
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

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 LocalName                   ( ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0x18 NamespaceUri                ( ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Prefix                      ( ModelPrimitiveType string string string String )
            value.NameWPrefix                               = GetString(new IntPtr(p + 0x028)); // 0x28 NameWPrefix                 ( ModelPrimitiveType string string string String )
            value.RawValue                                  = GetString(new IntPtr(p + 0x030)); // 0x30 RawValue                    ( ModelPrimitiveType string string string String )
            value.OriginalStringValue                       = GetString(new IntPtr(p + 0x038)); // 0x38 OriginalStringValue         ( ModelPrimitiveType string string string String )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Depth                       ( ModelPrimitiveType int int int Int32 )
            value.AttributePSVIInfo                         = GetObject<AttributePSVIInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.AttributePSVIInfo.FromPointer); // 0x48 AttributePSVIInfo           ( ModelClassType AttributePSVIInfo AttributePSVIInfo AttributePSVIInfo Pointer )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x050)); // 0x50 NodeType                    ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.LineNo                                    = GetInt32(new IntPtr(p + 0x054)); // 0x54 LineNo                      ( ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x058)); // 0x58 LinePos                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
