using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    public partial class XmlImplementation : DataModel
    {
        public XmlNameTable?                            NameTable                               { get; set; }

        public static XmlImplementation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlImplementation() { Pointer= p0 };

            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x10 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )

            return value;
        }
    }
}
