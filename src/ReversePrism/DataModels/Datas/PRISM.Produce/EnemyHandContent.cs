using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AttackActionTime                         float IL2CPP_TYPE_R4
    // 020 ShowPCardObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ShowPCardContent                         0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer
    // 030 ShowPCardAnimator                        0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 DrawCardPrefab                           0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 040 SpaceKeeperPrefab                        0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 048 HandParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 CardDisplayModels                        000185D22718 ModelClassListType List`1<PCardDisplayModel> List`1<PCardDisplayModel> List<PCardDisplayModel> Pointer
    // 058 EffectPoint                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 060 ShowCardTokenSource                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 068 DrawCardTokenSource                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 AnimationSpeed                           0001866656B0 ModelPrimitiveType float float float Single
    // 078 WaitDurationTask                         0001865409D0 ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer
    public partial class EnemyHandContent
    {
        public GameObject?                              ShowPCardObject                         { get; set; }
        public InGamePCardContent?                      ShowPCardContent                        { get; set; }
        public Animator?                                ShowPCardAnimator                       { get; set; }
        public Animator?                                DrawCardPrefab                          { get; set; }
        public Animator?                                SpaceKeeperPrefab                       { get; set; }
        public Transform?                               HandParent                              { get; set; }
        public List<PCardDisplayModel>?                 CardDisplayModels                       { get; set; }
        public Transform?                               EffectPoint                             { get; set; }
        public CancellationTokenSource?                 ShowCardTokenSource                     { get; set; }
        public CancellationTokenSource?                 DrawCardTokenSource                     { get; set; }
        public float                                    AnimationSpeed                          { get; set; }
        public WaitDurationTask?                        WaitDurationTask                        { get; set; }

        public static EnemyHandContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnemyHandContent();

            value.ShowPCardObject                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D59D88A8 0x20 ShowPCardObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ShowPCardContent                          = GetObject<InGamePCardContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.InGamePCardContent.FromPointer); // 0270D59D88C8 0x28 ShowPCardContent            ( 0001866D6110 ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer )
            value.ShowPCardAnimator                         = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0270D59D88E8 0x30 ShowPCardAnimator           ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.DrawCardPrefab                            = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0270D59D8908 0x38 DrawCardPrefab              ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SpaceKeeperPrefab                         = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0270D59D8928 0x40 SpaceKeeperPrefab           ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.HandParent                                = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0270D59D8948 0x48 HandParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CardDisplayModels                         = GetObjectList<PCardDisplayModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.PCardDisplayModel.FromPointer); // 0270D59D8968 0x50 CardDisplayModels           ( 000185D22718 ModelClassListType List`1<PCardDisplayModel> List`1<PCardDisplayModel> List<PCardDisplayModel> Pointer )
            value.EffectPoint                               = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0270D59D8988 0x58 EffectPoint                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ShowCardTokenSource                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D59D89A8 0x60 ShowCardTokenSource         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.DrawCardTokenSource                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D59D89C8 0x68 DrawCardTokenSource         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x070)); // 0270D59D89E8 0x70 AnimationSpeed              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.WaitDurationTask                          = GetObject<WaitDurationTask>(new IntPtr(p + 0x078), ReversePrism.DataModels.WaitDurationTask.FromPointer); // 0270D59D8A08 0x78 WaitDurationTask            ( 0001865409D0 ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer )

            return value;
        }
    }
}
