using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               0001865AA0B0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 LastTask                                 000186680E70 ModelClassType Task Task Task Pointer
    public partial class XmlAsyncCheckReader
    {
        public XmlReader?                               CoreReader                              { get; set; }
        public Task?                                    LastTask                                { get; set; }

        public static XmlAsyncCheckReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReader();

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0270D73808D8 0x10 CoreReader                  ( 0001865AA0B0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.LastTask                                  = GetObject<Task>(new IntPtr(p + 0x018), ReversePrism.DataModels.Task.FromPointer); // 0270D73808F8 0x18 LastTask                    ( 000186680E70 ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
