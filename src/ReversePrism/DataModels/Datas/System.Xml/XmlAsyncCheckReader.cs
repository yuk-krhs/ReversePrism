using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CoreReader                               ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 LastTask                                 ModelClassType Task Task Task Pointer
    public partial class XmlAsyncCheckReader : DataModel
    {
        public XmlReader?                               CoreReader                              { get; set; }
        public Task?                                    LastTask                                { get; set; }

        public static XmlAsyncCheckReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAsyncCheckReader() { Pointer= p0 };

            value.CoreReader                                = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0x10 CoreReader                  ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.LastTask                                  = GetObject<Task>(new IntPtr(p + 0x018), ReversePrism.DataModels.Task.FromPointer); // 0x18 LastTask                    ( ModelClassType Task Task Task Pointer )

            return value;
        }
    }
}
