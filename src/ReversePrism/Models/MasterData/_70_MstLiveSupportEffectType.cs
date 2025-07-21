using System;

namespace ReversePrism
{
    public partial class MstLiveSupportEffectType : MasterDataItem
    {
        public int                              Id;
        public bool                             IsTime;
        public bool                             IsAll;
        public LiveSkillEffectDisplayType       DisplayType;
        public int[]?                           TargetList;
    }
}
