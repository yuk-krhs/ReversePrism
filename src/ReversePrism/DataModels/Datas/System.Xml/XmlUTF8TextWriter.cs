using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 Writer                                   0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    public partial class XmlUTF8TextWriter
    {
        public XmlUTF8NodeWriter?                       Writer                                  { get; set; }

        public static XmlUTF8TextWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUTF8TextWriter();

            value.Writer                                    = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 0270D7CB4490 0xA0 Writer                      ( 0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )

            return value;
        }
    }
}
