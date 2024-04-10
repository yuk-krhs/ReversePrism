using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     00018659FF60 ModelClassType XmlName XmlName XmlName Pointer
    // 028 Attributes                               0001866B9B30 ModelClassType XmlAttributeCollection XmlAttributeCollection XmlAttributeCollection Pointer
    // 030 LastChild                                00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    public partial class XmlElement : DataModel
    {
        public XmlName?                                 Name                                    { get; set; }
        public XmlAttributeCollection?                  Attributes                              { get; set; }
        public XmlLinkedNode?                           LastChild                               { get; set; }

        public static XmlElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlElement() { Pointer= p0 };

            value.Name                                      = GetObject<XmlName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlName.FromPointer); // 02466749DFF0 0x20 Name                        ( 00018659FF60 ModelClassType XmlName XmlName XmlName Pointer )
            value.Attributes                                = GetObject<XmlAttributeCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlAttributeCollection.FromPointer); // 02466749E010 0x28 Attributes                  ( 0001866B9B30 ModelClassType XmlAttributeCollection XmlAttributeCollection XmlAttributeCollection Pointer )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 02466749E030 0x30 LastChild                   ( 00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
