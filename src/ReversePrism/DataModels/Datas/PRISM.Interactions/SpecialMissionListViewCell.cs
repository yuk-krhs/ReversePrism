using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ListButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 UnknownButton                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 GetButtonObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 058 ChallengeButtonObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 060 CloseButtonObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 068 MissionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 Gauge                                    ModelClassType Image Image Image Pointer
    // 078 ProgressText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 RewardItemIcon                           ModelClassListType RewardItemIcon[] RewardItemIcon[] List<RewardItemIcon> Pointer
    // 088 CloseLayoutObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 090 ClearStampObject                         ModelClassType GameObject GameObject GameObject Pointer
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

            value.ListButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 ListButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnknownButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 UnknownButton               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GetButtonObject                           = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GetButtonObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChallengeButtonObject                     = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ChallengeButtonObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CloseButtonObject                         = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 CloseButtonObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 MissionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0x70 Gauge                       ( ModelClassType Image Image Image Pointer )
            value.ProgressText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 ProgressText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItemIcon                            = GetObjectList<RewardItemIcon>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x80 RewardItemIcon              ( ModelClassListType RewardItemIcon[] RewardItemIcon[] List<RewardItemIcon> Pointer )
            value.CloseLayoutObject                         = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 CloseLayoutObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStampObject                          = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 ClearStampObject            ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
