using System;

namespace ReversePrism
{
    public partial class MstCostumeSet : MasterDataItem
    {
        public int                              Id;
        public int                              CostumeType;
        public int                              MstCostumeId;
        public int                              MstHairstyleId;
        public int[]?                           MstAccessoryIdList;
        public int                              SortId;
    }
}
