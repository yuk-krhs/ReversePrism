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
    // 028 WillRetry                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 <JsonResponse>k__BackingField            Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    public partial class AdjustSessionFailure
    {
        public string                                   Adid                                    { get; set; }
        public string                                   Message                                 { get; set; }
        public string                                   Timestamp                               { get; set; }
        public bool                                     WillRetry                               { get; set; }

        public static AdjustSessionFailure? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustSessionFailure();

            value.Adid                                      = GetString(new IntPtr(p + 0x010)); // 0270D4C2D1F8 0x10 Adid                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0270D4C2D218 0x18 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Timestamp                                 = GetString(new IntPtr(p + 0x020)); // 0270D4C2D238 0x20 Timestamp                   ( 000186671910 ModelPrimitiveType string string string String )
            value.WillRetry                                 = GetBool(new IntPtr(p + 0x028)); // 0270D4C2D258 0x28 WillRetry                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
