using System;

namespace ReversePrism
{
    public partial class MstSupportCharacterLevelReward : MasterDataItem
    {
        public int                              Id;
        public int                              Level;
        public int                              MstSupportCharacterId;
        public string[]?                        RewardList;
    }
}
