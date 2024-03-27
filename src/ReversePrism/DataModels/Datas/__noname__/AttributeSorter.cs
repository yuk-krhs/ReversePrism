using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Writer                                   00018658EFD0 ModelClassType XmlCanonicalWriter XmlCanonicalWriter XmlCanonicalWriter Pointer
    public partial class AttributeSorter
    {
        public XmlCanonicalWriter?                      Writer                                  { get; set; }

        public static AttributeSorter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeSorter();

            value.Writer                                    = GetObject<XmlCanonicalWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlCanonicalWriter.FromPointer); // 0270D7C60F00 0x10 Writer                      ( 00018658EFD0 ModelClassType XmlCanonicalWriter XmlCanonicalWriter XmlCanonicalWriter Pointer )

            return value;
        }
    }
}
