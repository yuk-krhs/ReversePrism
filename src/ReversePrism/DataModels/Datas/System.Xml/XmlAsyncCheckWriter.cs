using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 CoreWriter                               0001865D7520 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 020 LastTask                                 000186680E70 ModelClassType Task Task Task Pointer
    public partial class XmlAsyncCheckWriter
    {
        public XmlWriter?                               CoreWriter                              { get; set; }
        public Task?                                    LastTask                                { get; set; }

        public static XmlAsyncCheckWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckWriter();

            value.CoreWriter                                = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 0270D739A4F8 0x18 CoreWriter                  ( 0001865D7520 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.LastTask                                  = GetObject<Task>(new IntPtr(p + 0x020), ReversePrism.DataModels.Task.FromPointer); // 0270D739A518 0x20 LastTask                    ( 000186680E70 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
