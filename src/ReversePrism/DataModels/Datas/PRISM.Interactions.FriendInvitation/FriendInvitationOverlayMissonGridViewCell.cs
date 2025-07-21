using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 MissionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RewardItemIcon                           ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 040 ProgressText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ProgressImage                            ModelClassType Image Image Image Pointer
    // 050 CloseLayoutObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 058 ClearStampImageObject                    ModelClassType GameObject GameObject GameObject Pointer
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

            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 MissionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x38 RewardItemIcon              ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ProgressText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ProgressText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProgressImage                             = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 ProgressImage               ( ModelClassType Image Image Image Pointer )
            value.CloseLayoutObject                         = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 CloseLayoutObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStampImageObject                     = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ClearStampImageObject       ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
