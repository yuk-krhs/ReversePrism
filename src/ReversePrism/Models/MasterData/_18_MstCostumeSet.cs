using System;

namespace ReversePrism
{
    public partial class MstCostumeSet : MasterDataItem
    {
        public int                              Id;
        public int                              MstCostumeId;
        public int                              MstHairstyleId;
        public int[]?                           MstAccessoryIdList;
        public int                              SortId;
        public int[]?                           MstSongIdList;
    }
}
