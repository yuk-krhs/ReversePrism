using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CostumeTicketThumbnailImageNameBase      string IL2CPP_TYPE_STRING
    // 020 NewIcon                                  ModelClassType GameObject GameObject GameObject Pointer
    // 028 IconImage                                ModelClassType RawImage RawImage RawImage Pointer
    // 030 GrayoutImage                             ModelClassType GameObject GameObject GameObject Pointer
    // 038 ButtonTicketImage                        ModelClassType RawImage RawImage RawImage Pointer
    // 040 ExchangeButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 048 DetailButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 050 PriceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ExpireDateText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ExchangeCountLimitText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 LabelAreaObj                             ModelClassType GameObject GameObject GameObject Pointer
    // 070 AlreadyAcquiredLabelObj                  ModelClassType GameObject GameObject GameObject Pointer
    // 078 AlreadyAcquiredText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 LimitTimeDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    // 088 onTargetProductIndex                     Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 090 onDetail                                 Subject`1<ExchangeSelectionListItemViewModel> IL2CPP_TYPE_GENERICINST
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
        public GameObject?                              LabelAreaObj                            { get; set; }
        public GameObject?                              AlreadyAcquiredLabelObj                 { get; set; }
        public UITextMeshProUGUI?                       AlreadyAcquiredText                     { get; set; }
        public IDisposable?                             LimitTimeDisposable                     { get; set; }

        public static ExchangeCostumeListItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeCostumeListItemView() { Pointer= p0 };

            value.NewIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 NewIcon                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IconImage                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 IconImage                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.GrayoutImage                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GrayoutImage                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ButtonTicketImage                         = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 0x38 ButtonTicketImage           ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ExchangeButton                            = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 ExchangeButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 DetailButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 PriceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpireDateText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ExpireDateText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountLimitText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 ExchangeCountLimitText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LabelAreaObj                              = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 LabelAreaObj                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AlreadyAcquiredLabelObj                   = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 AlreadyAcquiredLabelObj     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AlreadyAcquiredText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 AlreadyAcquiredText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitTimeDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDisposable.FromPointer); // 0x80 LimitTimeDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
