using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum IdolBaseProduceScenarioTypeId
    {
        LessonStart,
        AuditionStart,
        LessonTimeElapsed,
        RequiredAppealPointsRemainingHalf,
        MentalBreak,
        RivalTeamVictory,
        LessonAuditionVictory,
        LessonAuditionLose,
        LessonVictoryFirstHalf,
        LessonVictorySecondHalf,
        LessonVictoryChallengeMissionFirstHalf,
        LessonVictoryChallengeMissionSecondHalf,
        AuditionVictoryFirstHalf,
        AuditionVictorySecondHalf,
        LessonLoseFirstHalf,
        LessonLoseSecondHalf,
        AuditionLoseFirstHalf,
        AuditionLoseSecondHalf,
        ProduceTopFewVitality,
        ProduceTopNexwSchedule,
        MinicharaEffectNormal,
        MinicharaEffectSupportBonus,
        MinicharaEffectSupportBonusAndChara,
        MinicharaEffectTrouble,
        DayOffSkit,
        AdviceSkit,
        ProduceEndRankEFirstHalf,
        ProduceEndRankDFirstHalf,
        ProduceEndRankCFirstHalf,
        ProduceEndRankBFirstHalf,
        ProduceEndRankAFirstHalf,
        ProduceEndRankSFirstHalf,
        ProduceEndRankESecondHalf,
        ProduceEndRankDSecondHalf,
        ProduceEndRankCSecondHalf,
        ProduceEndRankBSecondHalf,
        ProduceEndRankASecondHalf,
        ProduceEndRankSSecondHalf,
    }
}
