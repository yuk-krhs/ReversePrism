using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TimeUIs                                  000185CC4638 ModelClassListType TimeUI[] TimeUI[] List<TimeUI> Pointer
    // 028 CurrentState                             000186604A80 ModelEnumType TimeState TimeState TimeState Int32
    // 030 AnimEffectText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 EffectAnimator                           0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 LastCountDownTime                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 LastCountDownAnimator                    0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 050 IsLesson                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 LastTime                                 0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.TimeUIs                                   = GetObjectList<TimeUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TimeUI.FromPointer); // 024665CDB558 0x20 TimeUIs                     ( 000185CC4638 ModelClassListType TimeUI[] TimeUI[] List<TimeUI> Pointer )
            value.CurrentState                              = (TimeState)GetInt32(new IntPtr(p + 0x028)); // 024665CDB578 0x28 CurrentState                ( 000186604A80 ModelEnumType TimeState TimeState TimeState Int32 )
            value.AnimEffectText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665CDB598 0x30 AnimEffectText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EffectAnimator                            = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 024665CDB5B8 0x38 EffectAnimator              ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.LastCountDownTime                         = GetInt32(new IntPtr(p + 0x040)); // 024665CDB5D8 0x40 LastCountDownTime           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastCountDownAnimator                     = GetObject<Animator>(new IntPtr(p + 0x048), ReversePrism.DataModels.Animator.FromPointer); // 024665CDB5F8 0x48 LastCountDownAnimator       ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.IsLesson                                  = GetBool(new IntPtr(p + 0x050)); // 024665CDB618 0x50 IsLesson                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastTime                                  = GetInt32(new IntPtr(p + 0x054)); // 024665CDB638 0x54 LastTime                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
