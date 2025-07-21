using System;

namespace ReversePrism
{
    public partial class MstShinyCompetitionProduceBonusCondition : MasterDataItem
    {
        public int                              Id;
        public bool                             IsResultOnly;
        public int                              ShinyCompetitionProduceBonusType;
        public int[]?                           ValueList;
    }
}
