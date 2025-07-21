using System;

namespace ReversePrism
{
    public partial class MstLiveSupportEffectDetail : MasterDataItem
    {
        public int                              Id;
        public int                              EffectTypeId;
        public int                              ConditionType;
        public int[]?                           ConditionIdList;
        public int[]?                           EffectValueList;
    }
}
