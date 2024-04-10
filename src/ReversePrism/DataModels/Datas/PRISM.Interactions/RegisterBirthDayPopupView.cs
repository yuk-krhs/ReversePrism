using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 028 Model                                    0001866443A0 ModelClassType RegisterBirthdayModel RegisterBirthdayModel RegisterBirthdayModel Pointer
    // 030 InputField                               0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 038 InputLengthText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TermsButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 TermsButtonLabel                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 DescriptionUnder16                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Description16To18                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 registerBirthdayConfirmPopupFactory      PopupViewFactory`1<IRegisterBirthdayConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 068 onRegisterButtonClicked                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 078 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 080 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class RegisterBirthDayPopupView : DataModel
    {
        public RegisterBirthdayModel?                   Model                                   { get; set; }
        public CommonInputFieldTMP?                     InputField                              { get; set; }
        public UITextMeshProUGUI?                       InputLengthText                         { get; set; }
        public UIButton?                                TermsButton                             { get; set; }
        public UITextMeshProUGUI?                       TermsButtonLabel                        { get; set; }
        public UITextMeshProUGUI?                       DescriptionUnder16                      { get; set; }
        public UITextMeshProUGUI?                       Description16To18                       { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static RegisterBirthDayPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthDayPopupView() { Pointer= p0 };

            value.Model                                     = GetObject<RegisterBirthdayModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.RegisterBirthdayModel.FromPointer); // 02466B85F298 0x28 Model                       ( 0001866443A0 ModelClassType RegisterBirthdayModel RegisterBirthdayModel RegisterBirthdayModel Pointer )
            value.InputField                                = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 02466B85F2B8 0x30 InputField                  ( 0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.InputLengthText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B85F2D8 0x38 InputLengthText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TermsButton                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466B85F2F8 0x40 TermsButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TermsButtonLabel                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B85F318 0x48 TermsButtonLabel            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionUnder16                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B85F338 0x50 DescriptionUnder16          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Description16To18                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B85F358 0x58 Description16To18           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466B85F3B8 0x70 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B85F3F8 0x80 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
