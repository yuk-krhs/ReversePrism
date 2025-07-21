using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InCreaseAppealTypeColorStrings           Dictionary`2<ProduceParameterType, string> IL2CPP_TYPE_GENERICINST
    // 000 InCreaseDefaultColorString               string IL2CPP_TYPE_STRING
    // 000 DeCreaseDefaultColorString               string IL2CPP_TYPE_STRING
    // 078 ValueTextArea                            ModelClassType GameObject GameObject GameObject Pointer
    // 080 milestones                               IList`1<int> IL2CPP_TYPE_GENERICINST
    // 088 BaseAppealMilestone                      ModelClassType GameObject GameObject GameObject Pointer
    // 090 MaxAppealMilestone                       ModelClassType GameObject GameObject GameObject Pointer
    // 098 AppealMilestoneArea                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 AppealHigherMilStoneColor                ModelEnumType Color Color Color Int32
    // 0B0 AppealLowerMilStoneColor                 ModelEnumType Color Color Color Int32
    // 0C0 EffectParticle                           ModelClassType UIParticle UIParticle UIParticle Pointer
    // 0C8 milstoneTextPairs                        Dictionary`2<int, UITextMeshProUGUI> IL2CPP_TYPE_GENERICINST
    public partial class AppealPointGaugeContent : DataModel
    {
        public GameObject?                              ValueTextArea                           { get; set; }
        public GameObject?                              BaseAppealMilestone                     { get; set; }
        public GameObject?                              MaxAppealMilestone                      { get; set; }
        public RectTransform?                           AppealMilestoneArea                     { get; set; }
        public Color                                    AppealHigherMilStoneColor               { get; set; }
        public Color                                    AppealLowerMilStoneColor                { get; set; }
        public UIParticle?                              EffectParticle                          { get; set; }

        public static AppealPointGaugeContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppealPointGaugeContent() { Pointer= p0 };

            value.ValueTextArea                             = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 ValueTextArea               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BaseAppealMilestone                       = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 BaseAppealMilestone         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MaxAppealMilestone                        = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 MaxAppealMilestone          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AppealMilestoneArea                       = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0x98 AppealMilestoneArea         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AppealHigherMilStoneColor                 = (Color)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 AppealHigherMilStoneColor   ( ModelEnumType Color Color Color Int32 )
            value.AppealLowerMilStoneColor                  = (Color)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 AppealLowerMilStoneColor    ( ModelEnumType Color Color Color Int32 )
            value.EffectParticle                            = GetObject<UIParticle>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UIParticle.FromPointer); // 0xC0 EffectParticle              ( ModelClassType UIParticle UIParticle UIParticle Pointer )

            return value;
        }
    }
}
