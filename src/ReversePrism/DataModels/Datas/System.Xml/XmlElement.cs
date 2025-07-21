using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     ModelClassType XmlName XmlName XmlName Pointer
    // 028 Attributes                               ModelClassType XmlAttributeCollection XmlAttributeCollection XmlAttributeCollection Pointer
    // 030 LastChild                                ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
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

            value.Name                                      = GetObject<XmlName>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlName.FromPointer); // 0x20 Name                        ( ModelClassType XmlName XmlName XmlName Pointer )
            value.Attributes                                = GetObject<XmlAttributeCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlAttributeCollection.FromPointer); // 0x28 Attributes                  ( ModelClassType XmlAttributeCollection XmlAttributeCollection XmlAttributeCollection Pointer )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0x30 LastChild                   ( ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
