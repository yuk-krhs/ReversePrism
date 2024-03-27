using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Xmlreader                                0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    public partial class DataTextReader
    {
        public XmlReader?                               Xmlreader                               { get; set; }

        public static DataTextReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTextReader();

            value.Xmlreader                                 = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0270D897CBF8 0x10 Xmlreader                   ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )

            return value;
        }
    }
}
