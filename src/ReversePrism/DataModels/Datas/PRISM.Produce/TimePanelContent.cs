using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TimeUIs                                  ModelClassListType TimeUI[] TimeUI[] List<TimeUI> Pointer
    // 028 CurrentState                             ModelEnumType TimeState TimeState TimeState Int32
    // 030 AnimEffectText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 EffectAnimator                           ModelClassType Animator Animator Animator Pointer
    // 040 LastCountDownTime                        ModelPrimitiveType int int int Int32
    // 048 LastCountDownAnimator                    ModelClassType Animator Animator Animator Pointer
    // 050 IsLesson                                 ModelPrimitiveType bool bool bool Bool
    // 054 LastTime                                 ModelPrimitiveType int int int Int32
    public partial class TimePanelContent : DataModel
    {
        public List<TimeUI>?                            TimeUIs                                 { get; set; }
        public TimeState                                CurrentState                            { get; set; }
        public UITextMeshProUGUI?                       AnimEffectText                          { get; set; }
        public Animator?                                EffectAnimator                          { get; set; }
        public int                                      LastCountDownTime                       { get; set; }
        public Animator?                                LastCountDownAnimator                   { get; set; }
        public bool                                     IsLesson                                { get; set; }
        public int                                      LastTime                                { get; set; }

        public static TimePanelContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimePanelContent() { Pointer= p0 };

            value.TimeUIs                                   = GetObjectList<TimeUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TimeUI.FromPointer); // 0x20 TimeUIs                     ( ModelClassListType TimeUI[] TimeUI[] List<TimeUI> Pointer )
            value.CurrentState                              = (TimeState)GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentState                ( ModelEnumType TimeState TimeState TimeState Int32 )
            value.AnimEffectText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 AnimEffectText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EffectAnimator                            = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 EffectAnimator              ( ModelClassType Animator Animator Animator Pointer )
            value.LastCountDownTime                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 LastCountDownTime           ( ModelPrimitiveType int int int Int32 )
            value.LastCountDownAnimator                     = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 0x48 LastCountDownAnimator       ( ModelClassType Animator Animator Animator Pointer )
            value.IsLesson                                  = GetBool(new IntPtr(p + 0x050)); // 0x50 IsLesson                    ( ModelPrimitiveType bool bool bool Bool )
            value.LastTime                                  = GetInt32(new IntPtr(p + 0x054)); // 0x54 LastTime                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
