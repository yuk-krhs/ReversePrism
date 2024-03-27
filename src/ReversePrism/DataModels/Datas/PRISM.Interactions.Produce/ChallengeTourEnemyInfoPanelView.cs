using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EnemySilhouettePanelViews                000185B73D10 ModelClassListType ChallengeTourEnemySilhouettePanelView[] ChallengeTourEnemySilhouettePanelView[] List<ChallengeTourEnemySilhouettePanelView> Pointer
    // 028 EnemySkillIcons                          000185B73E40 ModelClassListType ChallengeTourEnemySkillIcon[] ChallengeTourEnemySkillIcon[] List<ChallengeTourEnemySkillIcon> Pointer
    // 030 TotalStatusText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 EnemyInfoButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ChallengeTourEnemyInfoPanelView
    {
        public List<ChallengeTourEnemySilhouettePanelView>? EnemySilhouettePanelViews               { get; set; }
        public List<ChallengeTourEnemySkillIcon>?       EnemySkillIcons                         { get; set; }
        public UITextMeshProUGUI?                       TotalStatusText                         { get; set; }
        public UIButton?                                EnemyInfoButton                         { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ChallengeTourEnemyInfoPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourEnemyInfoPanelView();

            value.EnemySilhouettePanelViews                 = GetObjectList<ChallengeTourEnemySilhouettePanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourEnemySilhouettePanelView.FromPointer); // 0270DA1B5A10 0x20 EnemySilhouettePanelViews   ( 000185B73D10 ModelClassListType ChallengeTourEnemySilhouettePanelView[] ChallengeTourEnemySilhouettePanelView[] List<ChallengeTourEnemySilhouettePanelView> Pointer )
            value.EnemySkillIcons                           = GetObjectList<ChallengeTourEnemySkillIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourEnemySkillIcon.FromPointer); // 0270DA1B5A30 0x28 EnemySkillIcons             ( 000185B73E40 ModelClassListType ChallengeTourEnemySkillIcon[] ChallengeTourEnemySkillIcon[] List<ChallengeTourEnemySkillIcon> Pointer )
            value.TotalStatusText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1B5A50 0x30 TotalStatusText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EnemyInfoButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1B5A70 0x38 EnemyInfoButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DA1B5AB0 0x48 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
