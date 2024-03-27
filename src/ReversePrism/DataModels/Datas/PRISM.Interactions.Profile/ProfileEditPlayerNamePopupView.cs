using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NameInputTextKey                         string IL2CPP_TYPE_STRING
    // 020 ProducerNameInputField                   0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 028 ProducerNameCountText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ProducerNameLabelText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NameInputEmptyText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 InfoText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onDecide                                 Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 060 ViewModel                                0001865C7B80 ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileEditPlayerNamePopupView
    {
        public CommonInputFieldTMP?                     ProducerNameInputField                  { get; set; }
        public UITextMeshProUGUI?                       ProducerNameCountText                   { get; set; }
        public UITextMeshProUGUI?                       ProducerNameLabelText                   { get; set; }
        public UITextMeshProUGUI?                       NameInputEmptyText                      { get; set; }
        public UITextMeshProUGUI?                       InfoText                                { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public ProfileUserSelfPanelViewModel?           ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileEditPlayerNamePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEditPlayerNamePopupView();

            value.ProducerNameInputField                    = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0270DB703D58 0x20 ProducerNameInputField      ( 0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ProducerNameCountText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB703D78 0x28 ProducerNameCountText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProducerNameLabelText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB703D98 0x30 ProducerNameLabelText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NameInputEmptyText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB703DB8 0x38 NameInputEmptyText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InfoText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB703DD8 0x40 InfoText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB703DF8 0x48 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<ProfileUserSelfPanelViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfileUserSelfPanelViewModel.FromPointer); // 0270DB703E58 0x60 ViewModel                   ( 0001865C7B80 ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB703E78 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
