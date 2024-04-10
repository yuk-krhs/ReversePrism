using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 RawWriter                                0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer
    public partial class XmlRawWriterBase64Encoder : DataModel
    {
        public XmlRawWriter?                            RawWriter                               { get; set; }

        public static XmlRawWriterBase64Encoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlRawWriterBase64Encoder() { Pointer= p0 };

            value.RawWriter                                 = GetObject<XmlRawWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlRawWriter.FromPointer); // 024667398078 0x28 RawWriter                   ( 0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer )

            return value;
        }
    }
}
