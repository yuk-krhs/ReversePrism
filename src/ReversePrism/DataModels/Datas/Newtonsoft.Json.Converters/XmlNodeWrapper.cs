using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Node                                     0001866BB590 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 018 ChildNodes                               000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer
    // 020 Attributes                               000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer
    public partial class XmlNodeWrapper : DataModel
    {
        public XmlNode?                                 Node                                    { get; set; }
        public List<IXmlNode>?                          ChildNodes                              { get; set; }
        public List<IXmlNode>?                          Attributes                              { get; set; }

        public static XmlNodeWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeWrapper() { Pointer= p0 };

            value.Node                                      = GetObject<XmlNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNode.FromPointer); // 0246688AF110 0x10 Node                        ( 0001866BB590 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.ChildNodes                                = GetObjectList<IXmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.IXmlNode.FromPointer); // 0246688AF130 0x18 ChildNodes                  ( 000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer )
            value.Attributes                                = GetObjectList<IXmlNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNode.FromPointer); // 0246688AF150 0x20 Attributes                  ( 000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer )

            return value;
        }
    }
}
