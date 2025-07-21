using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   ModelClassType MonoBtlsHandle MonoBtlsHandle MonoBtlsHandle Pointer
    // 018 LastError                                ModelClassType Exception Exception Exception Pointer
    public partial class MonoBtlsObject : DataModel
    {
        public MonoBtlsHandle?                          Handle                                  { get; set; }
        public Exception?                               LastError                               { get; set; }

        public static MonoBtlsObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsObject() { Pointer= p0 };

            value.Handle                                    = GetObject<MonoBtlsHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.MonoBtlsHandle.FromPointer); // 0x10 Handle                      ( ModelClassType MonoBtlsHandle MonoBtlsHandle MonoBtlsHandle Pointer )
            value.LastError                                 = GetObject<Exception>(new IntPtr(p + 0x018), ReversePrism.DataModels.Exception.FromPointer); // 0x18 LastError                   ( ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
