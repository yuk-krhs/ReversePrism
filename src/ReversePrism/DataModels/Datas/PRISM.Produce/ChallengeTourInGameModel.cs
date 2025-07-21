using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 158 EnemySkillExecuteTime                    ModelPrimitiveListType float[] float[] List<float> Pointer
    // 160 Opponent                                 ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer
    // 168 InGameTallyModel                         ModelClassType ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel Pointer
    // 170 ChallengeTourMissionProgressCalcModel    ModelClassType ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel Pointer
    public partial class ChallengeTourInGameModel : DataModel
    {
        public List<float>?                             EnemySkillExecuteTime                   { get; set; }
        public IChallengeTourOpponentStatus?            Opponent                                { get; set; }
        public ChallengeTourInGameTallyModel?           InGameTallyModel                        { get; set; }
        public ChallengeTourMissionProgressCalcModel?   ChallengeTourMissionProgressCalcModel   { get; set; }

        public static ChallengeTourInGameModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameModel() { Pointer= p0 };

            value.EnemySkillExecuteTime                     = GetSingleList(new IntPtr(p + 0x158)); // 0x158 EnemySkillExecuteTime       ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Opponent                                  = GetObject<IChallengeTourOpponentStatus>(new IntPtr(p + 0x160), ReversePrism.DataModels.IChallengeTourOpponentStatus.FromPointer); // 0x160 Opponent                    ( ModelClassType IChallengeTourOpponentStatus IChallengeTourOpponentStatus IChallengeTourOpponentStatus Pointer )
            value.InGameTallyModel                          = GetObject<ChallengeTourInGameTallyModel>(new IntPtr(p + 0x168), ReversePrism.DataModels.ChallengeTourInGameTallyModel.FromPointer); // 0x168 InGameTallyModel            ( ModelClassType ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel ChallengeTourInGameTallyModel Pointer )
            value.ChallengeTourMissionProgressCalcModel     = GetObject<ChallengeTourMissionProgressCalcModel>(new IntPtr(p + 0x170), ReversePrism.DataModels.ChallengeTourMissionProgressCalcModel.FromPointer); // 0x170 ChallengeTourMissionProgressCalcModel ( ModelClassType ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel ChallengeTourMissionProgressCalcModel Pointer )

            return value;
        }
    }
}
