using System;

namespace ReversePrism
{
    public partial class MstHelp : MasterDataItem
    {
        public int                              Id;
        public int                              SortId;
        public int                              MstHelpGroupId;
        public bool                             IsMobile;
        public bool                             IsGpg;
        public bool                             IsDmm;
        public DateTime                         BeginDate;
        public DateTime                         EndDate;
    }
}
