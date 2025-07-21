using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PageNum                                  ModelPrimitiveType int int int Int32
    // 014 NodeCount                                ModelPrimitiveType int int int Int32
    // 018 PageNext                                 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    public partial class XPathNodePageInfo : DataModel
    {
        public int                                      PageNum                                 { get; set; }
        public int                                      NodeCount                               { get; set; }
        public List<XPathNode>?                         PageNext                                { get; set; }

        public static XPathNodePageInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathNodePageInfo() { Pointer= p0 };

            value.PageNum                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 PageNum                     ( ModelPrimitiveType int int int Int32 )
            value.NodeCount                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 NodeCount                   ( ModelPrimitiveType int int int Int32 )
            value.PageNext                                  = GetEnumList<XPathNode>(new IntPtr(p + 0x018)); // 0x18 PageNext                    ( ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )

            return value;
        }
    }
}
