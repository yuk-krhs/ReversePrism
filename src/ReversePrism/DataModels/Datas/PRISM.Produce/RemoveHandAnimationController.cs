using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EffectPoint                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 ExecuteCard                              00018664D710 ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer
    // 030 ExclusionCardPrefab                      00018664D710 ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer
    // 038 ExclusionCardParent                      0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 040 ExclusionCards                           000185D01478 ModelClassListType List`1<RemoveHandAnimationContent> List`1<RemoveHandAnimationContent> List<RemoveHandAnimationContent> Pointer
    // 048 ExclusionEffect                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ExclusionEffectAnimator                  0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 058 TaskCaches                               000185D196D8 ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer
    // 060 ExecCardAnimationCTS                     0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 068 ExclusionAnimationCTS                    0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 ExclusionEffectCTS                       0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 Speed                                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class RemoveHandAnimationController
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
        public CancellationTokenSource?                 ExclusionEffectCTS                      { get; set; }
        public float                                    Speed                                   { get; set; }

        public static RemoveHandAnimationController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemoveHandAnimationController();

            value.EffectPoint                               = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270D5B104F0 0x20 EffectPoint                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ExecuteCard                               = GetObject<RemoveHandAnimationContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.RemoveHandAnimationContent.FromPointer); // 0270D5B10510 0x28 ExecuteCard                 ( 00018664D710 ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer )
            value.ExclusionCardPrefab                       = GetObject<RemoveHandAnimationContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.RemoveHandAnimationContent.FromPointer); // 0270D5B10530 0x30 ExclusionCardPrefab         ( 00018664D710 ModelClassType RemoveHandAnimationContent RemoveHandAnimationContent RemoveHandAnimationContent Pointer )
            value.ExclusionCardParent                       = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0270D5B10550 0x38 ExclusionCardParent         ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ExclusionCards                            = GetObjectList<RemoveHandAnimationContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.RemoveHandAnimationContent.FromPointer); // 0270D5B10570 0x40 ExclusionCards              ( 000185D01478 ModelClassListType List`1<RemoveHandAnimationContent> List`1<RemoveHandAnimationContent> List<RemoveHandAnimationContent> Pointer )
            value.ExclusionEffect                           = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5B10590 0x48 ExclusionEffect             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExclusionEffectAnimator                   = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0270D5B105B0 0x50 ExclusionEffectAnimator     ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.TaskCaches                                = GetEnumList<UniTask>(new IntPtr(p + 0x058)); // 0270D5B105D0 0x58 TaskCaches                  ( 000185D196D8 ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer )
            value.ExecCardAnimationCTS                      = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5B105F0 0x60 ExecCardAnimationCTS        ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ExclusionAnimationCTS                     = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5B10610 0x68 ExclusionAnimationCTS       ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ExclusionEffectCTS                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5B10630 0x70 ExclusionEffectCTS          ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Speed                                     = GetSingle(new IntPtr(p + 0x078)); // 0270D5B10650 0x78 Speed                       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
