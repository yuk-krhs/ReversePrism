using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ListButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 GetButtonObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 050 ChallengeButtonObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 058 CloseButtonObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 060 MissionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 Gauge                                    ModelClassType Image Image Image Pointer
    // 070 ProgressText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GetExpText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 CloseLayoutObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 088 ClearStampObject                         ModelClassType GameObject GameObject GameObject Pointer
    public partial class SeasonMissionMissionListViewCell : DataModel
    {
        public ButtonBase?                              ListButton                              { get; set; }
        public GameObject?                              GetButtonObject                         { get; set; }
        public GameObject?                              ChallengeButtonObject                   { get; set; }
        public GameObject?                              CloseButtonObject                       { get; set; }
        public UITextMeshProUGUI?                       MissionText                             { get; set; }
        public Image?                                   Gauge                                   { get; set; }
        public UITextMeshProUGUI?                       ProgressText                            { get; set; }
        public UITextMeshProUGUI?                       GetExpText                              { get; set; }
        public GameObject?                              CloseLayoutObject                       { get; set; }
        public GameObject?                              ClearStampObject                        { get; set; }

        public static SeasonMissionMissionListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionMissionListViewCell() { Pointer= p0 };

            value.ListButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 ListButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GetButtonObject                           = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GetButtonObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ChallengeButtonObject                     = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 ChallengeButtonObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CloseButtonObject                         = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 CloseButtonObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 MissionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0x68 Gauge                       ( ModelClassType Image Image Image Pointer )
            value.ProgressText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 ProgressText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GetExpText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 GetExpText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CloseLayoutObject                         = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 CloseLayoutObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStampObject                          = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 ClearStampObject            ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
