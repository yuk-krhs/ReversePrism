using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ValueText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 Gauge                                    ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 GaugeSizeRect                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 EffectParticle                           ModelClassType UIParticle UIParticle UIParticle Pointer
    public partial class PvpPlayerAppealGauge : DataModel
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
            var value   = new PvpPlayerAppealGauge() { Pointer= p0 };

            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 NameText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ValueText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Gauge                                     = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 Gauge                       ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GaugeSizeRect                             = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 GaugeSizeRect               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.EffectParticle                            = GetObject<UIParticle>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIParticle.FromPointer); // 0x40 EffectParticle              ( ModelClassType UIParticle UIParticle UIParticle Pointer )

            return value;
        }
    }
}
