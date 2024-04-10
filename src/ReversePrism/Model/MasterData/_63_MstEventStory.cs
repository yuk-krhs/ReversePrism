using System;

namespace ReversePrism
{
    public partial class MstEventStory : MasterDataItem
    {
        public int                              Id;
        public int                              EpisodeNumber;
        public int                              ScenarioNumber;
        public int                              MstEventId;
        public int                              EpisodeType;
        public int                              SortId;
        public int[]?                           MstCharacterInfoIdList;
        public int                              UnlockPremiseMstEventStoryId;
        public int                              UnlockPremiseEventPoint;
        public DateTime                         ReleaseDate;
        public int                              PreviousMstEventStoryId;
    }
}
