using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 028 LastChild                                00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    public partial class XmlEntityReference
    {
        public string                                   Name                                    { get; set; }
        public XmlLinkedNode?                           LastChild                               { get; set; }

        public static XmlEntityReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlEntityReference();

            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D7450EF0 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0270D7450F10 0x28 LastChild                   ( 00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
