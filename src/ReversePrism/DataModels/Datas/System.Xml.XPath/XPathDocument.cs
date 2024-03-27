using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PageText                                 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 018 PageXmlNmsp                              000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 020 IdxText                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 IdxXmlNmsp                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 030 HasLineInfo                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 mapNmsp                                  Dictionary`2<XPathNodeRef, XPathNodeRef> IL2CPP_TYPE_GENERICINST
    public partial class XPathDocument
    {
        public List<XPathNode>?                         PageText                                { get; set; }
        public List<XPathNode>?                         PageXmlNmsp                             { get; set; }
        public int                                      IdxText                                 { get; set; }
        public int                                      IdxXmlNmsp                              { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public bool                                     HasLineInfo                             { get; set; }

        public static XPathDocument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathDocument();

            value.PageText                                  = GetEnumList<XPathNode>(new IntPtr(p + 0x010)); // 0270D7497848 0x10 PageText                    ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.PageXmlNmsp                               = GetEnumList<XPathNode>(new IntPtr(p + 0x018)); // 0270D7497868 0x18 PageXmlNmsp                 ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.IdxText                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D7497888 0x20 IdxText                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdxXmlNmsp                                = GetInt32(new IntPtr(p + 0x024)); // 0270D74978A8 0x24 IdxXmlNmsp                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0270D74978C8 0x28 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.HasLineInfo                               = GetBool(new IntPtr(p + 0x030)); // 0270D74978E8 0x30 HasLineInfo                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
