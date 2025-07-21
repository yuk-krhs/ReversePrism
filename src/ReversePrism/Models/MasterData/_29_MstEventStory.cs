using System;

namespace ReversePrism
{
    public partial class MstEventStory : MasterDataItem
    {
        public int                              Id;
        public int                              EpisodeNumber;
        public int                              ScenarioNumber;
        public int                              MstUnitId;
        public int                              MstEventId;
        public int                              SortId;
        public int[]?                           MstCharacterInfoIdList;
        public int                              UnlockPremiseEventPoint;
        public DateTime                         ReleaseDate;
    }
}
