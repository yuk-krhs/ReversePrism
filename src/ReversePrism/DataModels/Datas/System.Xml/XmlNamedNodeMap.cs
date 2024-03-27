using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 018 Nodes                                    00018673A060 ModelEnumType SmallXmlNodeList SmallXmlNodeList SmallXmlNodeList Int32
    public partial class XmlNamedNodeMap
    {
        public XmlNode?                                 Parent                                  { get; set; }
        public SmallXmlNodeList                         Nodes                                   { get; set; }

        public static XmlNamedNodeMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNamedNodeMap();

            value.Parent                                    = GetObject<XmlNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNode.FromPointer); // 0270D743FF70 0x10 Parent                      ( 0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.Nodes                                     = (SmallXmlNodeList)GetInt32(new IntPtr(p + 0x018)); // 0270D743FF90 0x18 Nodes                       ( 00018673A060 ModelEnumType SmallXmlNodeList SmallXmlNodeList SmallXmlNodeList Int32 )

            return value;
        }
    }
}
