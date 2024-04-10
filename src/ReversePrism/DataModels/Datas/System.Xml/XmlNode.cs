using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParentNode                               0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer
    public partial class XmlNode : DataModel
    {
        public XmlNode?                                 ParentNode                              { get; set; }

        public static XmlNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNode() { Pointer= p0 };

            value.ParentNode                                = GetObject<XmlNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNode.FromPointer); // 0245A4CD4E18 0x10 ParentNode                  ( 0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer )

            return value;
        }
    }
}
