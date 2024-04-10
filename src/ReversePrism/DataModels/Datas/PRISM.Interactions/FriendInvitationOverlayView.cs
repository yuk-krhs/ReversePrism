using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 ExpiryObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 ExpiryDate                               0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 InputField                               0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 040 InputFieldText                           0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 InputFieldMask                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 OkButton                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 OkButtonMask                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 MissionCell                              0001865C4330 ModelClassType FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell Pointer
    // 068 MyInvitationCode                         0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 070 CopyButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 IssueButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 MissionGridView                          0001865C3E70 ModelClassType FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView Pointer
    // 088 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 090 BackButton                               00018651A320 ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer
    // 098 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 0A8 ViewModel                                0001865C5520 ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer
    public partial class FriendInvitationOverlayView : DataModel
    {
        public TextMeshProUGUI?                         TitleText                               { get; set; }
        public GameObject?                              ExpiryObject                            { get; set; }
        public TextMeshProUGUI?                         ExpiryDate                              { get; set; }
        public CommonInputFieldTMP?                     InputField                              { get; set; }
        public TextMeshProUGUI?                         InputFieldText                          { get; set; }
        public GameObject?                              InputFieldMask                          { get; set; }
        public UIButton?                                OkButton                                { get; set; }
        public GameObject?                              OkButtonMask                            { get; set; }
        public FriendInvitationOverlayMissonGridViewCell? MissionCell                             { get; set; }
        public TextMeshProUGUI?                         MyInvitationCode                        { get; set; }
        public UIButton?                                CopyButton                              { get; set; }
        public UIButton?                                IssueButton                             { get; set; }
        public FriendInvitationOverlayMissionGridView?  MissionGridView                         { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ViewBackButton?                          BackButton                              { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public FriendInvitationOverlayViewModel?        ViewModel                               { get; set; }

        public static FriendInvitationOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendInvitationOverlayView() { Pointer= p0 };

            value.TitleText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466BF79068 0x20 TitleText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ExpiryObject                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF79088 0x28 ExpiryObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpiryDate                                = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466BF790A8 0x30 ExpiryDate                  ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.InputField                                = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 02466BF790C8 0x38 InputField                  ( 0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.InputFieldText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466BF790E8 0x40 InputFieldText              ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.InputFieldMask                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF79108 0x48 InputFieldMask              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OkButton                                  = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466BF79128 0x50 OkButton                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.OkButtonMask                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF79148 0x58 OkButtonMask                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionCell                               = GetObject<FriendInvitationOverlayMissonGridViewCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.FriendInvitationOverlayMissonGridViewCell.FromPointer); // 02466BF79168 0x60 MissionCell                 ( 0001865C4330 ModelClassType FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell Pointer )
            value.MyInvitationCode                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466BF79188 0x68 MyInvitationCode            ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CopyButton                                = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 02466BF791A8 0x70 CopyButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IssueButton                               = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 02466BF791C8 0x78 IssueButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MissionGridView                           = GetObject<FriendInvitationOverlayMissionGridView>(new IntPtr(p + 0x080), ReversePrism.DataModels.FriendInvitationOverlayMissionGridView.FromPointer); // 02466BF791E8 0x80 MissionGridView             ( 0001865C3E70 ModelClassType FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x088), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466BF79208 0x88 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.BackButton                                = GetObject<ViewBackButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.ViewBackButton.FromPointer); // 02466BF79228 0x90 BackButton                  ( 00018651A320 ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466BF79248 0x98 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<FriendInvitationOverlayViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FriendInvitationOverlayViewModel.FromPointer); // 02466BF79288 0xA8 ViewModel                   ( 0001865C5520 ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer )

            return value;
        }
    }
}
