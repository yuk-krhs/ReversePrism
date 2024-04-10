using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ListButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 UnknownButton                            000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 GetButtonObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ChallengeButtonObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 CloseButtonObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 MissionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 Gauge                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 078 ProgressText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 RewardItemIcon                           000185CA1078 ModelClassListType RewardItemIcon[] RewardItemIcon[] List<RewardItemIcon> Pointer
    // 088 CloseLayoutObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 ClearStampObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class SpecialMissionListViewCell : DataModel
    {
        public ButtonBase?                              ListButton                              { get; set; }
        public ButtonBase?                              UnknownButton                           { get; set; }
        public GameObject?                              GetButtonObject                         { get; set; }
        public GameObject?                              ChallengeButtonObject                   { get; set; }
        public GameObject?                              CloseButtonObject                       { get; set; }
        public UITextMeshProUGUI?                       MissionText                             { get; set; }
        public Image?                                   Gauge                                   { get; set; }
        public UITextMeshProUGUI?                       ProgressText                            { get; set; }
        public List<RewardItemIcon>?                    RewardItemIcon                          { get; set; }
        public GameObject?                              CloseLayoutObject                       { get; set; }
        public GameObject?                              ClearStampObject                        { get; set; }

        public static SpecialMissionListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionListViewCell() { Pointer= p0 };

            value.ListButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BDE0460 0x40 ListButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnknownButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BDE0480 0x48 UnknownButton               ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GetButtonObject                           = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDE04A0 0x50 GetButtonObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ChallengeButtonObject                     = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDE04C0 0x58 ChallengeButtonObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CloseButtonObject                         = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDE04E0 0x60 CloseButtonObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDE0500 0x68 MissionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 02466BDE0520 0x70 Gauge                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ProgressText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDE0540 0x78 ProgressText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItemIcon                            = GetObjectList<RewardItemIcon>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 02466BDE0560 0x80 RewardItemIcon              ( 000185CA1078 ModelClassListType RewardItemIcon[] RewardItemIcon[] List<RewardItemIcon> Pointer )
            value.CloseLayoutObject                         = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDE0580 0x88 CloseLayoutObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStampObject                          = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDE05A0 0x90 ClearStampObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
