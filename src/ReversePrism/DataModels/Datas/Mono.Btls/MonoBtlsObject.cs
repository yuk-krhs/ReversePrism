using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   00018673EEC0 ModelClassType MonoBtlsHandle MonoBtlsHandle MonoBtlsHandle Pointer
    // 018 LastError                                0001865CA820 ModelClassType Exception Exception Exception Pointer
    public partial class MonoBtlsObject
    {
        public MonoBtlsHandle?                          Handle                                  { get; set; }
        public Exception?                               LastError                               { get; set; }

        public static MonoBtlsObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsObject();

            value.Handle                                    = GetObject<MonoBtlsHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.MonoBtlsHandle.FromPointer); // 0270D793DD88 0x10 Handle                      ( 00018673EEC0 ModelClassType MonoBtlsHandle MonoBtlsHandle MonoBtlsHandle Pointer )
            value.LastError                                 = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0270D793DDA8 0x18 LastError                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
