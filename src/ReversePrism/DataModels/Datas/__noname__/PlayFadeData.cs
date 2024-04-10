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
    public partial class PlayFadeData : DataModel
    {
        public float                                    Duration                                { get; set; }
        public FadeType                                 FadeType                                { get; set; }
        public EffectType                               EffectType                              { get; set; }

        public static PlayFadeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayFadeData() { Pointer= p0 };

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 024664E460C0 0x10 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.FadeType                                  = (FadeType)GetInt32(new IntPtr(p + 0x014)); // 024664E460E0 0x14 FadeType                    ( 000186736230 ModelEnumType FadeType FadeType FadeType Int32 )
            value.EffectType                                = (EffectType)GetInt32(new IntPtr(p + 0x018)); // 024664E46100 0x18 EffectType                  ( 000186735770 ModelEnumType EffectType EffectType EffectType Int32 )

            return value;
        }
    }
}
