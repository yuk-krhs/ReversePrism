using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Read                                     ModelClassType unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback Pointer
    // 018 Write                                    ModelClassType unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback Pointer
    // 020 data                                     IntPtr IL2CPP_TYPE_PTR
    public partial class unitytls_tlsctx_callbacks : DataModel
    {
        public unitytls_tlsctx_read_callback?           Read                                    { get; set; }
        public unitytls_tlsctx_write_callback?          Write                                   { get; set; }

        public static unitytls_tlsctx_callbacks? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_tlsctx_callbacks() { Pointer= p0 };

            value.Read                                      = GetObject<unitytls_tlsctx_read_callback>(new IntPtr(p + 0x010), ReversePrism.DataModels.unitytls_tlsctx_read_callback.FromPointer); // 0x10 Read                        ( ModelClassType unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback unitytls_tlsctx_read_callback Pointer )
            value.Write                                     = GetObject<unitytls_tlsctx_write_callback>(new IntPtr(p + 0x018), ReversePrism.DataModels.unitytls_tlsctx_write_callback.FromPointer); // 0x18 Write                       ( ModelClassType unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback unitytls_tlsctx_write_callback Pointer )

            return value;
        }
    }
}
