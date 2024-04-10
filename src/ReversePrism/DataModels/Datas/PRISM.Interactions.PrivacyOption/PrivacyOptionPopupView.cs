using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SubMessageBody                           000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 028 SubMessageFontSize                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 SubMessageCaution                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 AnalyticsButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 AnalyticsButtonText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 AdvertisementButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 AdvertisementButtonText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 AnalyticsToggle                          000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 060 AnalyticsToggleText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 AdvertisementToggle                      000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 070 AdvertisementToggleText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 onClickDescriptionButton                 Subject`1<ConsentType> IL2CPP_TYPE_GENERICINST
    // 080 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 ViewModel                                00018651C680 ModelClassType PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel Pointer
    // 090 onClosingFunc                            Func`2<FooterButtonType, UniTask> IL2CPP_TYPE_GENERICINST
    // 098 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.SubMessageBody                            = GetObject<XMLPanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.XMLPanel.FromPointer); // 02466B625628 0x20 SubMessageBody              ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.SubMessageFontSize                        = GetInt32(new IntPtr(p + 0x028)); // 02466B625648 0x28 SubMessageFontSize          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SubMessageCaution                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B625668 0x30 SubMessageCaution           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnalyticsButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B625688 0x38 AnalyticsButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AnalyticsButtonText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6256A8 0x40 AnalyticsButtonText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AdvertisementButton                       = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466B6256C8 0x48 AdvertisementButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AdvertisementButtonText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B6256E8 0x50 AdvertisementButtonText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AnalyticsToggle                           = GetObject<ToggleButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466B625708 0x58 AnalyticsToggle             ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.AnalyticsToggleText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B625728 0x60 AnalyticsToggleText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AdvertisementToggle                       = GetObject<ToggleButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466B625748 0x68 AdvertisementToggle         ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.AdvertisementToggleText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B625768 0x70 AdvertisementToggleText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<PrivacyOptionPopupViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.PrivacyOptionPopupViewModel.FromPointer); // 02466B6257C8 0x88 ViewModel                   ( 00018651C680 ModelClassType PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel PrivacyOptionPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B625808 0x98 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
