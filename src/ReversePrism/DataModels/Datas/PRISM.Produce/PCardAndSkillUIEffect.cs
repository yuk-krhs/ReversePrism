using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoveTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 EffectAnimator                           ModelClassType Animator Animator Animator Pointer
    // 030 TaskCaches                               ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer
    // 038 AnimationSpeed                           ModelPrimitiveType float float float Single
    // 040 Tweener                                  ModelClassType Tweener Tweener Tweener Pointer
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

            value.MoveTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 MoveTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.EffectAnimator                            = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 EffectAnimator              ( ModelClassType Animator Animator Animator Pointer )
            value.TaskCaches                                = GetEnumList<UniTask>(new IntPtr(p + 0x030)); // 0x30 TaskCaches                  ( ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x038)); // 0x38 AnimationSpeed              ( ModelPrimitiveType float float float Single )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x040), ReversePrism.DataModels.Tweener.FromPointer); // 0x40 Tweener                     ( ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
