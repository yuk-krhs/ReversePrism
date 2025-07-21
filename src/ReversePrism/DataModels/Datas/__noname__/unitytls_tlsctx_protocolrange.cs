using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      ModelEnumType unitytls_protocol unitytls_protocol unitytls_protocol Int32
    // 014 Max                                      ModelEnumType unitytls_protocol unitytls_protocol unitytls_protocol Int32
    public partial class unitytls_tlsctx_protocolrange : DataModel
    {
        public unitytls_protocol                        Min                                     { get; set; }
        public unitytls_protocol                        Max                                     { get; set; }

        public static unitytls_tlsctx_protocolrange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_tlsctx_protocolrange() { Pointer= p0 };

            value.Min                                       = (unitytls_protocol)GetInt32(new IntPtr(p + 0x010)); // 0x10 Min                         ( ModelEnumType unitytls_protocol unitytls_protocol unitytls_protocol Int32 )
            value.Max                                       = (unitytls_protocol)GetInt32(new IntPtr(p + 0x014)); // 0x14 Max                         ( ModelEnumType unitytls_protocol unitytls_protocol unitytls_protocol Int32 )

            return value;
        }
    }
}
