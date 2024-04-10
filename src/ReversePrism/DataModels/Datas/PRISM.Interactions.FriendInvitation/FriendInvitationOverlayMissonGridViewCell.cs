using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 MissionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RewardItemIcon                           00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 040 ProgressText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ProgressImage                            0001866CCDB0 ModelClassType Image Image Image Pointer
    // 050 CloseLayoutObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ClearStampImageObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class FriendInvitationOverlayMissonGridViewCell : DataModel
    {
        public UITextMeshProUGUI?                       MissionText                             { get; set; }
        public RewardItemIcon?                          RewardItemIcon                          { get; set; }
        public UITextMeshProUGUI?                       ProgressText                            { get; set; }
        public Image?                                   ProgressImage                           { get; set; }
        public GameObject?                              CloseLayoutObject                       { get; set; }
        public GameObject?                              ClearStampImageObject                   { get; set; }

        public static FriendInvitationOverlayMissonGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendInvitationOverlayMissonGridViewCell() { Pointer= p0 };

            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF79588 0x30 MissionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 02466BF795A8 0x38 RewardItemIcon              ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ProgressText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF795C8 0x40 ProgressText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProgressImage                             = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 02466BF795E8 0x48 ProgressImage               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CloseLayoutObject                         = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF79608 0x50 CloseLayoutObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStampImageObject                     = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF79628 0x58 ClearStampImageObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
