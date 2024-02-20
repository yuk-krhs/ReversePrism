using System;

namespace ReversePrism
{
    public partial class MstExtraStory : MasterDataItem
    {
        public int                              Id;
        public int                              ExtraStoryType;
        public int                              MstExtraStorySubCategoryId;
        public int                              SortId;
        public string?                          ScenarioId;
        public int[]?                           MstCharacterInfoIdList;
        public int                              UnlockPremiseMstExtraStoryId;
        public DateTime                         ReleaseDate;
        public int                              PreviousMstExtraStoryId;
    }
}
