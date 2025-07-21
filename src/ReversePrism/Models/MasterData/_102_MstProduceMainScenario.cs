using System;

namespace ReversePrism
{
    public partial class MstProduceMainScenario : MasterDataItem
    {
        public int                              Id;
        public int                              MstEpisodeId;
        public int                              ScenarioId;
        public int                              EpisodeNumber;
        public string[]?                        UnlockPremiseMstStoryIdList;
        public int                              SortId;
    }
}
