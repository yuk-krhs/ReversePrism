using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PageText                                 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 018 PageXmlNmsp                              ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 020 IdxText                                  ModelPrimitiveType int int int Int32
    // 024 IdxXmlNmsp                               ModelPrimitiveType int int int Int32
    // 028 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 030 HasLineInfo                              ModelPrimitiveType bool bool bool Bool
    // 038 mapNmsp                                  Dictionary`2<XPathNodeRef, XPathNodeRef> IL2CPP_TYPE_GENERICINST
    public partial class XPathDocument : DataModel
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
            var value   = new XPathDocument() { Pointer= p0 };

            value.PageText                                  = GetEnumList<XPathNode>(new IntPtr(p + 0x010)); // 0x10 PageText                    ( ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.PageXmlNmsp                               = GetEnumList<XPathNode>(new IntPtr(p + 0x018)); // 0x18 PageXmlNmsp                 ( ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.IdxText                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 IdxText                     ( ModelPrimitiveType int int int Int32 )
            value.IdxXmlNmsp                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 IdxXmlNmsp                  ( ModelPrimitiveType int int int Int32 )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x28 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.HasLineInfo                               = GetBool(new IntPtr(p + 0x030)); // 0x30 HasLineInfo                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
