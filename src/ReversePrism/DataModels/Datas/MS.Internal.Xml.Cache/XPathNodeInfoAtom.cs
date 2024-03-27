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
    // 028 PageParent                               000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 030 PageSibling                              000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 038 Doc                                      00018657DB50 ModelClassType XPathDocument XPathDocument XPathDocument Pointer
    // 040 LineNumBase                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 LinePosBase                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 PageInfo                                 00018657FBA0 ModelClassType XPathNodePageInfo XPathNodePageInfo XPathNodePageInfo Pointer
    public partial class XPathNodeInfoAtom
    {
        public string                                   LocalName                               { get; set; }
        public string                                   NamespaceUri                            { get; set; }
        public string                                   Prefix                                  { get; set; }
        public List<XPathNode>?                         PageParent                              { get; set; }
        public List<XPathNode>?                         PageSibling                             { get; set; }
        public XPathDocument?                           Doc                                     { get; set; }
        public int                                      LineNumBase                             { get; set; }
        public int                                      LinePosBase                             { get; set; }
        public XPathNodePageInfo?                       PageInfo                                { get; set; }

        public static XPathNodeInfoAtom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathNodeInfoAtom();

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0270D7627DD0 0x10 LocalName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0270D7627DF0 0x18 NamespaceUri                ( 000186671910 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0270D7627E10 0x20 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.PageParent                                = GetEnumList<XPathNode>(new IntPtr(p + 0x028)); // 0270D7627E30 0x28 PageParent                  ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.PageSibling                               = GetEnumList<XPathNode>(new IntPtr(p + 0x030)); // 0270D7627E50 0x30 PageSibling                 ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.Doc                                       = GetObject<XPathDocument>(new IntPtr(p + 0x038), ReversePrism.DataModels.XPathDocument.FromPointer); // 0270D7627E70 0x38 Doc                         ( 00018657DB50 ModelClassType XPathDocument XPathDocument XPathDocument Pointer )
            value.LineNumBase                               = GetInt32(new IntPtr(p + 0x040)); // 0270D7627E90 0x40 LineNumBase                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePosBase                               = GetInt32(new IntPtr(p + 0x044)); // 0270D7627EB0 0x44 LinePosBase                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PageInfo                                  = GetObject<XPathNodePageInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.XPathNodePageInfo.FromPointer); // 0270D7627ED0 0x48 PageInfo                    ( 00018657FBA0 ModelClassType XPathNodePageInfo XPathNodePageInfo XPathNodePageInfo Pointer )

            return value;
        }
    }
}
