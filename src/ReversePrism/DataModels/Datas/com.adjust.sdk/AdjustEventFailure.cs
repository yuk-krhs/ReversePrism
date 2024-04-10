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
    // 038 WillRetry                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 <JsonResponse>k__BackingField            Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    public partial class AdjustEventFailure : DataModel
    {
        public string                                   Adid                                    { get; set; }
        public string                                   Message                                 { get; set; }
        public string                                   Timestamp                               { get; set; }
        public string                                   EventToken                              { get; set; }
        public string                                   CallbackId                              { get; set; }
        public bool                                     WillRetry                               { get; set; }

        public static AdjustEventFailure? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustEventFailure() { Pointer= p0 };

            value.Adid                                      = GetString(new IntPtr(p + 0x010)); // 024664C8F510 0x10 Adid                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 024664C8F530 0x18 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Timestamp                                 = GetString(new IntPtr(p + 0x020)); // 024664C8F550 0x20 Timestamp                   ( 000186671910 ModelPrimitiveType string string string String )
            value.EventToken                                = GetString(new IntPtr(p + 0x028)); // 024664C8F570 0x28 EventToken                  ( 000186671910 ModelPrimitiveType string string string String )
            value.CallbackId                                = GetString(new IntPtr(p + 0x030)); // 024664C8F590 0x30 CallbackId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.WillRetry                                 = GetBool(new IntPtr(p + 0x038)); // 024664C8F5B0 0x38 WillRetry                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
