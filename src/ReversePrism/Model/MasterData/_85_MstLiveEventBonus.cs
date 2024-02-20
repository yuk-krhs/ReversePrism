using System;

namespace ReversePrism
{
    public partial class MstLiveEventBonus : MasterDataItem
    {
        public int                              Id;
        public int                              MstEventId;
        public int                              MstProduceIdolId;
        public int                              BaseEffect;
        public int[]?                           EffectByStarList;
        public int[]?                           EffectByLevelList;
    }
}
