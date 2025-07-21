using System;

namespace ReversePrism
{
    public partial class MstLiveSkillLevel : MasterDataItem
    {
        public int                              Id;
        public int                              MstLiveSkillId;
        public int                              Level;
        public int[]?                           MstLiveSkillDetailIdList;
    }
}
