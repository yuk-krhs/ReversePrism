using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Next                                     00018659E6F0 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    public partial class XmlLinkedNode
    {
        public XmlLinkedNode?                           Next                                    { get; set; }

        public static XmlLinkedNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlLinkedNode();

            value.Next                                      = GetObject<XmlLinkedNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0270D743CCF0 0x18 Next                        ( 00018659E6F0 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
