using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SubMessageBody                           ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 028 SubMessageFontSize                       ModelPrimitiveType int int int Int32
    // 030 SubMessageCaution                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 AnalyticsButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 040 AnalyticsButtonText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 AdvertisementButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 050 AdvertisementButtonText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 AnalyticsToggle                          ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 060 AnalyticsToggleText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 AdvertisementToggle                      ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 070 AdvertisementToggleText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 onClickDescriptionButton                 Subject`1<ConsentType> IL2CPP_TYPE_GENERICINST
    // 080 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 ViewModel                                ModelClassType PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel Pointer
    // 090 onClosingFunc                            Func`2<FooterButtonType, UniTask> IL2CPP_TYPE_GENERICINST
    // 098 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class PrivacyOptionPopupView : DataModel
    {
        public XMLPanel?                                SubMessageBody                          { get; set; }
        public int                                      SubMessageFontSize                      { get; set; }
        public UITextMeshProUGUI?                       SubMessageCaution                       { get; set; }
        public UIButton?                                AnalyticsButton                         { get; set; }
        public UITextMeshProUGUI?                       AnalyticsButtonText                     { get; set; }
        public UIButton?                                AdvertisementButton                     { get; set; }
        public UITextMeshProUGUI?                       AdvertisementButtonText                 { get; set; }
        public ToggleButton?                            AnalyticsToggle                         { get; set; }
        public UITextMeshProUGUI?                       AnalyticsToggleText                     { get; set; }
        public ToggleButton?                            AdvertisementToggle                     { get; set; }
        public UITextMeshProUGUI?                       AdvertisementToggleText                 { get; set; }
        public PrivacyOptionPopupViewModel?             ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static PrivacyOptionPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrivacyOptionPopupView() { Pointer= p0 };

            value.SubMessageBody                            = GetObject<XMLPanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.XMLPanel.FromPointer); // 0x20 SubMessageBody              ( ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.SubMessageFontSize                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 SubMessageFontSize          ( ModelPrimitiveType int int int Int32 )
            value.SubMessageCaution                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 SubMessageCaution           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnalyticsButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 AnalyticsButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AnalyticsButtonText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 AnalyticsButtonText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AdvertisementButton                       = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 AdvertisementButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AdvertisementButtonText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 AdvertisementButtonText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnalyticsToggle                           = GetObject<ToggleButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x58 AnalyticsToggle             ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.AnalyticsToggleText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 AnalyticsToggleText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AdvertisementToggle                       = GetObject<ToggleButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x68 AdvertisementToggle         ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.AdvertisementToggleText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 AdvertisementToggleText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<PrivacyOptionPopupViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.PrivacyOptionPopupViewModel.FromPointer); // 0x88 ViewModel                   ( ModelClassType PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x98 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
