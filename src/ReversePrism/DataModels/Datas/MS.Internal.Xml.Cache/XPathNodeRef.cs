using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Page                                     000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 018 Idx                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XPathNodeRef : DataModel
    {
        public List<XPathNode>?                         Page                                    { get; set; }
        public int                                      Idx                                     { get; set; }

        public static XPathNodeRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathNodeRef() { Pointer= p0 };

            value.Page                                      = GetEnumList<XPathNode>(new IntPtr(p + 0x010)); // 024667503E70 0x10 Page                        ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.Idx                                       = GetInt32(new IntPtr(p + 0x018)); // 024667503E90 0x18 Idx                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
