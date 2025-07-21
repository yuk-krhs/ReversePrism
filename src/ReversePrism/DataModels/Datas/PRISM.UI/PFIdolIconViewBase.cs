using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgLoadingCover                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 FadeDuration                             ModelPrimitiveType float float float Single
    // 030 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 038 ImgBg                                    ModelClassType Image Image Image Pointer
    // 040 ImgIdol                                  ModelClassType RawImage RawImage RawImage Pointer
    // 048 ImgFrame                                 ModelClassType Image Image Image Pointer
    // 050 ImgUnit                                  ModelClassType RawImage RawImage RawImage Pointer
    // 058 ImgUnitIconOverlay                       ModelClassType Image Image Image Pointer
    // 060 UnitIconOverlaySprites                   ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 068 FrameEffectAnimator                      ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 070 FrameEffectParents                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 CgPIdol                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 080 CgAwakenLv                               ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 088 TxtAwakenLv                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 CgStar                                   ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 098 StarDisplay                              ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 0A0 CgFIdol                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 ImgFesRank                               ModelClassType RawImage RawImage RawImage Pointer
    // 0B0 FesIdolRankEffectAnimator                ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 0B8 FesIdolRankEffectParents                 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0C0 CgStatusLevel                            ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0C8 TxtStatusLevel                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 GaugeLevel                               ModelClassType Image Image Image Pointer
    // 0D8 CgStatusDearness                         ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0E0 TxtStatusDearness                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E8 GaugeDearness                            ModelClassType Image Image Image Pointer
    // 0F0 CgStatusFan                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0F8 TxtStatusFan                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 100 CgSkill                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 108 TxtSkill                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 110 CgTotal                                  ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 118 TxtTotal                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 120 CgUpperLabelArray                        ModelClassListType CanvasGroup[] CanvasGroup[] List<CanvasGroup> Pointer
    // 128 CgFavoriteMark                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 130 ImgFavoriteMark                          ModelClassType RawImage RawImage RawImage Pointer
    // 138 CgBadgeDot                               ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 140 GoSelectedCursor                         ModelClassType GameObject GameObject GameObject Pointer
    // 148 CgSelectedCursor                         ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 150 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 158 UnitBonusEffect                          ModelClassType GameObject GameObject GameObject Pointer
    // 160 CharacterNameView                        ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer
    // 168 UnitIconOverlayTween                     ModelClassType Tween Tween Tween Pointer
    // 170 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 178 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 180 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 188 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 190 EnabledUpperLabelTypes                   ModelEnumListType List`1<UpperLabelType> List`1<UpperLabelType> List<UpperLabelType> Pointer
    // 198 CurrentBlinkIndex                        ModelPrimitiveType int int int Int32
    // 1A0 UpperLabelDisposable                     ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class PFIdolIconViewBase : DataModel
    {
        public CanvasGroup?                             CgLoadingCover                          { get; set; }
        public float                                    FadeDuration                            { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public Image?                                   ImgBg                                   { get; set; }
        public RawImage?                                ImgIdol                                 { get; set; }
        public Image?                                   ImgFrame                                { get; set; }
        public RawImage?                                ImgUnit                                 { get; set; }
        public Image?                                   ImgUnitIconOverlay                      { get; set; }
        public List<Sprite>?                            UnitIconOverlaySprites                  { get; set; }
        public ParamRememberableAnimator?               FrameEffectAnimator                     { get; set; }
        public List<GameObject>?                        FrameEffectParents                      { get; set; }
        public CanvasGroup?                             CgPIdol                                 { get; set; }
        public CanvasGroup?                             CgAwakenLv                              { get; set; }
        public UITextMeshProUGUI?                       TxtAwakenLv                             { get; set; }
        public CanvasGroup?                             CgStar                                  { get; set; }
        public StarDisplay?                             StarDisplay                             { get; set; }
        public CanvasGroup?                             CgFIdol                                 { get; set; }
        public RawImage?                                ImgFesRank                              { get; set; }
        public ParamRememberableAnimator?               FesIdolRankEffectAnimator               { get; set; }
        public List<GameObject>?                        FesIdolRankEffectParents                { get; set; }
        public CanvasGroup?                             CgStatusLevel                           { get; set; }
        public UITextMeshProUGUI?                       TxtStatusLevel                          { get; set; }
        public Image?                                   GaugeLevel                              { get; set; }
        public CanvasGroup?                             CgStatusDearness                        { get; set; }
        public UITextMeshProUGUI?                       TxtStatusDearness                       { get; set; }
        public Image?                                   GaugeDearness                           { get; set; }
        public CanvasGroup?                             CgStatusFan                             { get; set; }
        public UITextMeshProUGUI?                       TxtStatusFan                            { get; set; }
        public CanvasGroup?                             CgSkill                                 { get; set; }
        public UITextMeshProUGUI?                       TxtSkill                                { get; set; }
        public CanvasGroup?                             CgTotal                                 { get; set; }
        public UITextMeshProUGUI?                       TxtTotal                                { get; set; }
        public List<CanvasGroup>?                       CgUpperLabelArray                       { get; set; }
        public CanvasGroup?                             CgFavoriteMark                          { get; set; }
        public RawImage?                                ImgFavoriteMark                         { get; set; }
        public CanvasGroup?                             CgBadgeDot                              { get; set; }
        public GameObject?                              GoSelectedCursor                        { get; set; }
        public CanvasGroup?                             CgSelectedCursor                        { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public GameObject?                              UnitBonusEffect                         { get; set; }
        public PFIdolCharacterNameView?                 CharacterNameView                       { get; set; }
        public Tween?                                   UnitIconOverlayTween                    { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public List<UpperLabelType>?                    EnabledUpperLabelTypes                  { get; set; }
        public int                                      CurrentBlinkIndex                       { get; set; }
        public IDisposable?                             UpperLabelDisposable                    { get; set; }

        public static PFIdolIconViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolIconViewBase() { Pointer= p0 };

            value.CgLoadingCover                            = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CgLoadingCover              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x028)); // 0x28 FadeDuration                ( ModelPrimitiveType float float float Single )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 ImgBg                       ( ModelClassType Image Image Image Pointer )
            value.ImgIdol                                   = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0x40 ImgIdol                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 ImgFrame                    ( ModelClassType Image Image Image Pointer )
            value.ImgUnit                                   = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0x50 ImgUnit                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgUnitIconOverlay                        = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0x58 ImgUnitIconOverlay          ( ModelClassType Image Image Image Pointer )
            value.UnitIconOverlaySprites                    = GetObjectList<Sprite>(new IntPtr(p + 0x060), ReversePrism.DataModels.Sprite.FromPointer); // 0x60 UnitIconOverlaySprites      ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.FrameEffectAnimator                       = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0x68 FrameEffectAnimator         ( ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.FrameEffectParents                        = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 FrameEffectParents          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CgPIdol                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x78 CgPIdol                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgAwakenLv                                = GetObject<CanvasGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x80 CgAwakenLv                  ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtAwakenLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 TxtAwakenLv                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgStar                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x90 CgStar                      ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.StarDisplay                               = GetObject<StarDisplay>(new IntPtr(p + 0x098), ReversePrism.DataModels.StarDisplay.FromPointer); // 0x98 StarDisplay                 ( ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.CgFIdol                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xA0 CgFIdol                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFesRank                                = GetObject<RawImage>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RawImage.FromPointer); // 0xA8 ImgFesRank                  ( ModelClassType RawImage RawImage RawImage Pointer )
            value.FesIdolRankEffectAnimator                 = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0xB0 FesIdolRankEffectAnimator   ( ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.FesIdolRankEffectParents                  = GetObjectList<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 FesIdolRankEffectParents    ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CgStatusLevel                             = GetObject<CanvasGroup>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xC0 CgStatusLevel               ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtStatusLevel                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC8 TxtStatusLevel              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GaugeLevel                                = GetObject<Image>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Image.FromPointer); // 0xD0 GaugeLevel                  ( ModelClassType Image Image Image Pointer )
            value.CgStatusDearness                          = GetObject<CanvasGroup>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xD8 CgStatusDearness            ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtStatusDearness                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xE0 TxtStatusDearness           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GaugeDearness                             = GetObject<Image>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Image.FromPointer); // 0xE8 GaugeDearness               ( ModelClassType Image Image Image Pointer )
            value.CgStatusFan                               = GetObject<CanvasGroup>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xF0 CgStatusFan                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtStatusFan                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xF8 TxtStatusFan                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgSkill                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x100), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x100 CgSkill                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtSkill                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x108), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x108 TxtSkill                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgTotal                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x110), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x110 CgTotal                     ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtTotal                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x118), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x118 TxtTotal                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgUpperLabelArray                         = GetObjectList<CanvasGroup>(new IntPtr(p + 0x120), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x120 CgUpperLabelArray           ( ModelClassListType CanvasGroup[] CanvasGroup[] List<CanvasGroup> Pointer )
            value.CgFavoriteMark                            = GetObject<CanvasGroup>(new IntPtr(p + 0x128), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x128 CgFavoriteMark              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x130), ReversePrism.DataModels.RawImage.FromPointer); // 0x130 ImgFavoriteMark             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CgBadgeDot                                = GetObject<CanvasGroup>(new IntPtr(p + 0x138), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x138 CgBadgeDot                  ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoSelectedCursor                          = GetObject<GameObject>(new IntPtr(p + 0x140), ReversePrism.DataModels.GameObject.FromPointer); // 0x140 GoSelectedCursor            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CgSelectedCursor                          = GetObject<CanvasGroup>(new IntPtr(p + 0x148), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x148 CgSelectedCursor            ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x150), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x150 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.UnitBonusEffect                           = GetObject<GameObject>(new IntPtr(p + 0x158), ReversePrism.DataModels.GameObject.FromPointer); // 0x158 UnitBonusEffect             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterNameView                         = GetObject<PFIdolCharacterNameView>(new IntPtr(p + 0x160), ReversePrism.DataModels.PFIdolCharacterNameView.FromPointer); // 0x160 CharacterNameView           ( ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer )
            value.UnitIconOverlayTween                      = GetObject<Tween>(new IntPtr(p + 0x168), ReversePrism.DataModels.Tween.FromPointer); // 0x168 UnitIconOverlayTween        ( ModelClassType Tween Tween Tween Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x170)); // 0x170 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x188)); // 0x188 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.EnabledUpperLabelTypes                    = GetEnumList<UpperLabelType>(new IntPtr(p + 0x190)); // 0x190 EnabledUpperLabelTypes      ( ModelEnumListType List`1<UpperLabelType> List`1<UpperLabelType> List<UpperLabelType> Pointer )
            value.CurrentBlinkIndex                         = GetInt32(new IntPtr(p + 0x198)); // 0x198 CurrentBlinkIndex           ( ModelPrimitiveType int int int Int32 )
            value.UpperLabelDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.IDisposable.FromPointer); // 0x1A0 UpperLabelDisposable        ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
