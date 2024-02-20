using System;

namespace ReversePrism
{
    public partial class MstSong : MasterDataItem
    {
        public int                              Id;
        public int                              MstSongTypeId;
        public int                              MstUnitId;
        public int                              MstSongPositionId;
        public int                              SortId;
        public int                              Bpm;
        public bool                             IsAdvanceDownload;
        public bool                             IsSongParts;
        public bool                             IsFocusCamera;
        public bool                             Is3D;
        public bool                             Is2D;
        public string?                          PurchaseLink;
        public DateTime                         PurchaseLinkActiveDate;
        public DateTime                         BeginDate;
    }
}
