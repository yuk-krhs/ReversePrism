using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroupView                             ModelClassType ShopTabGroupView ShopTabGroupView ShopTabGroupView Pointer
    // 028 ShopGridView                             ModelClassType ShopGridSellingView ShopGridSellingView ShopGridSellingView Pointer
    // 030 ShopCostumeGridView                      ModelClassType ShopCostumeSellingView ShopCostumeSellingView ShopCostumeSellingView Pointer
    // 038 SeasonPassView                           ModelClassType ShopSeasonPassView ShopSeasonPassView ShopSeasonPassView Pointer
    // 040 LoginPassView                            ModelClassType ShopLoginBonusPassView ShopLoginBonusPassView ShopLoginBonusPassView Pointer
    // 048 PurchasePopupView                        ModelClassType ShopPurchasePopupView ShopPurchasePopupView ShopPurchasePopupView Pointer
    // 050 ActOnSettlementButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 058 SpecifiedCommercialTransactionActButton  ModelClassType UIButton UIButton UIButton Pointer
    // 060 PurchaseHistoryButton                    ModelClassType UIButton UIButton UIButton Pointer
    // 068 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 070 TitleLabelText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 PaidJewelText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 FreeJewelText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 Model                                    ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 098 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0A0 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0A8 onUpdateListSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 onOpenPassPurchaseCompleteSubject        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopView : DataModel
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

        public static ShopView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopView() { Pointer= p0 };

            value.TabGroupView                              = GetObject<ShopTabGroupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopTabGroupView.FromPointer); // 0x20 TabGroupView                ( ModelClassType ShopTabGroupView ShopTabGroupView ShopTabGroupView Pointer )
            value.ShopGridView                              = GetObject<ShopGridSellingView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopGridSellingView.FromPointer); // 0x28 ShopGridView                ( ModelClassType ShopGridSellingView ShopGridSellingView ShopGridSellingView Pointer )
            value.ShopCostumeGridView                       = GetObject<ShopCostumeSellingView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopCostumeSellingView.FromPointer); // 0x30 ShopCostumeGridView         ( ModelClassType ShopCostumeSellingView ShopCostumeSellingView ShopCostumeSellingView Pointer )
            value.SeasonPassView                            = GetObject<ShopSeasonPassView>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopSeasonPassView.FromPointer); // 0x38 SeasonPassView              ( ModelClassType ShopSeasonPassView ShopSeasonPassView ShopSeasonPassView Pointer )
            value.LoginPassView                             = GetObject<ShopLoginBonusPassView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopLoginBonusPassView.FromPointer); // 0x40 LoginPassView               ( ModelClassType ShopLoginBonusPassView ShopLoginBonusPassView ShopLoginBonusPassView Pointer )
            value.PurchasePopupView                         = GetObject<ShopPurchasePopupView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopPurchasePopupView.FromPointer); // 0x48 PurchasePopupView           ( ModelClassType ShopPurchasePopupView ShopPurchasePopupView ShopPurchasePopupView Pointer )
            value.ActOnSettlementButton                     = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 ActOnSettlementButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SpecifiedCommercialTransactionActButton   = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 SpecifiedCommercialTransactionActButton ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PurchaseHistoryButton                     = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 PurchaseHistoryButton       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TitleLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TitleLabelText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PaidJewelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 PaidJewelText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FreeJewelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 FreeJewelText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x88 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Model                                     = GetObject<ShopViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0x90 Model                       ( ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x98 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xA0 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
