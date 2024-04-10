using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgLoadingCover                           000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 FadeDuration                             000186665B50 ModelPrimitiveType float float float Single
    // 030 Btn                                      0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer
    // 038 ImgBg                                    0001866CD000 ModelClassType Image Image Image Pointer
    // 040 ImgIdol                                  000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 048 ImgFrame                                 0001866CD000 ModelClassType Image Image Image Pointer
    // 050 ImgUnit                                  000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 058 ImgSolo                                  000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 060 FrameEffectAnimator                      00018671A4F0 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 068 FrameEffectParents                       000185B81600 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 CgPIdol                                  000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 078 CgAwakenLv                               000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 080 TxtAwakenLv                              0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 CgStar                                   000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 StarDisplay                              00018656D840 ModelClassType StarDisplay StarDisplay StarDisplay Pointer
    // 098 CgFIdol                                  000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 ImgFesRank                               000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 0A8 FesIdolRankEffectAnimator                00018671A4F0 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 0B0 FesIdolRankEffectParents                 000185B81600 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0B8 CgStatus                                 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0C0 TxtStatusLabel                           0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 TxtStatusValue                           0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 CgSkill                                  000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0D8 TxtSkill                                 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E0 CgTotal                                  000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0E8 TxtTotal                                 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0F0 CgBadgeUpperLabelSetting                 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0F8 CgBadgeUpperLabelBuiltInto               000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 100 CgBadgeUpperLabelFavorite                000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 108 CgBadgeUpperLabelEventBonus              000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 110 CgFavoriteMark                           000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 118 ImgFavoriteMark                          000186613440 ModelClassType RawImage RawImage RawImage Pointer
    // 120 CgBadgeDot                               000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 128 GoSelectedCursor                         0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 130 CgSelectedCursor                         000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 138 GrayOutController                        0001866EA6A0 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 140 UnitBonusEffect                          0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 148 CharacterNameView                        0001867032B0 ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer
    // 150 SoloMarkTween                            0001866BEFF0 ModelClassType Tween Tween Tween Pointer
    // 158 Ct                                       00018653D040 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 160 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 168 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 170 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PFIdolIconViewBase : DataModel
    {
        public CanvasGroup?                             CgLoadingCover                          { get; set; }
        public float                                    FadeDuration                            { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public Image?                                   ImgBg                                   { get; set; }
        public RawImage?                                ImgIdol                                 { get; set; }
        public Image?                                   ImgFrame                                { get; set; }
        public RawImage?                                ImgUnit                                 { get; set; }
        public RawImage?                                ImgSolo                                 { get; set; }
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
        public CanvasGroup?                             CgStatus                                { get; set; }
        public UITextMeshProUGUI?                       TxtStatusLabel                          { get; set; }
        public UITextMeshProUGUI?                       TxtStatusValue                          { get; set; }
        public CanvasGroup?                             CgSkill                                 { get; set; }
        public UITextMeshProUGUI?                       TxtSkill                                { get; set; }
        public CanvasGroup?                             CgTotal                                 { get; set; }
        public UITextMeshProUGUI?                       TxtTotal                                { get; set; }
        public CanvasGroup?                             CgBadgeUpperLabelSetting                { get; set; }
        public CanvasGroup?                             CgBadgeUpperLabelBuiltInto              { get; set; }
        public CanvasGroup?                             CgBadgeUpperLabelFavorite               { get; set; }
        public CanvasGroup?                             CgBadgeUpperLabelEventBonus             { get; set; }
        public CanvasGroup?                             CgFavoriteMark                          { get; set; }
        public RawImage?                                ImgFavoriteMark                         { get; set; }
        public CanvasGroup?                             CgBadgeDot                              { get; set; }
        public GameObject?                              GoSelectedCursor                        { get; set; }
        public CanvasGroup?                             CgSelectedCursor                        { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public GameObject?                              UnitBonusEffect                         { get; set; }
        public PFIdolCharacterNameView?                 CharacterNameView                       { get; set; }
        public Tween?                                   SoloMarkTween                           { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public bool                                     IsInitialized                           { get; set; }

        public static PFIdolIconViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolIconViewBase() { Pointer= p0 };

            value.CgLoadingCover                            = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFDE98 0x20 CgLoadingCover              ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x028)); // 0245A5AFDEB8 0x28 FadeDuration                ( 000186665B50 ModelPrimitiveType float float float Single )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0245A5AFDED8 0x30 Btn                         ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgBg                                     = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0245A5AFDEF8 0x38 ImgBg                       ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.ImgIdol                                   = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5AFDF18 0x40 ImgIdol                     ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgFrame                                  = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0245A5AFDF38 0x48 ImgFrame                    ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.ImgUnit                                   = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5AFDF58 0x50 ImgUnit                     ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.ImgSolo                                   = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5AFDF78 0x58 ImgSolo                     ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.FrameEffectAnimator                       = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x060), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0245A5AFDF98 0x60 FrameEffectAnimator         ( 00018671A4F0 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.FrameEffectParents                        = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5AFDFB8 0x68 FrameEffectParents          ( 000185B81600 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CgPIdol                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFDFD8 0x70 CgPIdol                     ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgAwakenLv                                = GetObject<CanvasGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFDFF8 0x78 CgAwakenLv                  ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtAwakenLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5AFE018 0x80 TxtAwakenLv                 ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgStar                                    = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE038 0x88 CgStar                      ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.StarDisplay                               = GetObject<StarDisplay>(new IntPtr(p + 0x090), ReversePrism.DataModels.StarDisplay.FromPointer); // 0245A5AFE058 0x90 StarDisplay                 ( 00018656D840 ModelClassType StarDisplay StarDisplay StarDisplay Pointer )
            value.CgFIdol                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE078 0x98 CgFIdol                     ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFesRank                                = GetObject<RawImage>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5AFE098 0xA0 ImgFesRank                  ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.FesIdolRankEffectAnimator                 = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0245A5AFE0B8 0xA8 FesIdolRankEffectAnimator   ( 00018671A4F0 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.FesIdolRankEffectParents                  = GetObjectList<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5AFE0D8 0xB0 FesIdolRankEffectParents    ( 000185B81600 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CgStatus                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE0F8 0xB8 CgStatus                    ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtStatusLabel                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5AFE118 0xC0 TxtStatusLabel              ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtStatusValue                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5AFE138 0xC8 TxtStatusValue              ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgSkill                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE158 0xD0 CgSkill                     ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtSkill                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5AFE178 0xD8 TxtSkill                    ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgTotal                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE198 0xE0 CgTotal                     ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtTotal                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A5AFE1B8 0xE8 TxtTotal                    ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgBadgeUpperLabelSetting                  = GetObject<CanvasGroup>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE1D8 0xF0 CgBadgeUpperLabelSetting    ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadgeUpperLabelBuiltInto                = GetObject<CanvasGroup>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE1F8 0xF8 CgBadgeUpperLabelBuiltInto  ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadgeUpperLabelFavorite                 = GetObject<CanvasGroup>(new IntPtr(p + 0x100), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE218 0x100 CgBadgeUpperLabelFavorite   ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgBadgeUpperLabelEventBonus               = GetObject<CanvasGroup>(new IntPtr(p + 0x108), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE238 0x108 CgBadgeUpperLabelEventBonus ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgFavoriteMark                            = GetObject<CanvasGroup>(new IntPtr(p + 0x110), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE258 0x110 CgFavoriteMark              ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFavoriteMark                           = GetObject<RawImage>(new IntPtr(p + 0x118), ReversePrism.DataModels.RawImage.FromPointer); // 0245A5AFE278 0x118 ImgFavoriteMark             ( 000186613440 ModelClassType RawImage RawImage RawImage Pointer )
            value.CgBadgeDot                                = GetObject<CanvasGroup>(new IntPtr(p + 0x120), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE298 0x120 CgBadgeDot                  ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoSelectedCursor                          = GetObject<GameObject>(new IntPtr(p + 0x128), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5AFE2B8 0x128 GoSelectedCursor            ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.CgSelectedCursor                          = GetObject<CanvasGroup>(new IntPtr(p + 0x130), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A5AFE2D8 0x130 CgSelectedCursor            ( 000186541150 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x138), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0245A5AFE2F8 0x138 GrayOutController           ( 0001866EA6A0 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.UnitBonusEffect                           = GetObject<GameObject>(new IntPtr(p + 0x140), ReversePrism.DataModels.GameObject.FromPointer); // 0245A5AFE318 0x140 UnitBonusEffect             ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.CharacterNameView                         = GetObject<PFIdolCharacterNameView>(new IntPtr(p + 0x148), ReversePrism.DataModels.PFIdolCharacterNameView.FromPointer); // 0245A5AFE338 0x148 CharacterNameView           ( 0001867032B0 ModelClassType PFIdolCharacterNameView PFIdolCharacterNameView PFIdolCharacterNameView Pointer )
            value.SoloMarkTween                             = GetObject<Tween>(new IntPtr(p + 0x150), ReversePrism.DataModels.Tween.FromPointer); // 0245A5AFE358 0x150 SoloMarkTween               ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x158)); // 0245A5AFE378 0x158 Ct                          ( 00018653D040 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x170)); // 0245A5AFE3D8 0x170 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
