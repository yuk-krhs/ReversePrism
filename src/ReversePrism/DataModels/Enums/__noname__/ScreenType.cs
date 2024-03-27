using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ScreenType
    {
        MobileTop,
        TwestaTop,
        TwestaFavorite,
        TwestaProfile,
        TwestaDetail,
        ChainTop,
        ChainTalk,
        ChainTalkHistory,
        ChainProfile,
        ChainGroupMember,
        CallTop,
        CallHistory,
        CallPlayback,
        OurStreamTop,
        OurStreamArchiveDetail,
        OurStreamFavoriteList,
        OurStreamLiveViewing,
        OurStreamArchive,
        OurStreamArchivePMode,
        None,
    }
}
