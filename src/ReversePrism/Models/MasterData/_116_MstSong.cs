using System;

namespace ReversePrism
{
    public partial class MstSong : MasterDataItem
    {
        public int                              Id;
        public int                              MstSongTypeId;
        public int                              MstUnitId;
        public int                              SortId;
        public int                              Attribute;
        public bool                             IsAdvanceDownload;
        public bool                             IsSongParts;
        public string[]?                        LimitedSongPartsUnlockProductList;
        public bool                             IsFocusCamera;
        public bool                             Is3D;
        public bool                             Is2D;
        public bool                             IsHDR;
        public bool                             IsLDR;
        public bool                             IsMvOnly;
        public int                              ResultBg;
        public string?                          PurchaseLink;
        public DateTime                         PurchaseLinkActiveDate;
        public DateTime                         EndDate;
        public DateTime                         PublicDate;
        public int                              StageAudioType;
    }
}
