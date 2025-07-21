using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 IdolIcon                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 PickUpMoveValue                          ModelPrimitiveType float float float Single
    // 084 SwipeStartPos                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 090 SwipeArrow                               ModelClassType GameObject GameObject GameObject Pointer
    // 098 SwipeRange                               ModelPrimitiveType float float float Single
    // 0A0 SwipeMoveUI                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A8 BeginDragTrigger                         ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer
    // 0B0 DragTrigger                              ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer
    // 0B8 EndDragTrigger                           ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer
    // 0C0 IsSwipeSetUped                           ModelPrimitiveType bool bool bool Bool
    // 0C4 SwipeValue                               ModelPrimitiveType float float float Single
    // 0C8 IsSwipe                                  ModelPrimitiveType bool bool bool Bool
    // 0CC SwipeBasePos                             ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0D8 SkillIconView                            ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 0E0 DeBuffFrame                              ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 BuffEffect                               ModelClassType GameObject GameObject GameObject Pointer
    // 0F0 DebuffEffect                             ModelClassType GameObject GameObject GameObject Pointer
    // 0F8 SpecialEffect                            ModelClassType GameObject GameObject GameObject Pointer
    // 100 SpecialChangeEffect                      ModelClassType GameObject GameObject GameObject Pointer
    // 108 ProducePointBgImage                      ModelClassType RawImage RawImage RawImage Pointer
    // 110 NormalProducePointTexture                ModelClassType Texture Texture Texture Pointer
    // 118 BuffProducePointTexture                  ModelClassType Texture Texture Texture Pointer
    // 120 DebuffProducePointTexture                ModelClassType Texture Texture Texture Pointer
    // 128 AnimatorWithEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 130 UiParticle                               ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 138 IsPlayngAnimation                        ModelPrimitiveType bool bool bool Bool
    // 140 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 148 onSwipe                                  Subject`1<SwipeState> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillContent : DataModel
    {
        public UIRawImage?                              IdolIcon                                { get; set; }
        public float                                    PickUpMoveValue                         { get; set; }
        public Vector2                                  SwipeStartPos                           { get; set; }
        public GameObject?                              SwipeArrow                              { get; set; }
        public float                                    SwipeRange                              { get; set; }
        public RectTransform?                           SwipeMoveUI                             { get; set; }
        public ObservableBeginDragTrigger?              BeginDragTrigger                        { get; set; }
        public ObservableDragTrigger?                   DragTrigger                             { get; set; }
        public ObservableEndDragTrigger?                EndDragTrigger                          { get; set; }
        public bool                                     IsSwipeSetUped                          { get; set; }
        public float                                    SwipeValue                              { get; set; }
        public bool                                     IsSwipe                                 { get; set; }
        public Vector2                                  SwipeBasePos                            { get; set; }
        public IdolSkillIconView?                       SkillIconView                           { get; set; }
        public GameObject?                              DeBuffFrame                             { get; set; }
        public GameObject?                              BuffEffect                              { get; set; }
        public GameObject?                              DebuffEffect                            { get; set; }
        public GameObject?                              SpecialEffect                           { get; set; }
        public GameObject?                              SpecialChangeEffect                     { get; set; }
        public RawImage?                                ProducePointBgImage                     { get; set; }
        public Texture?                                 NormalProducePointTexture               { get; set; }
        public Texture?                                 BuffProducePointTexture                 { get; set; }
        public Texture?                                 DebuffProducePointTexture               { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public ParticleSystem?                          UiParticle                              { get; set; }
        public bool                                     IsPlayngAnimation                       { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }

        public static IdolSkillContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillContent() { Pointer= p0 };

            value.IdolIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x78 IdolIcon                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.PickUpMoveValue                           = GetSingle(new IntPtr(p + 0x080)); // 0x80 PickUpMoveValue             ( ModelPrimitiveType float float float Single )
            value.SwipeStartPos                             = (Vector2)GetInt32(new IntPtr(p + 0x084)); // 0x84 SwipeStartPos               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SwipeArrow                                = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 SwipeArrow                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SwipeRange                                = GetSingle(new IntPtr(p + 0x098)); // 0x98 SwipeRange                  ( ModelPrimitiveType float float float Single )
            value.SwipeMoveUI                               = GetObject<RectTransform>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0xA0 SwipeMoveUI                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BeginDragTrigger                          = GetObject<ObservableBeginDragTrigger>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ObservableBeginDragTrigger.FromPointer); // 0xA8 BeginDragTrigger            ( ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer )
            value.DragTrigger                               = GetObject<ObservableDragTrigger>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ObservableDragTrigger.FromPointer); // 0xB0 DragTrigger                 ( ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer )
            value.EndDragTrigger                            = GetObject<ObservableEndDragTrigger>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ObservableEndDragTrigger.FromPointer); // 0xB8 EndDragTrigger              ( ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer )
            value.IsSwipeSetUped                            = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 IsSwipeSetUped              ( ModelPrimitiveType bool bool bool Bool )
            value.SwipeValue                                = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 SwipeValue                  ( ModelPrimitiveType float float float Single )
            value.IsSwipe                                   = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 IsSwipe                     ( ModelPrimitiveType bool bool bool Bool )
            value.SwipeBasePos                              = (Vector2)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC SwipeBasePos                ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0xD8 SkillIconView               ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.DeBuffFrame                               = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0xE0 DeBuffFrame                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BuffEffect                                = GetObject<GameObject>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GameObject.FromPointer); // 0xE8 BuffEffect                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DebuffEffect                              = GetObject<GameObject>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.GameObject.FromPointer); // 0xF0 DebuffEffect                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialEffect                             = GetObject<GameObject>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.GameObject.FromPointer); // 0xF8 SpecialEffect               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialChangeEffect                       = GetObject<GameObject>(new IntPtr(p + 0x100), ReversePrism.DataModels.GameObject.FromPointer); // 0x100 SpecialChangeEffect         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePointBgImage                       = GetObject<RawImage>(new IntPtr(p + 0x108), ReversePrism.DataModels.RawImage.FromPointer); // 0x108 ProducePointBgImage         ( ModelClassType RawImage RawImage RawImage Pointer )
            value.NormalProducePointTexture                 = GetObject<Texture>(new IntPtr(p + 0x110), ReversePrism.DataModels.Texture.FromPointer); // 0x110 NormalProducePointTexture   ( ModelClassType Texture Texture Texture Pointer )
            value.BuffProducePointTexture                   = GetObject<Texture>(new IntPtr(p + 0x118), ReversePrism.DataModels.Texture.FromPointer); // 0x118 BuffProducePointTexture     ( ModelClassType Texture Texture Texture Pointer )
            value.DebuffProducePointTexture                 = GetObject<Texture>(new IntPtr(p + 0x120), ReversePrism.DataModels.Texture.FromPointer); // 0x120 DebuffProducePointTexture   ( ModelClassType Texture Texture Texture Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x128), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x128 AnimatorWithEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.UiParticle                                = GetObject<ParticleSystem>(new IntPtr(p + 0x130), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x130 UiParticle                  ( ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.IsPlayngAnimation                         = GetBool(new IntPtr(p + 0x138)); // 0x138 IsPlayngAnimation           ( ModelPrimitiveType bool bool bool Bool )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x140), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x140 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
