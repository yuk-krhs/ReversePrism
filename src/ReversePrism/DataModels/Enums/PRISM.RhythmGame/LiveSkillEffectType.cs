using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LiveSkillEffectType
    {
        None,
        ScoreUp,
        ComboBonus,
        EvaluationUp,
        PerfectEvaluationUp,
        Recovery,
        Invincible,
        FlickScoreUp,
        LongScoreUp,
        PerfectScoreUp,
    }
}
