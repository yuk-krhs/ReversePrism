using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyChildNodes                          List`1<IXmlNode> IL2CPP_TYPE_GENERICINST
    // 000 TextName                                 string IL2CPP_TYPE_STRING
    // 000 CommentName                              string IL2CPP_TYPE_STRING
    // 000 CDataName                                string IL2CPP_TYPE_STRING
    // 000 WhitespaceName                           string IL2CPP_TYPE_STRING
    // 000 SignificantWhitespaceName                string IL2CPP_TYPE_STRING
    // 000 DeclarationName                          string IL2CPP_TYPE_STRING
    // 000 JsonNamespaceUri                         string IL2CPP_TYPE_STRING
    // 010 DeserializeRootElementName               000186671910 ModelPrimitiveType string string string String
    // 018 WriteArrayAttribute                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 OmitRootObject                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A EncodeSpecialCharacters                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlNodeConverter : DataModel
    {
        public string                                   DeserializeRootElementName              { get; set; }
        public bool                                     WriteArrayAttribute                     { get; set; }
        public bool                                     OmitRootObject                          { get; set; }
        public bool                                     EncodeSpecialCharacters                 { get; set; }

        public static XmlNodeConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeConverter() { Pointer= p0 };

            value.DeserializeRootElementName                = GetString(new IntPtr(p + 0x010)); // 0245A3B8B5A0 0x10 DeserializeRootElementName  ( 000186671910 ModelPrimitiveType string string string String )
            value.WriteArrayAttribute                       = GetBool(new IntPtr(p + 0x018)); // 0245A3B8B5C0 0x18 WriteArrayAttribute         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OmitRootObject                            = GetBool(new IntPtr(p + 0x019)); // 0245A3B8B5E0 0x19 OmitRootObject              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EncodeSpecialCharacters                   = GetBool(new IntPtr(p + 0x01A)); // 0245A3B8B600 0x1A EncodeSpecialCharacters     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
