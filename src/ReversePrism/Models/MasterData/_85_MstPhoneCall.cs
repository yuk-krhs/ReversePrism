using System;

namespace ReversePrism
{
    public partial class MstPhoneCall : MasterDataItem
    {
        public int                              Id;
        public int                              MstPhoneUserId;
        public int                              TypeId;
        public int                              ScenarioId;
        public int                              ScenarioNumber;
        public bool                             IsAnswerphone;
    }
}
