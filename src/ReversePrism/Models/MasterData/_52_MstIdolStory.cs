using System;

namespace ReversePrism
{
    public partial class MstIdolStory : MasterDataItem
    {
        public int                              Id;
        public int                              EpisodeNumber;
        public int                              MstIdolId;
        public int                              SortId;
        public int[]?                           MstCharacterInfoIdList;
        public int                              UnlockPremiseIdolBaseDearness;
        public DateTime                         ReleaseDate;
    }
}
