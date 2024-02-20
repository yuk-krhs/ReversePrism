using System;

namespace ReversePrism
{
    public partial class MstHairstyle : MasterDataItem
    {
        public int                              Id;
        public int                              MstCharacterInfoId;
        public int                              CostumeType;
        public int                              HairResourceIdForClient;
        public int[]?                           HairAccessoryResourceIdListForClient;
        public int                              SortId;
    }
}
