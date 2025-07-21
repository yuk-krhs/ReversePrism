using System;

namespace ReversePrism
{
    public partial class MstProduceIdolLevelReward : MasterDataItem
    {
        public int                              Id;
        public int                              Level;
        public int                              MstProduceIdolId;
        public string[]?                        RewardList;
    }
}
