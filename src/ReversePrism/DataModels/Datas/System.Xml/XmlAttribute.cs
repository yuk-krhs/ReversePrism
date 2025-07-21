using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Name                                     ModelClassType XmlName XmlName XmlName Pointer
    // 020 LastChild                                ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    public partial class XmlAttribute : DataModel
    {
        public XmlName?                                 Name                                    { get; set; }
        public XmlLinkedNode?                           LastChild                               { get; set; }

        public static XmlAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAttribute() { Pointer= p0 };

            value.Name                                      = GetObject<XmlName>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlName.FromPointer); // 0x18 Name                        ( ModelClassType XmlName XmlName XmlName Pointer )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0x20 LastChild                   ( ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
