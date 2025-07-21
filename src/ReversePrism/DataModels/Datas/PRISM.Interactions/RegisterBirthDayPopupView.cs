using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Model                                    ModelClassType RegisterBirthdayModel RegisterBirthdayModel RegisterBirthdayModel Pointer
    // 028 InputField                               ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 030 InputLengthText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TermsButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 TermsButtonLabel                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 DescriptionUnder16                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Description16To18                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 OnRegisterButtonClicked                  ModelClassType RegisterButtonClickedDelegate RegisterButtonClickedDelegate RegisterButtonClickedDelegate Pointer
    // 060 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class RegisterBirthDayPopupView : DataModel
    {
        public RegisterBirthdayModel?                   Model                                   { get; set; }
        public CommonInputFieldTMP?                     InputField                              { get; set; }
        public UITextMeshProUGUI?                       InputLengthText                         { get; set; }
        public UIButton?                                TermsButton                             { get; set; }
        public UITextMeshProUGUI?                       TermsButtonLabel                        { get; set; }
        public UITextMeshProUGUI?                       DescriptionUnder16                      { get; set; }
        public UITextMeshProUGUI?                       Description16To18                       { get; set; }
        public RegisterButtonClickedDelegate?           OnRegisterButtonClicked                 { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static RegisterBirthDayPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthDayPopupView() { Pointer= p0 };

            value.Model                                     = GetObject<RegisterBirthdayModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.RegisterBirthdayModel.FromPointer); // 0x20 Model                       ( ModelClassType RegisterBirthdayModel RegisterBirthdayModel RegisterBirthdayModel Pointer )
            value.InputField                                = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x28 InputField                  ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.InputLengthText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 InputLengthText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TermsButton                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 TermsButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TermsButtonLabel                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TermsButtonLabel            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionUnder16                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 DescriptionUnder16          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Description16To18                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 Description16To18           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OnRegisterButtonClicked                   = GetObject<RegisterButtonClickedDelegate>(new IntPtr(p + 0x058), ReversePrism.DataModels.RegisterButtonClickedDelegate.FromPointer); // 0x58 OnRegisterButtonClicked     ( ModelClassType RegisterButtonClickedDelegate RegisterButtonClickedDelegate RegisterButtonClickedDelegate Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x60 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x70 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
