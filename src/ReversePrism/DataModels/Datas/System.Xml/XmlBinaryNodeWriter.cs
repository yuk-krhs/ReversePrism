using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Dictionary                               ModelClassType IXmlDictionary IXmlDictionary IXmlDictionary Pointer
    // 048 Session                                  ModelClassType XmlBinaryWriterSession XmlBinaryWriterSession XmlBinaryWriterSession Pointer
    // 050 InAttribute                              ModelPrimitiveType bool bool bool Bool
    // 051 InList                                   ModelPrimitiveType bool bool bool Bool
    // 052 WroteAttributeValue                      ModelPrimitiveType bool bool bool Bool
    // 058 AttributeValue                           ModelEnumType AttributeValue AttributeValue AttributeValue Int32
    // 000 maxBytesPerChar                          int IL2CPP_TYPE_I4
    // 070 TextNodeOffset                           ModelPrimitiveType int int int Int32
    public partial class XmlBinaryNodeWriter : DataModel
    {
        public IXmlDictionary?                          Dictionary                              { get; set; }
        public XmlBinaryWriterSession?                  Session                                 { get; set; }
        public bool                                     InAttribute                             { get; set; }
        public bool                                     InList                                  { get; set; }
        public bool                                     WroteAttributeValue                     { get; set; }
        public AttributeValue                           AttributeValue                          { get; set; }
        public int                                      TextNodeOffset                          { get; set; }

        public static XmlBinaryNodeWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlBinaryNodeWriter() { Pointer= p0 };

            value.Dictionary                                = GetObject<IXmlDictionary>(new IntPtr(p + 0x040), ReversePrism.DataModels.IXmlDictionary.FromPointer); // 0x40 Dictionary                  ( ModelClassType IXmlDictionary IXmlDictionary IXmlDictionary Pointer )
            value.Session                                   = GetObject<XmlBinaryWriterSession>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlBinaryWriterSession.FromPointer); // 0x48 Session                     ( ModelClassType XmlBinaryWriterSession XmlBinaryWriterSession XmlBinaryWriterSession Pointer )
            value.InAttribute                               = GetBool(new IntPtr(p + 0x050)); // 0x50 InAttribute                 ( ModelPrimitiveType bool bool bool Bool )
            value.InList                                    = GetBool(new IntPtr(p + 0x051)); // 0x51 InList                      ( ModelPrimitiveType bool bool bool Bool )
            value.WroteAttributeValue                       = GetBool(new IntPtr(p + 0x052)); // 0x52 WroteAttributeValue         ( ModelPrimitiveType bool bool bool Bool )
            value.AttributeValue                            = (AttributeValue)GetInt32(new IntPtr(p + 0x058)); // 0x58 AttributeValue              ( ModelEnumType AttributeValue AttributeValue AttributeValue Int32 )
            value.TextNodeOffset                            = GetInt32(new IntPtr(p + 0x070)); // 0x70 TextNodeOffset              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
