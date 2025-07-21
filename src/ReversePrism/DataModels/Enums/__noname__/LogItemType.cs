using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LogItemType
    {
        None,
        ProducePolicy,
        MainScenario,
        MainIdleScenario,
        UnitCommunicationScenario,
        ProduceIdleScenario,
        SupportCharacterScenario,
        NormalLimitEventScenario,
        SubSeasonEventScenario,
        SubSeasonEventIdleScenario,
        RecommendScenario,
        SupportCooperationEvent,
        Lesson,
        SpecialLesson,
        Working,
        Training,
        Outing,
        Shopping,
        Rest,
        Advice,
        Audition,
        InheritanceSkill,
        VoiceScenarioRest,
        VoiceScenarioAdvice,
        AdvReward,
        MiniLive,
        TalkShow,
        ScriptReading,
        CostumeFitting,
        PublicRelations,
        ActingPractice,
    }
}
