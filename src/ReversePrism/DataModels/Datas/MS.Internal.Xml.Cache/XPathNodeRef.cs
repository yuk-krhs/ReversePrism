using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Page                                     ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    // 018 Idx                                      ModelPrimitiveType int int int Int32
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

            value.Page                                      = GetEnumList<XPathNode>(new IntPtr(p + 0x010)); // 0x10 Page                        ( ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )
            value.Idx                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Idx                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
