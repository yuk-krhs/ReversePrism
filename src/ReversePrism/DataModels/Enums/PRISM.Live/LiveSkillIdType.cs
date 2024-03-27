using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LiveSkillIdType
    {
        None,
        ScoreUp,
        ComboBonus,
        EvaluationUpAndScoreUp,
        EvaluationUpAndComboBonus,
        PerfectEvaluationUp,
        RecoveryAndScoreUp,
        RecoveryAndEvaluationUp,
        InvulnerableAndScoreUp,
        FlickScoreUp,
        LongScoreUp,
        PerfectScoreUp,
        DearnessUp,
        IdolBaseExpUp,
        MoneyDropUp,
        BonusReward,
        FanUp,
    }
}
