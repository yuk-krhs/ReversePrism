using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 LastChild                                00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer
    public partial class XmlDocumentFragment : DataModel
    {
        public XmlLinkedNode?                           LastChild                               { get; set; }

        public static XmlDocumentFragment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDocumentFragment() { Pointer= p0 };

            value.LastChild                                 = GetObject<XmlLinkedNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlLinkedNode.FromPointer); // 0246674AF2E0 0x18 LastChild                   ( 00018659E450 ModelClassType XmlLinkedNode XmlLinkedNode XmlLinkedNode Pointer )

            return value;
        }
    }
}
