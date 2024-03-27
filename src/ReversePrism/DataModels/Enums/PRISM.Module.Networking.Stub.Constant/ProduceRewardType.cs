using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ProduceRewardType
    {
        None,
        Parameter,
        CommonCard,
        VocalCommonCard,
        DanceCommonCard,
        VisualCommonCard,
        OtherCommonCard,
        UnitCard,
        CardRank,
        RemoveCard,
        RecoverVitality,
        Secret,
        Fan,
        Num,
    }
}
