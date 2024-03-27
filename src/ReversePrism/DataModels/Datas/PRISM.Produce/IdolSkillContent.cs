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
    public partial class IdolSkillContent
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
            var value   = new IdolSkillContent();

            value.IdolIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D59DB238 0x78 IdolIcon                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.PickUpMoveValue                           = GetSingle(new IntPtr(p + 0x080)); // 0270D59DB258 0x80 PickUpMoveValue             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SwipeStartPos                             = (Vector2)GetInt32(new IntPtr(p + 0x084)); // 0270D59DB278 0x84 SwipeStartPos               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SwipeArrow                                = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270D59DB298 0x90 SwipeArrow                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SwipeRange                                = GetSingle(new IntPtr(p + 0x098)); // 0270D59DB2B8 0x98 SwipeRange                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.SwipeMoveUI                               = GetObject<RectTransform>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D59DB2D8 0xA0 SwipeMoveUI                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BeginDragTrigger                          = GetObject<ObservableBeginDragTrigger>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ObservableBeginDragTrigger.FromPointer); // 0270D59DB2F8 0xA8 BeginDragTrigger            ( 0001866CE5C0 ModelClassType ObservableBeginDragTrigger ObservableBeginDragTrigger ObservableBeginDragTrigger Pointer )
            value.DragTrigger                               = GetObject<ObservableDragTrigger>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ObservableDragTrigger.FromPointer); // 0270D59DB318 0xB0 DragTrigger                 ( 0001866D04C0 ModelClassType ObservableDragTrigger ObservableDragTrigger ObservableDragTrigger Pointer )
            value.EndDragTrigger                            = GetObject<ObservableEndDragTrigger>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ObservableEndDragTrigger.FromPointer); // 0270D59DB338 0xB8 EndDragTrigger              ( 0001866D0E60 ModelClassType ObservableEndDragTrigger ObservableEndDragTrigger ObservableEndDragTrigger Pointer )
            value.IsSwipeSetUped                            = GetBool(new IntPtr(p + 0x0C0)); // 0270D59DB358 0xC0 IsSwipeSetUped              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwipeValue                                = GetSingle(new IntPtr(p + 0x0C4)); // 0270D59DB378 0xC4 SwipeValue                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsSwipe                                   = GetBool(new IntPtr(p + 0x0C8)); // 0270D59DB398 0xC8 IsSwipe                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SwipeBasePos                              = (Vector2)GetInt32(new IntPtr(p + 0x0CC)); // 0270D59DB3B8 0xCC SwipeBasePos                ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SkillIconView                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270D59DB3D8 0xD8 SkillIconView               ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.DeBuffFrame                               = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D59DB3F8 0xE0 DeBuffFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProducePointBgImage                       = GetObject<RawImage>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RawImage.FromPointer); // 0270D59DB418 0xE8 ProducePointBgImage         ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.NormalProducePointTexture                 = GetObject<Texture>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Texture.FromPointer); // 0270D59DB438 0xF0 NormalProducePointTexture   ( 00018664D490 ModelClassType Texture Texture Texture Pointer )
            value.BuffProducePointTexture                   = GetObject<Texture>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Texture.FromPointer); // 0270D59DB458 0xF8 BuffProducePointTexture     ( 00018664D490 ModelClassType Texture Texture Texture Pointer )
            value.DebuffProducePointTexture                 = GetObject<Texture>(new IntPtr(p + 0x100), ReversePrism.DataModels.Texture.FromPointer); // 0270D59DB478 0x100 DebuffProducePointTexture   ( 00018664D490 ModelClassType Texture Texture Texture Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x108), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270D59DB498 0x108 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.UiParticle                                = GetObject<ParticleSystem>(new IntPtr(p + 0x110), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0270D59DB4B8 0x110 UiParticle                  ( 000186723C20 ModelClassType ParticleSystem ParticleSystem ParticleSystem Pointer )
            value.IsPlayngAnimation                         = GetBool(new IntPtr(p + 0x118)); // 0270D59DB4D8 0x118 IsPlayngAnimation           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x120), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D59DB4F8 0x120 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
