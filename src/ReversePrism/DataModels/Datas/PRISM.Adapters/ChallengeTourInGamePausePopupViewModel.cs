using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnemySkillViewModels                     ModelClassListType IReadOnlyList`1<EnemySkillContentViewModel> IReadOnlyList`1<EnemySkillContentViewModel> List<EnemySkillContentViewModel> Pointer
    // 018 MissionViewModels                        ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer
    // 020 CalcModel                                ModelClassType ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel Pointer
    public partial class ChallengeTourInGamePausePopupViewModel : DataModel
    {
        public List<EnemySkillContentViewModel>?        EnemySkillViewModels                    { get; set; }
        public List<ChallengeTourRewardViewModel>?      MissionViewModels                       { get; set; }
        public ChallengeTourMissionProgressCalcModel?   CalcModel                               { get; set; }

        public static ChallengeTourInGamePausePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGamePausePopupViewModel() { Pointer= p0 };

            value.EnemySkillViewModels                      = GetObjectList<EnemySkillContentViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.EnemySkillContentViewModel.FromPointer); // 0x10 EnemySkillViewModels        ( ModelClassListType IReadOnlyList`1<EnemySkillContentViewModel> IReadOnlyList`1<EnemySkillContentViewModel> List<EnemySkillContentViewModel> Pointer )
            value.MissionViewModels                         = GetObjectList<ChallengeTourRewardViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourRewardViewModel.FromPointer); // 0x18 MissionViewModels           ( ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer )
            value.CalcModel                                 = GetObject<ChallengeTourMissionProgressCalcModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourMissionProgressCalcModel.FromPointer); // 0x20 CalcModel                   ( ModelClassType ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel Pointer )

            return value;
        }
    }
}
