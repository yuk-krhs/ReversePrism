using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScenarioNameAndDifficultyText            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 HelpButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 LogButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 BackToHomeButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 GiveUpButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 OptionButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 HelpButtonGrayOutController              0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 058 LogButtonGrayOutController               0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 060 OptionButtonGrayOutController            0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 068 HelpPopupViewFactory                     0001865E9F00 ModelClassType GameHelpListPopupViewFactory GameHelpListPopupViewFactory GameHelpListPopupViewFactory Pointer
    // 070 ProduceLogPopupViewFactory               00018655E460 ModelClassType ProduceLogPopupViewFactory ProduceLogPopupViewFactory ProduceLogPopupViewFactory Pointer
    // 078 ProduceTopMenuBackToHomeConfirmationPopupViewFactory 00018658A210 ModelClassType ProduceTopMenuBackToHomeConfirmationPopupViewFactory ProduceTopMenuBackToHomeConfirmationPopupViewFactory ProduceTopMenuBackToHomeConfirmationPopupViewFactory Pointer
    // 080 ProduceTopMenuGiveUpConfirmationPopupViewFactory 000186545700 ModelClassType ProduceGiveUpConfirmationPopupViewFactory ProduceGiveUpConfirmationPopupViewFactory ProduceGiveUpConfirmationPopupViewFactory Pointer
    // 088 ProduceOptionPopupViewFactory            000186560F20 ModelClassType ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory Pointer
    // 090 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceTopMenuPopupView
    {
        public UITextMeshProUGUI?                       ScenarioNameAndDifficultyText           { get; set; }
        public UIButton?                                HelpButton                              { get; set; }
        public UIButton?                                LogButton                               { get; set; }
        public UIButton?                                BackToHomeButton                        { get; set; }
        public UIButton?                                GiveUpButton                            { get; set; }
        public UIButton?                                OptionButton                            { get; set; }
        public UIGrayOutController?                     HelpButtonGrayOutController             { get; set; }
        public UIGrayOutController?                     LogButtonGrayOutController              { get; set; }
        public UIGrayOutController?                     OptionButtonGrayOutController           { get; set; }
        public GameHelpListPopupViewFactory?            HelpPopupViewFactory                    { get; set; }
        public ProduceLogPopupViewFactory?              ProduceLogPopupViewFactory              { get; set; }
        public ProduceTopMenuBackToHomeConfirmationPopupViewFactory? ProduceTopMenuBackToHomeConfirmationPopupViewFactory { get; set; }
        public ProduceGiveUpConfirmationPopupViewFactory? ProduceTopMenuGiveUpConfirmationPopupViewFactory { get; set; }
        public ProduceOptionPopupViewFactory?           ProduceOptionPopupViewFactory           { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceTopMenuPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTopMenuPopupView();

            value.ScenarioNameAndDifficultyText             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1298D0 0x20 ScenarioNameAndDifficultyText ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HelpButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1298F0 0x28 HelpButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LogButton                                 = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA129910 0x30 LogButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BackToHomeButton                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA129930 0x38 BackToHomeButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GiveUpButton                              = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA129950 0x40 GiveUpButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.OptionButton                              = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA129970 0x48 OptionButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HelpButtonGrayOutController               = GetObject<UIGrayOutController>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA129990 0x50 HelpButtonGrayOutController ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.LogButtonGrayOutController                = GetObject<UIGrayOutController>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA1299B0 0x58 LogButtonGrayOutController  ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.OptionButtonGrayOutController             = GetObject<UIGrayOutController>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA1299D0 0x60 OptionButtonGrayOutController ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.HelpPopupViewFactory                      = GetObject<GameHelpListPopupViewFactory>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameHelpListPopupViewFactory.FromPointer); // 0270DA1299F0 0x68 HelpPopupViewFactory        ( 0001865E9F00 ModelClassType GameHelpListPopupViewFactory GameHelpListPopupViewFactory GameHelpListPopupViewFactory Pointer )
            value.ProduceLogPopupViewFactory                = GetObject<ProduceLogPopupViewFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProduceLogPopupViewFactory.FromPointer); // 0270DA129A10 0x70 ProduceLogPopupViewFactory  ( 00018655E460 ModelClassType ProduceLogPopupViewFactory ProduceLogPopupViewFactory ProduceLogPopupViewFactory Pointer )
            value.ProduceTopMenuBackToHomeConfirmationPopupViewFactory = GetObject<ProduceTopMenuBackToHomeConfirmationPopupViewFactory>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceTopMenuBackToHomeConfirmationPopupViewFactory.FromPointer); // 0270DA129A30 0x78 ProduceTopMenuBackToHomeConfirmationPopupViewFactory ( 00018658A210 ModelClassType ProduceTopMenuBackToHomeConfirmationPopupViewFactory ProduceTopMenuBackToHomeConfirmationPopupViewFactory ProduceTopMenuBackToHomeConfirmationPopupViewFactory Pointer )
            value.ProduceTopMenuGiveUpConfirmationPopupViewFactory = GetObject<ProduceGiveUpConfirmationPopupViewFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceGiveUpConfirmationPopupViewFactory.FromPointer); // 0270DA129A50 0x80 ProduceTopMenuGiveUpConfirmationPopupViewFactory ( 000186545700 ModelClassType ProduceGiveUpConfirmationPopupViewFactory ProduceGiveUpConfirmationPopupViewFactory ProduceGiveUpConfirmationPopupViewFactory Pointer )
            value.ProduceOptionPopupViewFactory             = GetObject<ProduceOptionPopupViewFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProduceOptionPopupViewFactory.FromPointer); // 0270DA129A70 0x88 ProduceOptionPopupViewFactory ( 000186560F20 ModelClassType ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory ProduceOptionPopupViewFactory Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA129AB0 0x98 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
