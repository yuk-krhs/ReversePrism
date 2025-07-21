using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlObject                                ModelClassType XObject XObject XObject Pointer
    public partial class XObjectWrapper : DataModel
    {
        public XObject?                                 XmlObject                               { get; set; }

        public static XObjectWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XObjectWrapper() { Pointer= p0 };

            value.XmlObject                                 = GetObject<XObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.XObject.FromPointer); // 0x10 XmlObject                   ( ModelClassType XObject XObject XObject Pointer )

            return value;
        }
    }
}
