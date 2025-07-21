using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Document                                 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 018 Source                                   ModelClassType XmlNode XmlNode XmlNode Pointer
    // 020 AttributeIndex                           ModelPrimitiveType int int int Int32
    // 028 NamespaceParent                          ModelClassType XmlElement XmlElement XmlElement Pointer
    public partial class DocumentXPathNavigator : DataModel
    {
        public XmlDocument?                             Document                                { get; set; }
        public XmlNode?                                 Source                                  { get; set; }
        public int                                      AttributeIndex                          { get; set; }
        public XmlElement?                              NamespaceParent                         { get; set; }

        public static DocumentXPathNavigator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DocumentXPathNavigator() { Pointer= p0 };

            value.Document                                  = GetObject<XmlDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDocument.FromPointer); // 0x10 Document                    ( ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Source                                    = GetObject<XmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNode.FromPointer); // 0x18 Source                      ( ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.AttributeIndex                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 AttributeIndex              ( ModelPrimitiveType int int int Int32 )
            value.NamespaceParent                           = GetObject<XmlElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlElement.FromPointer); // 0x28 NamespaceParent             ( ModelClassType XmlElement XmlElement XmlElement Pointer )

            return value;
        }
    }
}
