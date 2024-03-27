using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 xmlAttributes                            IList`1<XmlAttribute> IL2CPP_TYPE_GENERICINST
    // 058 xmlChildNodes                            IList`1<XmlNode> IL2CPP_TYPE_GENERICINST
    // 060 OwnerDocument                            000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    public partial class XmlDataNode
    {
        public XmlDocument?                             OwnerDocument                           { get; set; }

        public static XmlDataNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDataNode();

            value.OwnerDocument                             = GetObject<XmlDocument>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlDocument.FromPointer); // 0270D7D36550 0x60 OwnerDocument               ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )

            return value;
        }
    }
}
