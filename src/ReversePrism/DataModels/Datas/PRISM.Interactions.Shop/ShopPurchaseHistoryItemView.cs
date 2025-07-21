using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PurchasedDateText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemTitleText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 JewelText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 FreeJewelText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PurchaseCountText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CashText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 DetailButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 058 ItemIcon                                 ModelClassType RawImage RawImage RawImage Pointer
    // 060 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ShopPurchaseHistoryItemView : DataModel
    {
        public UITextMeshProUGUI?                       PurchasedDateText                       { get; set; }
        public UITextMeshProUGUI?                       ItemTitleText                           { get; set; }
        public UITextMeshProUGUI?                       JewelText                               { get; set; }
        public UITextMeshProUGUI?                       FreeJewelText                           { get; set; }
        public UITextMeshProUGUI?                       PurchaseCountText                       { get; set; }
        public UITextMeshProUGUI?                       CashText                                { get; set; }
        public UIButton?                                DetailButton                            { get; set; }
        public RawImage?                                ItemIcon                                { get; set; }

        public static ShopPurchaseHistoryItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseHistoryItemView() { Pointer= p0 };

            value.PurchasedDateText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 PurchasedDateText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemTitleText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ItemTitleText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.JewelText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 JewelText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FreeJewelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 FreeJewelText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 PurchaseCountText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CashText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 CashText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 DetailButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemIcon                                  = GetObject<RawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.RawImage.FromPointer); // 0x58 ItemIcon                    ( ModelClassType RawImage RawImage RawImage Pointer )

            return value;
        }
    }
}
