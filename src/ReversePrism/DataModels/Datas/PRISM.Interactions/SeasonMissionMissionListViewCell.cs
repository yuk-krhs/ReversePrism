using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ListButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 GetButtonObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ChallengeButtonObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 CloseButtonObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 MissionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 Gauge                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 070 ProgressText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 GetExpText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 CloseLayoutObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 ClearStampObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
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

            value.ListButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BDA8040 0x40 ListButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GetButtonObject                           = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDA8060 0x48 GetButtonObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ChallengeButtonObject                     = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDA8080 0x50 ChallengeButtonObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CloseButtonObject                         = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDA80A0 0x58 CloseButtonObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDA80C0 0x60 MissionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Gauge                                     = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 02466BDA80E0 0x68 Gauge                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ProgressText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDA8100 0x70 ProgressText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GetExpText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDA8120 0x78 GetExpText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CloseLayoutObject                         = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDA8140 0x80 CloseLayoutObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStampObject                          = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDA8160 0x88 ClearStampObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
