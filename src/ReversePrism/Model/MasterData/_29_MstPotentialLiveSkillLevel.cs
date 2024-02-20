using System;

namespace ReversePrism
{
    public partial class MstPotentialLiveSkillLevel : MasterDataItem
    {
        public int                              Id;
        public int                              MstPotentialLiveSkillId;
        public int                              Level;
        public int[]?                           MstLiveSkillEffectIdList;
    }
}
