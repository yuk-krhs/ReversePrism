using System;

namespace ReversePrism
{
    public partial class MstProduceMainIdolScenario : MasterDataItem
    {
        public int                              Id;
        public int                              MstEpisodeId;
        public int                              MstCharacterInfoId;
        public int                              ScenarioId;
        public int                              EpisodeNumber;
        public string[]?                        MstCharacterInfoIdList;
        public string[]?                        UnlockPremiseMstStoryIdList;
        public DateTime                         ReleaseDate;
        public int                              SortId;
    }
}
