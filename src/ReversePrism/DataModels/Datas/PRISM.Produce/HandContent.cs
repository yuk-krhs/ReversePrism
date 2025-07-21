using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HandCountViewMin                         int IL2CPP_TYPE_I4
    // 000 DefaultCardScale                         float IL2CPP_TYPE_R4
    // 000 ExpandCardScale                          float IL2CPP_TYPE_R4
    // 020 HandMaxSpace                             ModelPrimitiveType int int int Int32
    // 024 DefaultSizeX                             ModelPrimitiveType int int int Int32
    // 028 ProduceCardPrefab                        ModelClassType PlayerUsePCardContent PlayerUsePCardContent PlayerUsePCardContent Pointer
    // 030 HandParent                               ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 CardDisplayModels                        ModelClassListType List`1<PCardDisplayModel> List`1<PCardDisplayModel> List<PCardDisplayModel> Pointer
    // 040 DragTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 DraggableArea                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 SaveCard                                 ModelClassType PlayerUsePCardContent PlayerUsePCardContent PlayerUsePCardContent Pointer
    // 058 IsDragNow                                ModelPrimitiveType bool bool bool Bool
    // 05C LastSaveCardPos                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 068 SaveCardChildIndex                       ModelPrimitiveType int int int Int32
    // 06C SaveCardIndex                            ModelPrimitiveType int int int Int32
    // 070 LayoutGroup                              ModelClassType HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup Pointer
    // 078 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 SpaceKeeperPrefab                        ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 HandCanvasGroup                          ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 UpdateHandCTSource                       ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 098 CacheSetupCardTasks                      ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer
    // 0A0 RemoveHandAnimationController            ModelClassType RemoveHandAnimationController RemoveHandAnimationController RemoveHandAnimationController Pointer
    // 0A8 HandAreaAnimator                         ModelClassType Animator Animator Animator Pointer
    // 0B0 HandAreaParticle                         ModelClassType UIParticle UIParticle UIParticle Pointer
    // 0B8 AnimationSpeed                           ModelPrimitiveType float float float Single
    // 0C0 onDrag                                   Subject`1<ValueTuple`2<int, DragState>> IL2CPP_TYPE_GENERICINST
    // 0C8 <IsAvailableCard>k__BackingField         Func`2<int, bool> IL2CPP_TYPE_GENERICINST
    public partial class HandContent : DataModel
    {
        public int                                      HandMaxSpace                            { get; set; }
        public int                                      DefaultSizeX                            { get; set; }
        public PlayerUsePCardContent?                   ProduceCardPrefab                       { get; set; }
        public RectTransform?                           HandParent                              { get; set; }
        public List<PCardDisplayModel>?                 CardDisplayModels                       { get; set; }
        public RectTransform?                           DragTransform                           { get; set; }
        public RectTransform?                           DraggableArea                           { get; set; }
        public PlayerUsePCardContent?                   SaveCard                                { get; set; }
        public bool                                     IsDragNow                               { get; set; }
        public Vector3                                  LastSaveCardPos                         { get; set; }
        public int                                      SaveCardChildIndex                      { get; set; }
        public int                                      SaveCardIndex                           { get; set; }
        public HorizontalOrVerticalLayoutGroup?         LayoutGroup                             { get; set; }
        public RectTransform?                           SpaceKeeperPrefab                       { get; set; }
        public CanvasGroup?                             HandCanvasGroup                         { get; set; }
        public AutoCancellationTokenSource              UpdateHandCTSource                      { get; set; }
        public List<UniTask>?                           CacheSetupCardTasks                     { get; set; }
        public RemoveHandAnimationController?           RemoveHandAnimationController           { get; set; }
        public Animator?                                HandAreaAnimator                        { get; set; }
        public UIParticle?                              HandAreaParticle                        { get; set; }
        public float                                    AnimationSpeed                          { get; set; }

        public static HandContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HandContent() { Pointer= p0 };

            value.HandMaxSpace                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 HandMaxSpace                ( ModelPrimitiveType int int int Int32 )
            value.DefaultSizeX                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 DefaultSizeX                ( ModelPrimitiveType int int int Int32 )
            value.ProduceCardPrefab                         = GetObject<PlayerUsePCardContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlayerUsePCardContent.FromPointer); // 0x28 ProduceCardPrefab           ( ModelClassType PlayerUsePCardContent PlayerUsePCardContent PlayerUsePCardContent Pointer )
            value.HandParent                                = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 HandParent                  ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CardDisplayModels                         = GetObjectList<PCardDisplayModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.PCardDisplayModel.FromPointer); // 0x38 CardDisplayModels           ( ModelClassListType List`1<PCardDisplayModel> List`1<PCardDisplayModel> List<PCardDisplayModel> Pointer )
            value.DragTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 DragTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DraggableArea                             = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 DraggableArea               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SaveCard                                  = GetObject<PlayerUsePCardContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.PlayerUsePCardContent.FromPointer); // 0x50 SaveCard                    ( ModelClassType PlayerUsePCardContent PlayerUsePCardContent PlayerUsePCardContent Pointer )
            value.IsDragNow                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 IsDragNow                   ( ModelPrimitiveType bool bool bool Bool )
            value.LastSaveCardPos                           = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 0x5C LastSaveCardPos             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SaveCardChildIndex                        = GetInt32(new IntPtr(p + 0x068)); // 0x68 SaveCardChildIndex          ( ModelPrimitiveType int int int Int32 )
            value.SaveCardIndex                             = GetInt32(new IntPtr(p + 0x06C)); // 0x6C SaveCardIndex               ( ModelPrimitiveType int int int Int32 )
            value.LayoutGroup                               = GetObject<HorizontalOrVerticalLayoutGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.HorizontalOrVerticalLayoutGroup.FromPointer); // 0x70 LayoutGroup                 ( ModelClassType HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup HorizontalOrVerticalLayoutGroup Pointer )
            value.SpaceKeeperPrefab                         = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 0x80 SpaceKeeperPrefab           ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.HandCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x88 HandCanvasGroup             ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.UpdateHandCTSource                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x090)); // 0x90 UpdateHandCTSource          ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.CacheSetupCardTasks                       = GetEnumList<UniTask>(new IntPtr(p + 0x098)); // 0x98 CacheSetupCardTasks         ( ModelEnumListType List`1<UniTask> List`1<UniTask> List<UniTask> Pointer )
            value.RemoveHandAnimationController             = GetObject<RemoveHandAnimationController>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RemoveHandAnimationController.FromPointer); // 0xA0 RemoveHandAnimationController ( ModelClassType RemoveHandAnimationController RemoveHandAnimationController RemoveHandAnimationController Pointer )
            value.HandAreaAnimator                          = GetObject<Animator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Animator.FromPointer); // 0xA8 HandAreaAnimator            ( ModelClassType Animator Animator Animator Pointer )
            value.HandAreaParticle                          = GetObject<UIParticle>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIParticle.FromPointer); // 0xB0 HandAreaParticle            ( ModelClassType UIParticle UIParticle UIParticle Pointer )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x0B8)); // 0xB8 AnimationSpeed              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
