using System;

namespace ReversePrism
{
    public partial class MstProduceActionEffect : MasterDataItem
    {
        public int                              Id;
        public int                              MstProduceActionEffectTypeId;
        public int[]?                           ValueList;
        public int                              MstProduceActionEffectConditionTypeId;
        public int                              ConditionValue;
        public bool                             IsHideConditionEffect;
        public int                              MstProduceActionEffectActivationTimingTypeId;
        public int                              MstSkillBufferDisplayId;
        public int                              GrantMstSkillBufferDisplayId;
        public int[]?                           MstProduceActionEffectDisplayIdList;
        public int                              IconId;
    }
}
