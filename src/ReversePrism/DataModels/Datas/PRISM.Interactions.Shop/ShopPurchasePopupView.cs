using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoodsDetailPopupPrefab                   ModelClassType ShopGoodsDetailPopupContent ShopGoodsDetailPopupContent ShopGoodsDetailPopupContent Pointer
    // 028 PurchaseConfirmPrefab                    ModelClassType ShopPurchaseConfirmContent ShopPurchaseConfirmContent ShopPurchaseConfirmContent Pointer
    // 030 ConsentConfirmPrefab                     ModelClassType ShopConsentConfirmContent ShopConsentConfirmContent ShopConsentConfirmContent Pointer
    // 038 PurchaseCompletePrefab                   ModelClassType ShopPurchaseCompleteContent ShopPurchaseCompleteContent ShopPurchaseCompleteContent Pointer
    // 040 ChargeAlertPrefab                        ModelClassType ShopChargeAlertContent ShopChargeAlertContent ShopChargeAlertContent Pointer
    // 048 ReceiveBonusPrefab                       ModelClassType ShopReceiveBonusContent ShopReceiveBonusContent ShopReceiveBonusContent Pointer
    // 050 ViewModel                                ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    public partial class ShopPurchasePopupView : DataModel
    {
        public ShopGoodsDetailPopupContent?             GoodsDetailPopupPrefab                  { get; set; }
        public ShopPurchaseConfirmContent?              PurchaseConfirmPrefab                   { get; set; }
        public ShopConsentConfirmContent?               ConsentConfirmPrefab                    { get; set; }
        public ShopPurchaseCompleteContent?             PurchaseCompletePrefab                  { get; set; }
        public ShopChargeAlertContent?                  ChargeAlertPrefab                       { get; set; }
        public ShopReceiveBonusContent?                 ReceiveBonusPrefab                      { get; set; }
        public ShopViewModel?                           ViewModel                               { get; set; }

        public static ShopPurchasePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchasePopupView() { Pointer= p0 };

            value.GoodsDetailPopupPrefab                    = GetObject<ShopGoodsDetailPopupContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopGoodsDetailPopupContent.FromPointer); // 0x20 GoodsDetailPopupPrefab      ( ModelClassType ShopGoodsDetailPopupContent ShopGoodsDetailPopupContent ShopGoodsDetailPopupContent Pointer )
            value.PurchaseConfirmPrefab                     = GetObject<ShopPurchaseConfirmContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopPurchaseConfirmContent.FromPointer); // 0x28 PurchaseConfirmPrefab       ( ModelClassType ShopPurchaseConfirmContent ShopPurchaseConfirmContent ShopPurchaseConfirmContent Pointer )
            value.ConsentConfirmPrefab                      = GetObject<ShopConsentConfirmContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopConsentConfirmContent.FromPointer); // 0x30 ConsentConfirmPrefab        ( ModelClassType ShopConsentConfirmContent ShopConsentConfirmContent ShopConsentConfirmContent Pointer )
            value.PurchaseCompletePrefab                    = GetObject<ShopPurchaseCompleteContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopPurchaseCompleteContent.FromPointer); // 0x38 PurchaseCompletePrefab      ( ModelClassType ShopPurchaseCompleteContent ShopPurchaseCompleteContent ShopPurchaseCompleteContent Pointer )
            value.ChargeAlertPrefab                         = GetObject<ShopChargeAlertContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopChargeAlertContent.FromPointer); // 0x40 ChargeAlertPrefab           ( ModelClassType ShopChargeAlertContent ShopChargeAlertContent ShopChargeAlertContent Pointer )
            value.ReceiveBonusPrefab                        = GetObject<ShopReceiveBonusContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopReceiveBonusContent.FromPointer); // 0x48 ReceiveBonusPrefab          ( ModelClassType ShopReceiveBonusContent ShopReceiveBonusContent ShopReceiveBonusContent Pointer )
            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0x50 ViewModel                   ( ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )

            return value;
        }
    }
}
