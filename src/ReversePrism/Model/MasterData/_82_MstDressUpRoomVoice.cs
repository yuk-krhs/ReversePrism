using System;

namespace ReversePrism
{
    public partial class MstDressUpRoomVoice : MasterDataItem
    {
        public int                              Id;
        public int                              MstCharacterInfoId;
        public int                              VoiceType;
        public int                              MstVoiceResourceId;
        public DateTime                         ReleaseDate;
    }
}
