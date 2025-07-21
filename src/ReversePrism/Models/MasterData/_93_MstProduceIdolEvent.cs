using System;

namespace ReversePrism
{
    public partial class MstProduceIdolEvent : MasterDataItem
    {
        public int                              Id;
        public int                              ProductType;
        public string?                          MstAdvInfoId;
        public int                              MstProduceIdolId;
        public int[]?                           MstCharacterInfoIdList;
        public int                              ScenarioId;
        public int                              MstProduceScenarioRewardGroupId;
        public DateTime                         ReleaseDate;
        public int                              SortId;
    }
}
