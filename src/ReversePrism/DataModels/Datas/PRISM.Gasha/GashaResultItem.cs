using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PFIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 SCharaIconView                           0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 030 CmnItem                                  0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 038 CmnItemPieceIconP                        0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 040 CmnItemPieceIconS                        0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 048 TxtPieceDetailP                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtPieceDetailS                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ImgConvertItem                           000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 060 TxtAmount                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 BtnPIdol                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 BtnSChara                                000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 GoNew                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 PIdolBackgroundAnimator                  0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 088 SCharaBackgroundAnimator                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 090 ItemEffectAnimator                       0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 098 CanvasGroupReward                        000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 CanvasGroupConvert                       000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 0B0 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 0B8 GoSelectFrame                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 SelectedProduct                          0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 0C8 GashaResultIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0CC IsShowReward                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D0 RewardProduct                            00018661F820 ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer
    // 0D8 PickupProduc                             0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 000 changeTime                               float IL2CPP_TYPE_R4
    // 0E0 Sequence                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0E8 Ctc                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class GashaResultItem : DataModel
    {
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public CmnItem?                                 CmnItem                                 { get; set; }
        public CmnItem?                                 CmnItemPieceIconP                       { get; set; }
        public CmnItem?                                 CmnItemPieceIconS                       { get; set; }
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
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
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

            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 024665402A18 0x20 PFIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconView.FromPointer); // 024665402A38 0x28 SCharaIconView              ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.CmnItem                                   = GetObject<CmnItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.CmnItem.FromPointer); // 024665402A58 0x30 CmnItem                     ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.CmnItemPieceIconP                         = GetObject<CmnItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.CmnItem.FromPointer); // 024665402A78 0x38 CmnItemPieceIconP           ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.CmnItemPieceIconS                         = GetObject<CmnItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.CmnItem.FromPointer); // 024665402A98 0x40 CmnItemPieceIconS           ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.TxtPieceDetailP                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665402AB8 0x48 TxtPieceDetailP             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPieceDetailS                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665402AD8 0x50 TxtPieceDetailS             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgConvertItem                            = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 024665402AF8 0x58 ImgConvertItem              ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtAmount                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665402B18 0x60 TxtAmount                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnPIdol                                  = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665402B38 0x68 BtnPIdol                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnSChara                                 = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665402B58 0x70 BtnSChara                   ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoNew                                     = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 024665402B78 0x78 GoNew                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolBackgroundAnimator                   = GetObject<Animator>(new IntPtr(p + 0x080), ReversePrism.DataModels.Animator.FromPointer); // 024665402B98 0x80 PIdolBackgroundAnimator     ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.SCharaBackgroundAnimator                  = GetObject<Animator>(new IntPtr(p + 0x088), ReversePrism.DataModels.Animator.FromPointer); // 024665402BB8 0x88 SCharaBackgroundAnimator    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ItemEffectAnimator                        = GetObject<Animator>(new IntPtr(p + 0x090), ReversePrism.DataModels.Animator.FromPointer); // 024665402BD8 0x90 ItemEffectAnimator          ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroupReward                         = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665402BF8 0x98 CanvasGroupReward           ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CanvasGroupConvert                        = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024665402C18 0xA0 CanvasGroupConvert          ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 024665402C38 0xA8 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 024665402C58 0xB0 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.GoSelectFrame                             = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 024665402C78 0xB8 GoSelectFrame               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedProduct                           = GetObject<IProductStatus>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IProductStatus.FromPointer); // 024665402C98 0xC0 SelectedProduct             ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.GashaResultIndex                          = GetInt32(new IntPtr(p + 0x0C8)); // 024665402CB8 0xC8 GashaResultIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsShowReward                              = GetBool(new IntPtr(p + 0x0CC)); // 024665402CD8 0xCC IsShowReward                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RewardProduct                             = GetObject<IRewardProductStatus>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 024665402CF8 0xD0 RewardProduct               ( 00018661F820 ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer )
            value.PickupProduc                              = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024665402D18 0xD8 PickupProduc                ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.Sequence                                  = GetInt32(new IntPtr(p + 0x0E0)); // 024665402D58 0xE0 Sequence                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Ctc                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024665402D78 0xE8 Ctc                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
