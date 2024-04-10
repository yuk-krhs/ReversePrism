using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Document                                 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 018 Source                                   0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 020 AttributeIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 NamespaceParent                          000186597700 ModelClassType XmlElement XmlElement XmlElement Pointer
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

            value.Document                                  = GetObject<XmlDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDocument.FromPointer); // 024667499760 0x10 Document                    ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.Source                                    = GetObject<XmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNode.FromPointer); // 024667499780 0x18 Source                      ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.AttributeIndex                            = GetInt32(new IntPtr(p + 0x020)); // 0246674997A0 0x20 AttributeIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NamespaceParent                           = GetObject<XmlElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlElement.FromPointer); // 0246674997C0 0x28 NamespaceParent             ( 000186597700 ModelClassType XmlElement XmlElement XmlElement Pointer )

            return value;
        }
    }
}
