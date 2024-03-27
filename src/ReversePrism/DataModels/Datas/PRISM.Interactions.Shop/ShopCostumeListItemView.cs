using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NewIcon                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 IconImage                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 GrayoutImage                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 PurchaseButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 DetailButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 TryButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ExpireDateText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 PurchaseCountLimitText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 LimitTimeDisposable                      0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 070 onPurchaseProduct                        Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 078 onDetail                                 Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 080 onTry                                    Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    public partial class ShopCostumeListItemView
    {
        public GameObject?                              NewIcon                                 { get; set; }
        public RawImage?                                IconImage                               { get; set; }
        public GameObject?                              GrayoutImage                            { get; set; }
        public UIButton?                                PurchaseButton                          { get; set; }
        public UIButton?                                DetailButton                            { get; set; }
        public UIButton?                                TryButton                               { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public UITextMeshProUGUI?                       ExpireDateText                          { get; set; }
        public UITextMeshProUGUI?                       PurchaseCountLimitText                  { get; set; }
        public IDisposable?                             LimitTimeDisposable                     { get; set; }

        public static ShopCostumeListItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeListItemView();

            value.NewIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB820268 0x20 NewIcon                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IconImage                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB820288 0x28 IconImage                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.GrayoutImage                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8202A8 0x30 GrayoutImage                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8202C8 0x38 PurchaseButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8202E8 0x40 DetailButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TryButton                                 = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB820308 0x48 TryButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB820328 0x50 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB820348 0x58 ExpireDateText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseCountLimitText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB820368 0x60 PurchaseCountLimitText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitTimeDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB820388 0x68 LimitTimeDisposable         ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
