using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProductItem                              000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 028 ItemNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ExchangeItemIcon                         00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 038 AmountText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ExchangeLimitText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 RewardPieceItem                          00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 050 PieceLabelText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ExchangeButtonItemIcon                   00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 060 ExchangeButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 GrayoutImage                             0001866CCDB0 ModelClassType Image Image Image Pointer
    // 070 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeSelectionItemView : DataModel
    {
        public GashaProductItemPresenter?               ProductItem                             { get; set; }
        public UITextMeshProUGUI?                       ItemNameText                            { get; set; }
        public RewardItem?                              ExchangeItemIcon                        { get; set; }
        public UITextMeshProUGUI?                       AmountText                              { get; set; }
        public UITextMeshProUGUI?                       ExchangeLimitText                       { get; set; }
        public RewardItem?                              RewardPieceItem                         { get; set; }
        public UITextMeshProUGUI?                       PieceLabelText                          { get; set; }
        public RewardItem?                              ExchangeButtonItemIcon                  { get; set; }
        public UIButton?                                ExchangeButton                          { get; set; }
        public Image?                                   GrayoutImage                            { get; set; }

        public static ExchangeSelectionItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionItemView() { Pointer= p0 };

            value.ProductItem                               = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 02466B9752F0 0x20 ProductItem                 ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.ItemNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B975310 0x28 ItemNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeItemIcon                          = GetObject<RewardItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B975330 0x30 ExchangeItemIcon            ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.AmountText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B975350 0x38 AmountText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeLimitText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B975370 0x40 ExchangeLimitText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardPieceItem                           = GetObject<RewardItem>(new IntPtr(p + 0x048), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B975390 0x48 RewardPieceItem             ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9753B0 0x50 PieceLabelText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeButtonItemIcon                    = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B9753D0 0x58 ExchangeButtonItemIcon      ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExchangeButton                            = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466B9753F0 0x60 ExchangeButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GrayoutImage                              = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 02466B975410 0x68 GrayoutImage                ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
