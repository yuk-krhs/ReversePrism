using System;

namespace ReversePrism
{
    public partial class MstLetter : MasterDataItem
    {
        public int                              Id;
        public int                              MstLetterGroupId;
        public int                              MstUnitId;
        public string?                          ResourceId;
        public DateTime                         GalleryReleaseDate;
    }
}
