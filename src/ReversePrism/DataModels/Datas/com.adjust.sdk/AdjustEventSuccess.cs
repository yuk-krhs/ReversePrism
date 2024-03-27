using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Adid                                     000186671910 ModelPrimitiveType string string string String
    // 018 Message                                  000186671910 ModelPrimitiveType string string string String
    // 020 Timestamp                                000186671910 ModelPrimitiveType string string string String
    // 028 EventToken                               000186671910 ModelPrimitiveType string string string String
    // 030 CallbackId                               000186671910 ModelPrimitiveType string string string String
    // 038 <JsonResponse>k__BackingField            Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    public partial class AdjustEventSuccess
    {
        public string                                   Adid                                    { get; set; }
        public string                                   Message                                 { get; set; }
        public string                                   Timestamp                               { get; set; }
        public string                                   EventToken                              { get; set; }
        public string                                   CallbackId                              { get; set; }

        public static AdjustEventSuccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustEventSuccess();

            value.Adid                                      = GetString(new IntPtr(p + 0x010)); // 0270D4C2BAC8 0x10 Adid                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0270D4C2BAE8 0x18 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Timestamp                                 = GetString(new IntPtr(p + 0x020)); // 0270D4C2BB08 0x20 Timestamp                   ( 000186671910 ModelPrimitiveType string string string String )
            value.EventToken                                = GetString(new IntPtr(p + 0x028)); // 0270D4C2BB28 0x28 EventToken                  ( 000186671910 ModelPrimitiveType string string string String )
            value.CallbackId                                = GetString(new IntPtr(p + 0x030)); // 0270D4C2BB48 0x30 CallbackId                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
