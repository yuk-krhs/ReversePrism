using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MissionType
    {
        Clear,
        TimeClear,
        MeHigherClear,
        MeLowerClear,
        EnemyMentalBreakCount,
        NonMentalBreak,
        UseIdolSkillCountHigher,
        UseIdolSkillCountLower,
        VoAppealPoint,
        DaAppealPoint,
        ViAppealPoint,
        DeckCount,
        MeGuardHigher,
        AvoidRate,
        AvoidCount,
        HandCount,
        PhaseChangeCount,
        UseCostOneCardCount,
        UseCostDownCardCount,
        RemoveCardCount,
        VoReleaseCounterCount,
        DaReleaseCounterCount,
        ViReleaseCounterCount,
        MeDamageCount,
        MeRecoveryCount,
    }
}
