using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NormalPinObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 028 BossPinObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 030 StageTitleText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 StageNumberText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ClearIcon                                ModelClassType GameObject GameObject GameObject Pointer
    // 048 StarObjects                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 ItemIcon                                 ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer
    // 058 EnemyInfoText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 MissionInfoButton                        ModelClassType UIButton UIButton UIButton Pointer
    public partial class ChallengeTourStageDetailInfoPanelView : DataModel
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

        public static ChallengeTourStageDetailInfoPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageDetailInfoPanelView() { Pointer= p0 };

            value.NormalPinObject                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 NormalPinObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BossPinObject                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 BossPinObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.StageTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 StageTitleText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StageNumberText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 StageNumberText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearIcon                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ClearIcon                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.StarObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 StarObjects                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ItemIcon                                  = GetObject<ChallengeTourRewardIcon>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChallengeTourRewardIcon.FromPointer); // 0x50 ItemIcon                    ( ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer )
            value.EnemyInfoText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 EnemyInfoText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionInfoButton                         = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 MissionInfoButton           ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
