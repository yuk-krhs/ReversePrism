using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferedProxy                            00018650D220 ModelClassType BufferedSavedataProxy BufferedSavedataProxy BufferedSavedataProxy Pointer
    // 018 Prefix                                   000186672F10 ModelPrimitiveType string string string String
    // 020 keyCache                                 Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ScopedSavedataProxy
    {
        public BufferedSavedataProxy?                   BufferedProxy                           { get; set; }
        public string                                   Prefix                                  { get; set; }

        public static ScopedSavedataProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScopedSavedataProxy();

            value.BufferedProxy                             = GetObject<BufferedSavedataProxy>(new IntPtr(p + 0x010), ReversePrism.DataModels.BufferedSavedataProxy.FromPointer); // 027003DCAF20 0x10 BufferedProxy               ( 00018650D220 ModelClassType BufferedSavedataProxy BufferedSavedataProxy BufferedSavedataProxy Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 027003DCAF40 0x18 Prefix                      ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
