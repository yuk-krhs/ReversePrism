using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackGroundImage                          000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 SeasonLogoImage                          000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 SeasonPeriodLabel                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SeasonPeriodText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 SeasonMissionButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 SeasonPassIconImage                      000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 050 PassNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 PassPossesionText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 PassDetailButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 PurchaseButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 080 seasonMissionOverlayFactory              OverlayViewFactory`1<ISeasonMissionView> IL2CPP_TYPE_GENERICINST
    // 088 ViewModel                                000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 090 onClickPurchase                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 onClickDetail                            Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 0A0 onClickSeasonMission                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A8 onViewUpdateSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopSeasonPassView
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
            var value   = new ShopSeasonPassView();

            value.BackGroundImage                           = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB807850 0x20 BackGroundImage             ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.SeasonLogoImage                           = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB807870 0x28 SeasonLogoImage             ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.SeasonPeriodLabel                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB807890 0x30 SeasonPeriodLabel           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SeasonPeriodText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8078B0 0x38 SeasonPeriodText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SeasonMissionButton                       = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8078D0 0x40 SeasonMissionButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SeasonPassIconImage                       = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB8078F0 0x48 SeasonPassIconImage         ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.PassNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB807910 0x50 PassNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PassPossesionText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB807930 0x58 PassPossesionText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PassDetailButton                          = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB807950 0x60 PassDetailButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PurchaseButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB807970 0x68 PurchaseButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB807990 0x70 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB8079B0 0x78 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0270DB8079F0 0x88 ViewModel                   ( 000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )

            return value;
        }
    }
}
