using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 ExpiryObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 030 ExpiryDate                               ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 InputField                               ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 040 InputFieldText                           ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 InputFieldMask                           ModelClassType GameObject GameObject GameObject Pointer
    // 050 OkButton                                 ModelClassType UIButton UIButton UIButton Pointer
    // 058 OkButtonMask                             ModelClassType GameObject GameObject GameObject Pointer
    // 060 MissionCell                              ModelClassType FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell Pointer
    // 068 MyInvitationCode                         ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 070 CopyButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 078 IssueButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 080 MissionGridView                          ModelClassType FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView Pointer
    // 088 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 090 BackButton                               ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer
    // 098 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A0 ViewModel                                ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer
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

            value.TitleText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x20 TitleText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ExpiryObject                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ExpiryObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpiryDate                                = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 ExpiryDate                  ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.InputField                                = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x38 InputField                  ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.InputFieldText                            = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x40 InputFieldText              ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.InputFieldMask                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 InputFieldMask              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OkButton                                  = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 OkButton                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.OkButtonMask                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 OkButtonMask                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionCell                               = GetObject<FriendInvitationOverlayMissonGridViewCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.FriendInvitationOverlayMissonGridViewCell.FromPointer); // 0x60 MissionCell                 ( ModelClassType FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell FriendInvitationOverlayMissonGridViewCell Pointer )
            value.MyInvitationCode                          = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x68 MyInvitationCode            ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CopyButton                                = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 CopyButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IssueButton                               = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 IssueButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.MissionGridView                           = GetObject<FriendInvitationOverlayMissionGridView>(new IntPtr(p + 0x080), ReversePrism.DataModels.FriendInvitationOverlayMissionGridView.FromPointer); // 0x80 MissionGridView             ( ModelClassType FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView FriendInvitationOverlayMissionGridView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x088), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x88 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.BackButton                                = GetObject<ViewBackButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.ViewBackButton.FromPointer); // 0x90 BackButton                  ( ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x98 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ViewModel                                 = GetObject<FriendInvitationOverlayViewModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FriendInvitationOverlayViewModel.FromPointer); // 0xA0 ViewModel                   ( ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer )

            return value;
        }
    }
}
