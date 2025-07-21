using System;

namespace ReversePrism
{
    public partial class MstExtraStory : MasterDataItem
    {
        public int                              Id;
        public int                              EpisodeNumber;
        public int                              MstExtraStorySubCategoryId;
        public int                              SortId;
        public string?                          ScenarioId;
        public int[]?                           MstCharacterInfoIdList;
        public DateTime                         ReleaseDate;
        public DateTime                         UnlockDate;
        public bool                             HasUnlockDate;
    }
}
