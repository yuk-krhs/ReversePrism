using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Container                                0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    public partial class XmlChildNodes
    {
        public XmlNode?                                 Container                               { get; set; }

        public static XmlChildNodes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlChildNodes();

            value.Container                                 = GetObject<XmlNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNode.FromPointer); // 0270D744BB00 0x10 Container                   ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )

            return value;
        }
    }
}
