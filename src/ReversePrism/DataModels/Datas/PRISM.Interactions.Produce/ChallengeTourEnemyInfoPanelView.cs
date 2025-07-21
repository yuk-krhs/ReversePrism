using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EnemySilhouettePanelViews                ModelClassListType ChallengeTourEnemySilhouettePanelView[] ChallengeTourEnemySilhouettePanelView[] List<ChallengeTourEnemySilhouettePanelView> Pointer
    // 028 EnemySkillIcons                          ModelClassListType ChallengeTourEnemySkillIcon[] ChallengeTourEnemySkillIcon[] List<ChallengeTourEnemySkillIcon> Pointer
    // 030 TotalStatusText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 EnemyInfoButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ChallengeTourEnemyInfoPanelView : DataModel
    {
        public List<ChallengeTourEnemySilhouettePanelView>? EnemySilhouettePanelViews               { get; set; }
        public List<ChallengeTourEnemySkillIcon>?       EnemySkillIcons                         { get; set; }
        public UITextMeshProUGUI?                       TotalStatusText                         { get; set; }
        public UIButton?                                EnemyInfoButton                         { get; set; }

        public static ChallengeTourEnemyInfoPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourEnemyInfoPanelView() { Pointer= p0 };

            value.EnemySilhouettePanelViews                 = GetObjectList<ChallengeTourEnemySilhouettePanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourEnemySilhouettePanelView.FromPointer); // 0x20 EnemySilhouettePanelViews   ( ModelClassListType ChallengeTourEnemySilhouettePanelView[] ChallengeTourEnemySilhouettePanelView[] List<ChallengeTourEnemySilhouettePanelView> Pointer )
            value.EnemySkillIcons                           = GetObjectList<ChallengeTourEnemySkillIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourEnemySkillIcon.FromPointer); // 0x28 EnemySkillIcons             ( ModelClassListType ChallengeTourEnemySkillIcon[] ChallengeTourEnemySkillIcon[] List<ChallengeTourEnemySkillIcon> Pointer )
            value.TotalStatusText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TotalStatusText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EnemyInfoButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 EnemyInfoButton             ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
