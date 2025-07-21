using System;

namespace ReversePrism
{
    public partial class MstMainStory : MasterDataItem
    {
        public int                              Id;
        public int                              EpisodeNumber;
        public int                              MstMainStoryChapterId;
        public int                              SortId;
        public int[]?                           MstCharacterInfoIdList;
        public DateTime                         ReleaseDate;
    }
}
