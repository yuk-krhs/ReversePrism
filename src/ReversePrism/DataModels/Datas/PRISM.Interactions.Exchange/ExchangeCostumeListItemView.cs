using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CostumeTicketThumbnailImageNameBase      string IL2CPP_TYPE_STRING
    // 020 NewIcon                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 IconImage                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 GrayoutImage                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ButtonTicketImage                        000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 040 ExchangeButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 DetailButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ExpireDateText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ExchangeCountLimitText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CostumeDetailPopupCaller                 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer
    // 070 LimitTimeDisposable                      0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 078 onTargetProductIndex                     Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 onDetail                                 Subject`1<ExchangeSelectionListItemViewModel> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeCostumeListItemView : DataModel
    {
        public GameObject?                              NewIcon                                 { get; set; }
        public RawImage?                                IconImage                               { get; set; }
        public GameObject?                              GrayoutImage                            { get; set; }
        public RawImage?                                ButtonTicketImage                       { get; set; }
        public UIButton?                                ExchangeButton                          { get; set; }
        public UIButton?                                DetailButton                            { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public UITextMeshProUGUI?                       ExpireDateText                          { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountLimitText                  { get; set; }
        public CostumeDetailPopupCaller?                CostumeDetailPopupCaller                { get; set; }
        public IDisposable?                             LimitTimeDisposable                     { get; set; }

        public static ExchangeCostumeListItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeCostumeListItemView() { Pointer= p0 };

            value.NewIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98A568 0x20 NewIcon                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IconImage                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 02466B98A588 0x28 IconImage                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.GrayoutImage                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98A5A8 0x30 GrayoutImage                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ButtonTicketImage                         = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 02466B98A5C8 0x38 ButtonTicketImage           ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ExchangeButton                            = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466B98A5E8 0x40 ExchangeButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466B98A608 0x48 DetailButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98A628 0x50 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98A648 0x58 ExpireDateText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountLimitText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98A668 0x60 ExchangeCountLimitText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeDetailPopupCaller                  = GetObject<CostumeDetailPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.CostumeDetailPopupCaller.FromPointer); // 02466B98A688 0x68 CostumeDetailPopupCaller    ( 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer )
            value.LimitTimeDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B98A6A8 0x70 LimitTimeDisposable         ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
