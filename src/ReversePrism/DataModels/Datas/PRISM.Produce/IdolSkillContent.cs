using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 IdolIcon                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 PickUpMoveValue                          0001866656B0 ModelPrimitiveType float float float Single
    // 084 SwipeStartPos                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 090 SwipeArrow                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 SwipeRange                               0001866656B0 ModelPrimitiveType float float float Single
    // 0A0 SwipeMoveUI                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 0A8 BeginDragTrigger                         0001866CE5C0 ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer
    // 0B0 DragTrigger                              0001866D04C0 ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer
    // 0B8 EndDragTrigger                           0001866D0E60 ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer
    // 0C0 IsSwipeSetUped                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C4 SwipeValue                               0001866656B0 ModelPrimitiveType float float float Single
    // 0C8 IsSwipe                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0CC SwipeBasePos                             0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0D8 SkillIconView                            0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 0E0 DeBuffFrame                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 ProducePointBgImage                      000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 0F0 NormalProducePointTexture                00018664D490 ModelClassType Texture Texture Texture Pointer
    // 0F8 BuffProducePointTexture                  00018664D490 ModelClassType Texture Texture Texture Pointer
    // 100 DebuffProducePointTexture                00018664D490 ModelClassType Texture Texture Texture Pointer
    // 108 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 110 UiParticle                               000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer
    // 118 IsPlayngAnimation                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 120 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
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

            value.IdolIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665A3C9B0 0x78 IdolIcon                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.PickUpMoveValue                           = GetSingle(new IntPtr(p + 0x080)); // 024665A3C9D0 0x80 PickUpMoveValue             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SwipeStartPos                             = (Vector2)GetInt32(new IntPtr(p + 0x084)); // 024665A3C9F0 0x84 SwipeStartPos               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SwipeArrow                                = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 024665A3CA10 0x90 SwipeArrow                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SwipeRange                                = GetSingle(new IntPtr(p + 0x098)); // 024665A3CA30 0x98 SwipeRange                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SwipeMoveUI                               = GetObject<RectTransform>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RectTransform.FromPointer); // 024665A3CA50 0xA0 SwipeMoveUI                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BeginDragTrigger                          = GetObject<ObservableBeginDragTrigger>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ObservableBeginDragTrigger.FromPointer); // 024665A3CA70 0xA8 BeginDragTrigger            ( 0001866CE5C0 ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer )
            value.DragTrigger                               = GetObject<ObservableDragTrigger>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ObservableDragTrigger.FromPointer); // 024665A3CA90 0xB0 DragTrigger                 ( 0001866D04C0 ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer )
            value.EndDragTrigger                            = GetObject<ObservableEndDragTrigger>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ObservableEndDragTrigger.FromPointer); // 024665A3CAB0 0xB8 EndDragTrigger              ( 0001866D0E60 ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer )
            value.IsSwipeSetUped                            = GetBool(new IntPtr(p + 0x0C0)); // 024665A3CAD0 0xC0 IsSwipeSetUped              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwipeValue                                = GetSingle(new IntPtr(p + 0x0C4)); // 024665A3CAF0 0xC4 SwipeValue                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsSwipe                                   = GetBool(new IntPtr(p + 0x0C8)); // 024665A3CB10 0xC8 IsSwipe                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwipeBasePos                              = (Vector2)GetInt32(new IntPtr(p + 0x0CC)); // 024665A3CB30 0xCC SwipeBasePos                ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 024665A3CB50 0xD8 SkillIconView               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.DeBuffFrame                               = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 024665A3CB70 0xE0 DeBuffFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePointBgImage                       = GetObject<RawImage>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RawImage.FromPointer); // 024665A3CB90 0xE8 ProducePointBgImage         ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.NormalProducePointTexture                 = GetObject<Texture>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Texture.FromPointer); // 024665A3CBB0 0xF0 NormalProducePointTexture   ( 00018664D490 ModelClassType Texture Texture Texture Pointer )
            value.BuffProducePointTexture                   = GetObject<Texture>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Texture.FromPointer); // 024665A3CBD0 0xF8 BuffProducePointTexture     ( 00018664D490 ModelClassType Texture Texture Texture Pointer )
            value.DebuffProducePointTexture                 = GetObject<Texture>(new IntPtr(p + 0x100), ReversePrism.DataModels.Texture.FromPointer); // 024665A3CBF0 0x100 DebuffProducePointTexture   ( 00018664D490 ModelClassType Texture Texture Texture Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x108), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 024665A3CC10 0x108 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.UiParticle                                = GetObject<ParticleSystem>(new IntPtr(p + 0x110), ReversePrism.DataModels.ParticleSystem.FromPointer); // 024665A3CC30 0x110 UiParticle                  ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.IsPlayngAnimation                         = GetBool(new IntPtr(p + 0x118)); // 024665A3CC50 0x118 IsPlayngAnimation           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x120), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665A3CC70 0x120 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
