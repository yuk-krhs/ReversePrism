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
    public partial class XmlEntityReference : DataModel
    {
        public string                                   Name                                    { get; set; }
        public XmlLinkedNode?                           LastChild                               { get; set; }

        public static XmlEntityReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlEntityReference() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0246674B0EF0 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0246674B0F10 0x28 LastChild                   ( 00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
