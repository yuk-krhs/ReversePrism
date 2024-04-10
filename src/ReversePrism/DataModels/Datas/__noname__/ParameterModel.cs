using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParameterType                            00018660E8C0 ModelEnumType ProduceParameterType ProduceParameterType ProduceParameterType Int32
    // 018 RankUpDownAnimator                       0001866B92A0 ModelClassType Animator Animator Animator Pointer
    // 020 RankUpAlphabetAnimator                   0001866B92A0 ModelClassType Animator Animator Animator Pointer
    // 028 RankUpAlphabetAnimatorEvent              0001866BC0F0 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 030 TextValue                                0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RankUpDownType                           0001865612D0 ModelEnumType RankUpDownType RankUpDownType RankUpDownType Int32
    public partial class ParameterModel : DataModel
    {
        public ProduceParameterType                     ParameterType                           { get; set; }
        public Animator?                                RankUpDownAnimator                      { get; set; }
        public Animator?                                RankUpAlphabetAnimator                  { get; set; }
        public AnimatorWithEvent?                       RankUpAlphabetAnimatorEvent             { get; set; }
        public UITextMeshProUGUI?                       TextValue                               { get; set; }
        public RankUpDownType                           RankUpDownType                          { get; set; }

        public static ParameterModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterModel() { Pointer= p0 };

            value.ParameterType                             = (ProduceParameterType)GetInt32(new IntPtr(p + 0x010)); // 024665D81C68 0x10 ParameterType               ( 00018660E8C0 ModelEnumType ProduceParameterType ProduceParameterType ProduceParameterType Int32 )
            value.RankUpDownAnimator                        = GetObject<Animator>(new IntPtr(p + 0x018), ReversePrism.DataModels.Animator.FromPointer); // 024665D81C88 0x18 RankUpDownAnimator          ( 0001866B92A0 ModelClassType Animator Animator Animator Pointer )
            value.RankUpAlphabetAnimator                    = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 024665D81CA8 0x20 RankUpAlphabetAnimator      ( 0001866B92A0 ModelClassType Animator Animator Animator Pointer )
            value.RankUpAlphabetAnimatorEvent               = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 024665D81CC8 0x28 RankUpAlphabetAnimatorEvent ( 0001866BC0F0 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.TextValue                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D81CE8 0x30 TextValue                   ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankUpDownType                            = (RankUpDownType)GetInt32(new IntPtr(p + 0x038)); // 024665D81D08 0x38 RankUpDownType              ( 0001865612D0 ModelEnumType RankUpDownType RankUpDownType RankUpDownType Int32 )

            return value;
        }
    }
}
