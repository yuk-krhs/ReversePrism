using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ProduceNextOrderType
    {
        None,
        ProduceStrategyList,
        Top,
        SelectSchedule,
        StartScheduleRest,
        FinishScheduleRest,
        StartScheduleTraining,
        FinishScheduleTraining,
        StartScheduleWorking,
        FinishScheduleWorking,
        StartScheduleOuting,
        FinishScheduleOuting,
        StartScheduleShopping,
        FinishScheduleShopping,
        StartScheduleAdvice,
        FinishScheduleAdvice,
        StartScheduleLesson,
        FinishScheduleLesson,
        StartScheduleSpecialLesson,
        FinishScheduleSpecialLesson,
        CardRankUp,
        StartScheduleAudition,
        FinishScheduleAudition,
        StartSupportCooperationEvent,
        FinishSupportCooperationEvent,
        SelectProduceStrategy,
        FinishProduce,
        FinishScheduleLessonResult,
        FinishScheduleAuditionResult,
        StartAdv,
        SelectAdvOption,
        FinishAdv,
        ProduceResult,
        ProduceMv,
        SelectProduceStrategyReward,
        SubSeasonList,
        SelectSubSeason,
        SelectSubSeasonIdol,
        ProduceFailureResult,
        InheritanceSkillList,
        SelectInheritanceSkill,
        DetermineProduceResult,
        StartScheduleMiniLive,
        FinishScheduleMiniLive,
        StartScheduleTalkShow,
        FinishScheduleTalkShow,
        Num,
    }
}
