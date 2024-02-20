using System;

namespace ReversePrism
{
    public partial class MstOutgameVoiceMotion : MasterDataItem
    {
        public int                              Id;
        public int                              MstCharacterInfoId;
        public int                              ScreenType;
        public int                              MstProduceIdolId;
        public int                              MstSupportCharacterId;
        public bool                             ReachedGrowthLimit;
        public int                              MstVoiceResourceId;
        public DateTime                         ReleaseDate;
    }
}
