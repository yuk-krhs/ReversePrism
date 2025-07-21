using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EffectPoint                              ModelClassType Transform Transform Transform Pointer
    // 028 ExecuteCard                              ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer
    // 030 ExclusionCardPrefab                      ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer
    // 038 ExclusionCardParent                      ModelClassType Transform Transform Transform Pointer
    // 040 ExclusionCards                           ModelClassListType List`1<RemoveHandAnimationContent> List`1<RemoveHandAnimationContent> List<RemoveHandAnimationContent> Pointer
    // 048 ExclusionEffect                          ModelClassType GameObject GameObject GameObject Pointer
    // 050 ExclusionEffectAnimator                  ModelClassType Animator Animator Animator Pointer
    // 058 TaskCaches                               ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer
    // 060 ExecCardAnimationCTS                     ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 068 ExclusionAnimationCTS                    ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 Speed                                    ModelPrimitiveType float float float Single
    public partial class RemoveHandAnimationController : DataModel
    {
        public Transform?                               EffectPoint                             { get; set; }
        public RemoveHandAnimationContent?              ExecuteCard                             { get; set; }
        public RemoveHandAnimationContent?              ExclusionCardPrefab                     { get; set; }
        public Transform?                               ExclusionCardParent                     { get; set; }
        public List<RemoveHandAnimationContent>?        ExclusionCards                          { get; set; }
        public GameObject?                              ExclusionEffect                         { get; set; }
        public Animator?                                ExclusionEffectAnimator                 { get; set; }
        public List<UniTask>?                           TaskCaches                              { get; set; }
        public CancellationTokenSource?                 ExecCardAnimationCTS                    { get; set; }
        public CancellationTokenSource?                 ExclusionAnimationCTS                   { get; set; }
        public float                                    Speed                                   { get; set; }

        public static RemoveHandAnimationController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoveHandAnimationController() { Pointer= p0 };

            value.EffectPoint                               = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 EffectPoint                 ( ModelClassType Transform Transform Transform Pointer )
            value.ExecuteCard                               = GetObject<RemoveHandAnimationContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.RemoveHandAnimationContent.FromPointer); // 0x28 ExecuteCard                 ( ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer )
            value.ExclusionCardPrefab                       = GetObject<RemoveHandAnimationContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.RemoveHandAnimationContent.FromPointer); // 0x30 ExclusionCardPrefab         ( ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer )
            value.ExclusionCardParent                       = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 ExclusionCardParent         ( ModelClassType Transform Transform Transform Pointer )
            value.ExclusionCards                            = GetObjectList<RemoveHandAnimationContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.RemoveHandAnimationContent.FromPointer); // 0x40 ExclusionCards              ( ModelClassListType List`1<RemoveHandAnimationContent> List`1<RemoveHandAnimationContent> List<RemoveHandAnimationContent> Pointer )
            value.ExclusionEffect                           = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 ExclusionEffect             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExclusionEffectAnimator                   = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0x50 ExclusionEffectAnimator     ( ModelClassType Animator Animator Animator Pointer )
            value.TaskCaches                                = GetEnumList<UniTask>(new IntPtr(p + 0x058)); // 0x58 TaskCaches                  ( ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer )
            value.ExecCardAnimationCTS                      = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x60 ExecCardAnimationCTS        ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ExclusionAnimationCTS                     = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x68 ExclusionAnimationCTS       ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Speed                                     = GetSingle(new IntPtr(p + 0x070)); // 0x70 Speed                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
