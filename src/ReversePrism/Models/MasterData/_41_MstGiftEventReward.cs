using System;

namespace ReversePrism
{
    public partial class MstGiftEventReward : MasterDataItem
    {
        public int                              MstCharacterInfoId;
        public int                              MstGiftEventTokenId;
        public int                              RequirePoint;
        public string?                          Reward;
    }
}
