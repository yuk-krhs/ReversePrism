using System;

namespace ReversePrism
{
    public partial class MstSupportCharacterEvent : MasterDataItem
    {
        public int                              Id;
        public int                              ProductType;
        public string?                          MstAdvInfoId;
        public int                              MstSupportCharacterId;
        public int[]?                           MstCharacterInfoIdList;
        public int                              ScenarioId;
        public int                              ScenarioNumber;
        public int                              MstProduceScenarioRewardGroupId;
        public DateTime                         ReleaseDate;
        public bool                             IsInvisible;
        public int                              SortId;
    }
}
