using System;

namespace ReversePrism
{
    public partial class MstEvent : MasterDataItem
    {
        public int                              Id;
        public int                              EventType;
        public int                              MstUnitId;
        public DateTime                         BeginDate;
        public DateTime                         EndDate;
    }
}
