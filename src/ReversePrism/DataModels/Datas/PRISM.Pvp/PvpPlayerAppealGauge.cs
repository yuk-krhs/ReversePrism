using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ValueText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Gauge                                    000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 GaugeSizeRect                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 EffectParticle                           0001866EC400 ModelClassType UIParticle UIParticle UIParticle Pointer
    public partial class PvpPlayerAppealGauge
    {
        public UITextMeshProUGUI?                       NameText                                { get; set; }
        public UITextMeshProUGUI?                       ValueText                               { get; set; }
        public RectTransform?                           Gauge                                   { get; set; }
        public RectTransform?                           GaugeSizeRect                           { get; set; }
        public UIParticle?                              EffectParticle                          { get; set; }

        public static PvpPlayerAppealGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPlayerAppealGauge();

            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D50765E8 0x20 NameText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5076608 0x28 ValueText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Gauge                                     = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5076628 0x30 Gauge                       ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GaugeSizeRect                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5076648 0x38 GaugeSizeRect               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.EffectParticle                            = GetObject<UIParticle>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIParticle.FromPointer); // 0270D5076668 0x40 EffectParticle              ( 0001866EC400 ModelClassType UIParticle UIParticle UIParticle Pointer )

            return value;
        }
    }
}
