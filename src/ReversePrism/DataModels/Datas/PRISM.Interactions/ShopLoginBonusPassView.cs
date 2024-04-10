using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackGroundImage                          000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 SeasonPeriodText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 LoginPassIconImage                       000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 038 PassNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PassPossesionText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 PassDetailButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 PurchaseButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 ViewModel                                000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    // 070 onClickPurchaseSubject                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 onClickDetailSubject                     Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 080 onViewUpdateSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ShopLoginBonusPassView : DataModel
    {
        public RawImage?                                BackGroundImage                         { get; set; }
        public UITextMeshProUGUI?                       SeasonPeriodText                        { get; set; }
        public RawImage?                                LoginPassIconImage                      { get; set; }
        public UITextMeshProUGUI?                       PassNameText                            { get; set; }
        public UITextMeshProUGUI?                       PassPossesionText                       { get; set; }
        public UIButton?                                PassDetailButton                        { get; set; }
        public UIButton?                                PurchaseButton                          { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ShopViewModel?                           ViewModel                               { get; set; }

        public static ShopLoginBonusPassView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopLoginBonusPassView() { Pointer= p0 };

            value.BackGroundImage                           = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 02466B6B30B8 0x20 BackGroundImage             ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.SeasonPeriodText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6B30D8 0x28 SeasonPeriodText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LoginPassIconImage                        = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 02466B6B30F8 0x30 LoginPassIconImage          ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.PassNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6B3118 0x38 PassNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PassPossesionText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6B3138 0x40 PassPossesionText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PassDetailButton                          = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6B3158 0x48 PassDetailButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PurchaseButton                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6B3178 0x50 PurchaseButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6B3198 0x58 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B6B31B8 0x60 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShopViewModel.FromPointer); // 02466B6B31D8 0x68 ViewModel                   ( 000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )

            return value;
        }
    }
}
