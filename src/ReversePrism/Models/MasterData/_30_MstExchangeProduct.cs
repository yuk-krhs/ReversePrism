using System;

namespace ReversePrism
{
    public partial class MstExchangeProduct : MasterDataItem
    {
        public int                              Id;
        public string?                          ProductIdWithAmount;
        public DateTime                         BeginDate;
        public DateTime                         EndDate;
    }
}
