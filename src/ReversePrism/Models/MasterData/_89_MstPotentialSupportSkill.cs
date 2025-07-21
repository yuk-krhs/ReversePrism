using System;

namespace ReversePrism
{
    public partial class MstPotentialSupportSkill : MasterDataItem
    {
        public int                              Id;
        public int                              MstSupportSkillTypeId;
        public int[]?                           ValueList;
        public int                              MstSkillBufferDisplayId;
        public int                              GrantMstSkillBufferDisplayId;
        public int                              EntrustAppealType;
        public int                              EntrustScore;
    }
}
