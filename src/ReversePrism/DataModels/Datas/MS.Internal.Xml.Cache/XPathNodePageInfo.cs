using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PageNum                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 NodeCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 PageNext                                 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer
    public partial class XPathNodePageInfo
    {
        public int                                      PageNum                                 { get; set; }
        public int                                      NodeCount                               { get; set; }
        public List<XPathNode>?                         PageNext                                { get; set; }

        public static XPathNodePageInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathNodePageInfo();

            value.PageNum                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D7630318 0x10 PageNum                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NodeCount                                 = GetInt32(new IntPtr(p + 0x014)); // 0270D7630338 0x14 NodeCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PageNext                                  = GetEnumList<XPathNode>(new IntPtr(p + 0x018)); // 0270D7630358 0x18 PageNext                    ( 000185B84EC0 ModelEnumListType XPathNode[] XPathNode[] List<XPathNode> Pointer )

            return value;
        }
    }
}
