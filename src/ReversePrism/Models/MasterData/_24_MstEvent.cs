using System;

namespace ReversePrism
{
    public partial class MstEvent : MasterDataItem
    {
        public int                              Id;
        public int                              EventType;
        public bool                             HasStory;
        public int                              MstUnitId;
        public DateTime                         BeginDate;
        public DateTime                         EndDate;
        public DateTime                         DisplayEndDate;
        public bool                             IsProduce;
        public bool                             IsLive;
        public int                              CharacterImageCount;
    }
}
