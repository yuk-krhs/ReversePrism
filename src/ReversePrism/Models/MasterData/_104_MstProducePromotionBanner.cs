using System;

namespace ReversePrism
{
    public partial class MstProducePromotionBanner : MasterDataItem
    {
        public int                              Id;
        public string?                          ProducePromotionUrl;
        public int                              SortId;
        public string?                          BannerPath;
        public DateTime                         BeginDate;
        public DateTime                         EndDate;
    }
}
