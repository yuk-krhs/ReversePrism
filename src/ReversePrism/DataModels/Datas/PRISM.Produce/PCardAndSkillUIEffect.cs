using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoveTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 EffectAnimator                           0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 TaskCaches                               000185D196D8 ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer
    // 038 AnimationSpeed                           0001866656B0 ModelPrimitiveType float float float Single
    // 040 Tweener                                  0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    public partial class PCardAndSkillUIEffect : DataModel
    {
        public RectTransform?                           MoveTransform                           { get; set; }
        public Animator?                                EffectAnimator                          { get; set; }
        public List<UniTask>?                           TaskCaches                              { get; set; }
        public float                                    AnimationSpeed                          { get; set; }
        public Tweener?                                 Tweener                                 { get; set; }

        public static PCardAndSkillUIEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardAndSkillUIEffect() { Pointer= p0 };

            value.MoveTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 024665B407E0 0x20 MoveTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.EffectAnimator                            = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 024665B40800 0x28 EffectAnimator              ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TaskCaches                                = GetEnumList<UniTask>(new IntPtr(p + 0x030)); // 024665B40820 0x30 TaskCaches                  ( 000185D196D8 ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x038)); // 024665B40840 0x38 AnimationSpeed              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x040), ReversePrism.DataModels.Tweener.FromPointer); // 024665B40860 0x40 Tweener                     ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
