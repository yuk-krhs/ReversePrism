using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 014 FadeType                                 000186736230 ModelEnumType FadeType FadeType FadeType Int32
    // 018 EffectType                               000186735770 ModelEnumType EffectType EffectType EffectType Int32
    public partial class PlayFadeData
    {
        public float                                    Duration                                { get; set; }
        public FadeType                                 FadeType                                { get; set; }
        public EffectType                               EffectType                              { get; set; }

        public static PlayFadeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayFadeData();

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 0270D4DE1978 0x10 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.FadeType                                  = (FadeType)GetInt32(new IntPtr(p + 0x014)); // 0270D4DE1998 0x14 FadeType                    ( 000186736230 ModelEnumType FadeType FadeType FadeType Int32 )
            value.EffectType                                = (EffectType)GetInt32(new IntPtr(p + 0x018)); // 0270D4DE19B8 0x18 EffectType                  ( 000186735770 ModelEnumType EffectType EffectType EffectType Int32 )

            return value;
        }
    }
}
