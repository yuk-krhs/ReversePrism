using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Name                                     00018659FF60 ModelClassType XmlName XmlName XmlName Pointer
    // 020 LastChild                                00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    public partial class XmlAttribute
    {
        public XmlName?                                 Name                                    { get; set; }
        public XmlLinkedNode?                           LastChild                               { get; set; }

        public static XmlAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAttribute();

            value.Name                                      = GetObject<XmlName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlName.FromPointer); // 0270D7449E60 0x18 Name                        ( 00018659FF60 ModelClassType XmlName XmlName XmlName Pointer )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0270D7449E80 0x20 LastChild                   ( 00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
