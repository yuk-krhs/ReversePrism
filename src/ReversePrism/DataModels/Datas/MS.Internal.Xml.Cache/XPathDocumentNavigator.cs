using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PageCurrent                              000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 018 PageParent                               000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 020 IdxCurrent                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 IdxParent                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XPathDocumentNavigator : DataModel
    {
        public List<XPathNode>?                         PageCurrent                             { get; set; }
        public List<XPathNode>?                         PageParent                              { get; set; }
        public int                                      IdxCurrent                              { get; set; }
        public int                                      IdxParent                               { get; set; }

        public static XPathDocumentNavigator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathDocumentNavigator() { Pointer= p0 };

            value.PageCurrent                               = GetEnumList<XPathNode>(new IntPtr(p + 0x010)); // 02466769EFE8 0x10 PageCurrent                 ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.PageParent                                = GetEnumList<XPathNode>(new IntPtr(p + 0x018)); // 02466769F008 0x18 PageParent                  ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.IdxCurrent                                = GetInt32(new IntPtr(p + 0x020)); // 02466769F028 0x20 IdxCurrent                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdxParent                                 = GetInt32(new IntPtr(p + 0x024)); // 02466769F048 0x24 IdxParent                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
