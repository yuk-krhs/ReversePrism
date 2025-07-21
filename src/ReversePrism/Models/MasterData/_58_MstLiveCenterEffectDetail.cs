using System;

namespace ReversePrism
{
    public partial class MstLiveCenterEffectDetail : MasterDataItem
    {
        public int                              Id;
        public int                              EffectType;
        public int                              EffectValue;
        public int                              ConditionType;
        public int[]?                           ConditionIdList;
    }
}
