using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroupView                             0001867731B0 ModelClassType ShopTabGroupView ShopTabGroupView ShopTabGroupView Pointer
    // 028 ShopGridView                             00018675DB00 ModelClassType ShopGridSellingView ShopGridSellingView ShopGridSellingView Pointer
    // 030 ShopCostumeGridView                      000186757810 ModelClassType ShopCostumeSellingView ShopCostumeSellingView ShopCostumeSellingView Pointer
    // 038 SeasonPassView                           000186771850 ModelClassType ShopSeasonPassView ShopSeasonPassView ShopSeasonPassView Pointer
    // 040 LoginPassView                            000186764160 ModelClassType ShopLoginBonusPassView ShopLoginBonusPassView ShopLoginBonusPassView Pointer
    // 048 PurchasePopupView                        00018676F290 ModelClassType ShopPurchasePopupView ShopPurchasePopupView ShopPurchasePopupView Pointer
    // 050 ActOnSettlementButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 SpecifiedCommercialTransactionActButton  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 PurchaseHistoryButton                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 CloseButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 TitleLabelText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 PaidJewelText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 FreeJewelText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 registerBirthDayPopupFactory             PopupViewFactory`1<IRegisterBirthDayPopupView> IL2CPP_TYPE_GENERICINST
    // 098 passPurchaseConfirmContentViewFactory    PopupViewFactory`1<IShopPassPurchaseConfirmContentViewPopupView> IL2CPP_TYPE_GENERICINST
    // 0A0 passDetailPopupViewFactory               PopupViewFactory`1<IShopPassDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0A8 passCompletePopupViewFactory             PopupViewFactory`1<IShopPassPurchaseCompletePopupView> IL2CPP_TYPE_GENERICINST
    // 0B0 productListPopupViewFactory              PopupViewFactory`1<IShopProductListPopupView> IL2CPP_TYPE_GENERICINST
    // 0B8 receivePurchaseBenefitsPopupViewFactory  PopupViewFactory`1<IShopPassReceivePurchaseBenefitsPopupView> IL2CPP_TYPE_GENERICINST
    // 0C0 shopLoginBonusPassRewardPopupViewFactory PopupViewFactory`1<IShopLoginBonusPassRewardPopupView> IL2CPP_TYPE_GENERICINST
    // 0C8 purchaseHistoryPopupViewFactory          PopupViewFactory`1<IShopPurchaseHistoryPopupView> IL2CPP_TYPE_GENERICINST
    // 0D0 purchaseHistoryDetailPopupViewFactory    PopupViewFactory`1<IShopPurchaseHistoryDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0D8 shopCostumeListPopupViewFactory          PopupViewFactory`1<IShopCostumeListPopupView> IL2CPP_TYPE_GENERICINST
    // 0E0 shopCostumeTryPopupViewFactory           PopupViewFactory`1<IShopCostumeTryPopupView> IL2CPP_TYPE_GENERICINST
    // 0E8 costumeDetailPopupViewFactory            PopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0F0 Model                                    000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 0F8 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 100 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 108 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 110 onUpdateListSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 118 onOpenPassPurchaseCompleteSubject        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopView
    {
        public ShopTabGroupView?                        TabGroupView                            { get; set; }
        public ShopGridSellingView?                     ShopGridView                            { get; set; }
        public ShopCostumeSellingView?                  ShopCostumeGridView                     { get; set; }
        public ShopSeasonPassView?                      SeasonPassView                          { get; set; }
        public ShopLoginBonusPassView?                  LoginPassView                           { get; set; }
        public ShopPurchasePopupView?                   PurchasePopupView                       { get; set; }
        public UIButton?                                ActOnSettlementButton                   { get; set; }
        public UIButton?                                SpecifiedCommercialTransactionActButton { get; set; }
        public UIButton?                                PurchaseHistoryButton                   { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public UITextMeshProUGUI?                       TitleLabelText                          { get; set; }
        public UITextMeshProUGUI?                       PaidJewelText                           { get; set; }
        public UITextMeshProUGUI?                       FreeJewelText                           { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ShopViewModel?                           Model                                   { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public CancellationToken                        Ct                                      { get; set; }

        public static ShopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopView();

            value.TabGroupView                              = GetObject<ShopTabGroupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopTabGroupView.FromPointer); // 0270DB8067C0 0x20 TabGroupView                ( 0001867731B0 ModelClassType ShopTabGroupView ShopTabGroupView ShopTabGroupView Pointer )
            value.ShopGridView                              = GetObject<ShopGridSellingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopGridSellingView.FromPointer); // 0270DB8067E0 0x28 ShopGridView                ( 00018675DB00 ModelClassType ShopGridSellingView ShopGridSellingView ShopGridSellingView Pointer )
            value.ShopCostumeGridView                       = GetObject<ShopCostumeSellingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopCostumeSellingView.FromPointer); // 0270DB806800 0x30 ShopCostumeGridView         ( 000186757810 ModelClassType ShopCostumeSellingView ShopCostumeSellingView ShopCostumeSellingView Pointer )
            value.SeasonPassView                            = GetObject<ShopSeasonPassView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopSeasonPassView.FromPointer); // 0270DB806820 0x38 SeasonPassView              ( 000186771850 ModelClassType ShopSeasonPassView ShopSeasonPassView ShopSeasonPassView Pointer )
            value.LoginPassView                             = GetObject<ShopLoginBonusPassView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopLoginBonusPassView.FromPointer); // 0270DB806840 0x40 LoginPassView               ( 000186764160 ModelClassType ShopLoginBonusPassView ShopLoginBonusPassView ShopLoginBonusPassView Pointer )
            value.PurchasePopupView                         = GetObject<ShopPurchasePopupView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopPurchasePopupView.FromPointer); // 0270DB806860 0x48 PurchasePopupView           ( 00018676F290 ModelClassType ShopPurchasePopupView ShopPurchasePopupView ShopPurchasePopupView Pointer )
            value.ActOnSettlementButton                     = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB806880 0x50 ActOnSettlementButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SpecifiedCommercialTransactionActButton   = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8068A0 0x58 SpecifiedCommercialTransactionActButton ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PurchaseHistoryButton                     = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8068C0 0x60 PurchaseHistoryButton       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8068E0 0x68 CloseButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TitleLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB806900 0x70 TitleLabelText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PaidJewelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB806920 0x78 PaidJewelText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FreeJewelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB806940 0x80 FreeJewelText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB806960 0x88 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Model                                     = GetObject<ShopViewModel>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0270DB806B00 0xF0 Model                       ( 000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DB806B20 0xF8 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x100), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB806B40 0x100 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x108)); // 0270DB806B60 0x108 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
