using System;

namespace ReversePrism
{
    public partial class MstEpisode : MasterDataItem
    {
        public int                              Id;
        public int                              MstUnitId;
        public int                              Chapter;
        public int[]?                           MstProduceIdolIdList;
    }
}
