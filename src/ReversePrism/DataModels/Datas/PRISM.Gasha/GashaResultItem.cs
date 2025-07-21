using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PFIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 030 CmnItem                                  ModelClassType RewardItem RewardItem RewardItem Pointer
    // 038 CmnItemPieceIconP                        ModelClassType RewardItem RewardItem RewardItem Pointer
    // 040 CmnItemPieceIconS                        ModelClassType RewardItem RewardItem RewardItem Pointer
    // 048 TxtPieceDetailP                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtPieceDetailS                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ImgConvertItem                           ModelClassType RawImage RawImage RawImage Pointer
    // 060 TxtAmount                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 BtnPIdol                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 BtnSChara                                ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 GoNew                                    ModelClassType GameObject GameObject GameObject Pointer
    // 080 PIdolBackgroundAnimator                  ModelClassType Animator Animator Animator Pointer
    // 088 SCharaBackgroundAnimator                 ModelClassType Animator Animator Animator Pointer
    // 090 ItemEffectAnimator                       ModelClassType Animator Animator Animator Pointer
    // 098 CanvasGroupReward                        ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 CanvasGroupConvert                       ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 GoSelectFrame                            ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 SelectedProduct                          ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 0B8 GashaResultIndex                         ModelPrimitiveType int int int Int32
    // 0BC IsShowReward                             ModelPrimitiveType bool bool bool Bool
    // 0C0 RewardProduct                            ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer
    // 0C8 PickupProduc                             ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 000 changeTime                               float IL2CPP_TYPE_R4
    // 0D0 Sequence                                 ModelPrimitiveType int int int Int32
    // 0D8 Ctc                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class GashaResultItem : DataModel
    {
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public RewardItem?                              CmnItem                                 { get; set; }
        public RewardItem?                              CmnItemPieceIconP                       { get; set; }
        public RewardItem?                              CmnItemPieceIconS                       { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetailP                         { get; set; }
        public UITextMeshProUGUI?                       TxtPieceDetailS                         { get; set; }
        public RawImage?                                ImgConvertItem                          { get; set; }
        public UITextMeshProUGUI?                       TxtAmount                               { get; set; }
        public ButtonBase?                              BtnPIdol                                { get; set; }
        public ButtonBase?                              BtnSChara                               { get; set; }
        public GameObject?                              GoNew                                   { get; set; }
        public Animator?                                PIdolBackgroundAnimator                 { get; set; }
        public Animator?                                SCharaBackgroundAnimator                { get; set; }
        public Animator?                                ItemEffectAnimator                      { get; set; }
        public CanvasGroup?                             CanvasGroupReward                       { get; set; }
        public CanvasGroup?                             CanvasGroupConvert                      { get; set; }
        public GameObject?                              GoSelectFrame                           { get; set; }
        public IProductStatus?                          SelectedProduct                         { get; set; }
        public int                                      GashaResultIndex                        { get; set; }
        public bool                                     IsShowReward                            { get; set; }
        public IRewardProductStatus?                    RewardProduct                           { get; set; }
        public IProductWithAmountStatus?                PickupProduc                            { get; set; }
        public int                                      Sequence                                { get; set; }
        public CancellationTokenSource?                 Ctc                                     { get; set; }

        public static GashaResultItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaResultItem() { Pointer= p0 };

            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 PFIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x28 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.CmnItem                                   = GetObject<RewardItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItem.FromPointer); // 0x30 CmnItem                     ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.CmnItemPieceIconP                         = GetObject<RewardItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItem.FromPointer); // 0x38 CmnItemPieceIconP           ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.CmnItemPieceIconS                         = GetObject<RewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItem.FromPointer); // 0x40 CmnItemPieceIconS           ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.TxtPieceDetailP                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtPieceDetailP             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPieceDetailS                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtPieceDetailS             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgConvertItem                            = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 0x58 ImgConvertItem              ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtAmount                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtAmount                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnPIdol                                  = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x68 BtnPIdol                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnSChara                                 = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x70 BtnSChara                   ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoNew                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolBackgroundAnimator                   = GetObject<Animator>(new IntPtr(p + 0x080), ReversePrism.DataModels.Animator.FromPointer); // 0x80 PIdolBackgroundAnimator     ( ModelClassType Animator Animator Animator Pointer )
            value.SCharaBackgroundAnimator                  = GetObject<Animator>(new IntPtr(p + 0x088), ReversePrism.DataModels.Animator.FromPointer); // 0x88 SCharaBackgroundAnimator    ( ModelClassType Animator Animator Animator Pointer )
            value.ItemEffectAnimator                        = GetObject<Animator>(new IntPtr(p + 0x090), ReversePrism.DataModels.Animator.FromPointer); // 0x90 ItemEffectAnimator          ( ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroupReward                         = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x98 CanvasGroupReward           ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CanvasGroupConvert                        = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xA0 CanvasGroupConvert          ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoSelectFrame                             = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 GoSelectFrame               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedProduct                           = GetObject<IProductStatus>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IProductStatus.FromPointer); // 0xB0 SelectedProduct             ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.GashaResultIndex                          = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 GashaResultIndex            ( ModelPrimitiveType int int int Int32 )
            value.IsShowReward                              = GetBool(new IntPtr(p + 0x0BC)); // 0xBC IsShowReward                ( ModelPrimitiveType bool bool bool Bool )
            value.RewardProduct                             = GetObject<IRewardProductStatus>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 0xC0 RewardProduct               ( ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer )
            value.PickupProduc                              = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0xC8 PickupProduc                ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.Sequence                                  = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 Sequence                    ( ModelPrimitiveType int int int Int32 )
            value.Ctc                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0xD8 Ctc                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
