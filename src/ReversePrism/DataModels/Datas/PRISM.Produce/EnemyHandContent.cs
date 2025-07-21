using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AttackActionTime                         float IL2CPP_TYPE_R4
    // 020 ShowPCardObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 028 ShowPCardContent                         ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer
    // 030 ShowPCardAnimator                        ModelClassType Animator Animator Animator Pointer
    // 038 DrawCardPrefab                           ModelClassType Animator Animator Animator Pointer
    // 040 SpaceKeeperPrefab                        ModelClassType Animator Animator Animator Pointer
    // 048 HandParent                               ModelClassType Transform Transform Transform Pointer
    // 050 CardDisplayModels                        ModelClassListType List`1<PCardDisplayModel> List`1<PCardDisplayModel> List<PCardDisplayModel> Pointer
    // 058 EffectPoint                              ModelClassType Transform Transform Transform Pointer
    // 060 ShowCardTokenSource                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 068 DrawCardTokenSource                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 AnimationSpeed                           ModelPrimitiveType float float float Single
    // 078 WaitDurationTask                         ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer
    public partial class EnemyHandContent : DataModel
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
            var value   = new EnemyHandContent() { Pointer= p0 };

            value.ShowPCardObject                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ShowPCardObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShowPCardContent                          = GetObject<InGamePCardContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.InGamePCardContent.FromPointer); // 0x28 ShowPCardContent            ( ModelClassType InGamePCardContent InGamePCardContent InGamePCardContent Pointer )
            value.ShowPCardAnimator                         = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 ShowPCardAnimator           ( ModelClassType Animator Animator Animator Pointer )
            value.DrawCardPrefab                            = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 DrawCardPrefab              ( ModelClassType Animator Animator Animator Pointer )
            value.SpaceKeeperPrefab                         = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0x40 SpaceKeeperPrefab           ( ModelClassType Animator Animator Animator Pointer )
            value.HandParent                                = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 HandParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.CardDisplayModels                         = GetObjectList<PCardDisplayModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.PCardDisplayModel.FromPointer); // 0x50 CardDisplayModels           ( ModelClassListType List`1<PCardDisplayModel> List`1<PCardDisplayModel> List<PCardDisplayModel> Pointer )
            value.EffectPoint                               = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 EffectPoint                 ( ModelClassType Transform Transform Transform Pointer )
            value.ShowCardTokenSource                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x060), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x60 ShowCardTokenSource         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.DrawCardTokenSource                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x68 DrawCardTokenSource         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x070)); // 0x70 AnimationSpeed              ( ModelPrimitiveType float float float Single )
            value.WaitDurationTask                          = GetObject<WaitDurationTask>(new IntPtr(p + 0x078), ReversePrism.DataModels.WaitDurationTask.FromPointer); // 0x78 WaitDurationTask            ( ModelClassType WaitDurationTask WaitDurationTask WaitDurationTask Pointer )

            return value;
        }
    }
}
