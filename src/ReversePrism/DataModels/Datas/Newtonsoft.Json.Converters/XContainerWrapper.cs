using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ChildNodes                               000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer
    public partial class XContainerWrapper : DataModel
    {
        public List<IXmlNode>?                          ChildNodes                              { get; set; }

        public static XContainerWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XContainerWrapper() { Pointer= p0 };

            value.ChildNodes                                = GetObjectList<IXmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.IXmlNode.FromPointer); // 0246688C2278 0x18 ChildNodes                  ( 000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer )

            return value;
        }
    }
}
