using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Alert                                    ModelClassType Alert Alert Alert Pointer
    public partial class TlsException : DataModel
    {
        public Alert?                                   Alert                                   { get; set; }

        public static TlsException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TlsException() { Pointer= p0 };

            value.Alert                                     = GetObject<Alert>(new IntPtr(p + 0x090), ReversePrism.DataModels.Alert.FromPointer); // 0x90 Alert                       ( ModelClassType Alert Alert Alert Pointer )

            return value;
        }
    }
}
