using System;

namespace ReversePrism
{
    public partial class MstChainTalkText : MasterDataItem
    {
        public int                              Id;
        public int                              MstChainTalkId;
        public int                              MstChainUserId;
        public int                              TextType;
        public int                              StampId;
        public int                              ThumbnailId;
        public int[]?                           NextId;
        public int                              ThinkingRate;
        public int                              TypingRate;
        public bool                             HasExtraThumbnail;
    }
}
