using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Container                                0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 018 Child                                    0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 020 IsFirst                                  000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class XmlChildEnumerator : DataModel
    {
        public XmlNode?                                 Container                               { get; set; }
        public XmlNode?                                 Child                                   { get; set; }
        public bool                                     IsFirst                                 { get; set; }

        public static XmlChildEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlChildEnumerator() { Pointer= p0 };

            value.Container                                 = GetObject<XmlNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNode.FromPointer); // 0246674AB808 0x10 Container                   ( 0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.Child                                     = GetObject<XmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNode.FromPointer); // 0246674AB828 0x18 Child                       ( 0001866BB360 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.IsFirst                                   = GetBool(new IntPtr(p + 0x020)); // 0246674AB848 0x20 IsFirst                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
