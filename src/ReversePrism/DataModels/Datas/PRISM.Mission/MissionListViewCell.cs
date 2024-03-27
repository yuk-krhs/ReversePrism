using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 MissionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ProgressText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 EndAtText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TermRootObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 NewBadgeObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 NewBadgeShadowObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 ProgressImage                            0001866CCDB0 ModelClassType Image Image Image Pointer
    // 078 CloseLayoutObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 RewardItemIcons                          000185B93DD0 ModelClassListType MissionRewardIcon[] MissionRewardIcon[] List<MissionRewardIcon> Pointer
    // 088 ReceivableButtonObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 CloseButtonObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 ChallengeButtonObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 ClearStampImageObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 ClickButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0B0 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 0B8 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 0C0 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class MissionListViewCell
    {
        public UITextMeshProUGUI?                       MissionText                             { get; set; }
        public UITextMeshProUGUI?                       ProgressText                            { get; set; }
        public UITextMeshProUGUI?                       EndAtText                               { get; set; }
        public GameObject?                              TermRootObject                          { get; set; }
        public GameObject?                              NewBadgeObject                          { get; set; }
        public GameObject?                              NewBadgeShadowObject                    { get; set; }
        public Image?                                   ProgressImage                           { get; set; }
        public GameObject?                              CloseLayoutObject                       { get; set; }
        public List<MissionRewardIcon>?                 RewardItemIcons                         { get; set; }
        public GameObject?                              ReceivableButtonObject                  { get; set; }
        public GameObject?                              CloseButtonObject                       { get; set; }
        public GameObject?                              ChallengeButtonObject                   { get; set; }
        public GameObject?                              ClearStampImageObject                   { get; set; }
        public UIButton?                                ClickButton                             { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static MissionListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListViewCell();

            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5558178 0x40 MissionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProgressText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5558198 0x48 ProgressText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EndAtText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D55581B8 0x50 EndAtText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TermRootObject                            = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D55581D8 0x58 TermRootObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NewBadgeObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D55581F8 0x60 NewBadgeObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NewBadgeShadowObject                      = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5558218 0x68 NewBadgeShadowObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProgressImage                             = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0270D5558238 0x70 ProgressImage               ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.CloseLayoutObject                         = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5558258 0x78 CloseLayoutObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RewardItemIcons                           = GetObjectList<MissionRewardIcon>(new IntPtr(p + 0x080), ReversePrism.DataModels.MissionRewardIcon.FromPointer); // 0270D5558278 0x80 RewardItemIcons             ( 000185B93DD0 ModelClassListType MissionRewardIcon[] MissionRewardIcon[] List<MissionRewardIcon> Pointer )
            value.ReceivableButtonObject                    = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5558298 0x88 ReceivableButtonObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CloseButtonObject                         = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270D55582B8 0x90 CloseButtonObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ChallengeButtonObject                     = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270D55582D8 0x98 ChallengeButtonObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStampImageObject                     = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D55582F8 0xA0 ClearStampImageObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ClickButton                               = GetObject<UIButton>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5558318 0xA8 ClickButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D5558338 0xB0 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270D5558358 0xB8 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5558378 0xC0 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
