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
    // 028 PageParent                               ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 030 PageSibling                              ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 038 Doc                                      ModelClassType XPathDocument XPathDocument XPathDocument Pointer
    // 040 LineNumBase                              ModelPrimitiveType int int int Int32
    // 044 LinePosBase                              ModelPrimitiveType int int int Int32
    // 048 PageInfo                                 ModelClassType XPathNodePageInfo XPathNodePageInfo XPathNodePageInfo Pointer
    public partial class XPathNodeInfoAtom : DataModel
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
            var value   = new XPathNodeInfoAtom() { Pointer= p0 };

            value.LocalName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 LocalName                   ( ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0x18 NamespaceUri                ( ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Prefix                      ( ModelPrimitiveType string string string String )
            value.PageParent                                = GetEnumList<XPathNode>(new IntPtr(p + 0x028)); // 0x28 PageParent                  ( ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.PageSibling                               = GetEnumList<XPathNode>(new IntPtr(p + 0x030)); // 0x30 PageSibling                 ( ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.Doc                                       = GetObject<XPathDocument>(new IntPtr(p + 0x038), ReversePrism.DataModels.XPathDocument.FromPointer); // 0x38 Doc                         ( ModelClassType XPathDocument XPathDocument XPathDocument Pointer )
            value.LineNumBase                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 LineNumBase                 ( ModelPrimitiveType int int int Int32 )
            value.LinePosBase                               = GetInt32(new IntPtr(p + 0x044)); // 0x44 LinePosBase                 ( ModelPrimitiveType int int int Int32 )
            value.PageInfo                                  = GetObject<XPathNodePageInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.XPathNodePageInfo.FromPointer); // 0x48 PageInfo                    ( ModelClassType XPathNodePageInfo XPathNodePageInfo XPathNodePageInfo Pointer )

            return value;
        }
    }
}
