using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NormalPinObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 BossPinObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 StageTitleText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 StageNumberText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ClearIcon                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 StarObjects                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 ItemIcon                                 00018657D9E0 ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer
    // 058 EnemyInfoText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 MissionInfoButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 PIdolDetail                              000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 070 SCharaDetail                             0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class ChallengeTourStageDetailInfoPanelView
    {
        public GameObject?                              NormalPinObject                         { get; set; }
        public GameObject?                              BossPinObject                           { get; set; }
        public UITextMeshProUGUI?                       StageTitleText                          { get; set; }
        public UITextMeshProUGUI?                       StageNumberText                         { get; set; }
        public GameObject?                              ClearIcon                               { get; set; }
        public List<GameObject>?                        StarObjects                             { get; set; }
        public ChallengeTourRewardIcon?                 ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       EnemyInfoText                           { get; set; }
        public UIButton?                                MissionInfoButton                       { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetail                             { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetail                            { get; set; }

        public static ChallengeTourStageDetailInfoPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageDetailInfoPanelView();

            value.NormalPinObject                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1B5888 0x20 NormalPinObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BossPinObject                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1B58A8 0x28 BossPinObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StageTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1B58C8 0x30 StageTitleText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StageNumberText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1B58E8 0x38 StageNumberText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearIcon                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1B5908 0x40 ClearIcon                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StarObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1B5928 0x48 StarObjects                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ItemIcon                                  = GetObject<ChallengeTourRewardIcon>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChallengeTourRewardIcon.FromPointer); // 0270DA1B5948 0x50 ItemIcon                    ( 00018657D9E0 ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer )
            value.EnemyInfoText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1B5968 0x58 EnemyInfoText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionInfoButton                         = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1B5988 0x60 MissionInfoButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PIdolDetail                               = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DA1B59A8 0x68 PIdolDetail                 ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetail                              = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x070), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270DA1B59C8 0x70 SCharaDetail                ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
