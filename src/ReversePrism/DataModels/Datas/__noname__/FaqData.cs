using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uid                                      000186671910 ModelPrimitiveType string string string String
    // 018 Dt                                       000186671910 ModelPrimitiveType string string string String
    // 020 Tm                                       000186671910 ModelPrimitiveType string string string String
    // 028 Rid                                      000186671910 ModelPrimitiveType string string string String
    public partial class FaqData
    {
        public string                                   Uid                                     { get; set; }
        public string                                   Dt                                      { get; set; }
        public string                                   Tm                                      { get; set; }
        public string                                   Rid                                     { get; set; }

        public static FaqData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaqData();

            value.Uid                                       = GetString(new IntPtr(p + 0x010)); // 0270D4BBE4C8 0x10 Uid                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Dt                                        = GetString(new IntPtr(p + 0x018)); // 0270D4BBE4E8 0x18 Dt                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Tm                                        = GetString(new IntPtr(p + 0x020)); // 0270D4BBE508 0x20 Tm                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Rid                                       = GetString(new IntPtr(p + 0x028)); // 0270D4BBE528 0x28 Rid                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
