using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Attributes                               000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer
    public partial class XElementWrapper
    {
        public List<IXmlNode>?                          Attributes                              { get; set; }

        public static XElementWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XElementWrapper();

            value.Attributes                                = GetObjectList<IXmlNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.IXmlNode.FromPointer); // 0270D8881190 0x20 Attributes                  ( 000185CEA488 ModelClassListType List`1<IXmlNode> List`1<IXmlNode> List<IXmlNode> Pointer )

            return value;
        }
    }
}
