using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackGroundImage                          ModelClassType RawImage RawImage RawImage Pointer
    // 028 SeasonLogoImage                          ModelClassType RawImage RawImage RawImage Pointer
    // 030 SeasonPeriodLabel                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SeasonPeriodText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 SeasonMissionButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 048 SeasonPassIconImage                      ModelClassType RawImage RawImage RawImage Pointer
    // 050 PassNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 PassPossesionText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 PassDetailButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 068 PurchaseButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 070 PriceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 080 ViewModel                                ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 088 onClickPurchase                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onClickDetail                            Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 098 onClickSeasonMission                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onViewUpdateSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopSeasonPassView : DataModel
    {
        public RawImage?                                BackGroundImage                         { get; set; }
        public RawImage?                                SeasonLogoImage                         { get; set; }
        public UITextMeshProUGUI?                       SeasonPeriodLabel                       { get; set; }
        public UITextMeshProUGUI?                       SeasonPeriodText                        { get; set; }
        public UIButton?                                SeasonMissionButton                     { get; set; }
        public RawImage?                                SeasonPassIconImage                     { get; set; }
        public UITextMeshProUGUI?                       PassNameText                            { get; set; }
        public UITextMeshProUGUI?                       PassPossesionText                       { get; set; }
        public UIButton?                                PassDetailButton                        { get; set; }
        public UIButton?                                PurchaseButton                          { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ShopViewModel?                           ViewModel                               { get; set; }

        public static ShopSeasonPassView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopSeasonPassView() { Pointer= p0 };

            value.BackGroundImage                           = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 BackGroundImage             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.SeasonLogoImage                           = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 SeasonLogoImage             ( ModelClassType RawImage RawImage RawImage Pointer )
            value.SeasonPeriodLabel                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 SeasonPeriodLabel           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SeasonPeriodText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 SeasonPeriodText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SeasonMissionButton                       = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 SeasonMissionButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SeasonPassIconImage                       = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0x48 SeasonPassIconImage         ( ModelClassType RawImage RawImage RawImage Pointer )
            value.PassNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 PassNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PassPossesionText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 PassPossesionText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PassDetailButton                          = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 PassDetailButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PurchaseButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 PurchaseButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 PriceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x78 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0x80 ViewModel                   ( ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )

            return value;
        }
    }
}
