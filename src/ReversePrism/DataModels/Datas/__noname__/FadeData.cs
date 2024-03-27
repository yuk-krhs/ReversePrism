using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 018 FadeType                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 EffectType                               0001866722E0 ModelPrimitiveType string string string String
    public partial class FadeData
    {
        public float                                    Duration                                { get; set; }
        public string                                   FadeType                                { get; set; }
        public string                                   EffectType                              { get; set; }

        public static FadeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FadeData();

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 0270D4DE1778 0x10 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.FadeType                                  = GetString(new IntPtr(p + 0x018)); // 0270D4DE1798 0x18 FadeType                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.EffectType                                = GetString(new IntPtr(p + 0x020)); // 0270D4DE17B8 0x20 EffectType                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
