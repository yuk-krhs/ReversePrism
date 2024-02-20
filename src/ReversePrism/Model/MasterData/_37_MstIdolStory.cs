using System;

namespace ReversePrism
{
    public partial class MstIdolStory : MasterDataItem
    {
        public int                              Id;
        public int                              MstIdolId;
        public int                              SortId;
        public int[]?                           MstCharacterInfoIdList;
        public int                              UnlockPremiseMstIdolStoryId;
        public int                              UnlockPremiseIdolBaseDearness;
        public string[]?                        RewardProductList;
        public DateTime                         ReleaseDate;
        public int                              PreviousMstIdolStoryId;
    }
}
