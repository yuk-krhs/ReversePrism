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
    // 078 ValueTextArea                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 milestones                               IList`1<int> IL2CPP_TYPE_GENERICINST
    // 088 BaseAppealMilestone                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 MaxAppealMilestone                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 AppealMilestoneArea                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A0 AppealHigherMilStoneColor                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0B0 AppealLowerMilStoneColor                 0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0C0 EffectParticle                           0001866EC400 ModelClassType UIParticle UIParticle UIParticle Pointer
    // 0C8 milstoneTextPairs                        Dictionary`2<int, UITextMeshProUGUI> IL2CPP_TYPE_GENERICINST
    public partial class AppealPointGaugeContent
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
            var value   = new AppealPointGaugeContent();

            value.ValueTextArea                             = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5AC58E8 0x78 ValueTextArea               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BaseAppealMilestone                       = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5AC5928 0x88 BaseAppealMilestone         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MaxAppealMilestone                        = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5AC5948 0x90 MaxAppealMilestone          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AppealMilestoneArea                       = GetObject<RectTransform>(new IntPtr(p + 0x098), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5AC5968 0x98 AppealMilestoneArea         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AppealHigherMilStoneColor                 = (Color)GetInt32(new IntPtr(p + 0x0A0)); // 0270D5AC5988 0xA0 AppealHigherMilStoneColor   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.AppealLowerMilStoneColor                  = (Color)GetInt32(new IntPtr(p + 0x0B0)); // 0270D5AC59A8 0xB0 AppealLowerMilStoneColor    ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.EffectParticle                            = GetObject<UIParticle>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UIParticle.FromPointer); // 0270D5AC59C8 0xC0 EffectParticle              ( 0001866EC400 ModelClassType UIParticle UIParticle UIParticle Pointer )

            return value;
        }
    }
}
