using System;

namespace ReversePrism
{
    public partial class MstCostume : MasterDataItem
    {
        public int                              Id;
        public int                              MstCharacterInfoId;
        public int                              CostumeType;
        public int                              ResourceId;
        public bool                             IsDressOrderTarget;
        public DateTime                         DressOrderBeginDate;
    }
}
