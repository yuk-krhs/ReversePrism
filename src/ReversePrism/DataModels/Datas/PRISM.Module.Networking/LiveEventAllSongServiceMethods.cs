using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetLiveEventAllSongTopPage               Method`2<IGetLiveEventAllSongTopPageArgs, IGetLiveEventAllSongTopPageReply> IL2CPP_TYPE_GENERICINST
    // 018 GetLiveEventAllSongRewardList            Method`2<IGetLiveEventAllSongRewardListArgs, IGetLiveEventAllSongRewardListReply> IL2CPP_TYPE_GENERICINST
    // 030 GetLiveEventAllSongBreakTime             Method`2<IGetLiveEventAllSongBreakTimeArgs, IGetLiveEventAllSongBreakTimeReply> IL2CPP_TYPE_GENERICINST
    // 048 SetLiveEventAllSongBreakTime             Method`2<ISetLiveEventAllSongBreakTimeArgs, ISetLiveEventAllSongBreakTimeReply> IL2CPP_TYPE_GENERICINST
    // 060 AccessLiveEventAllSongAlbum              Method`2<IAccessLiveEventAllSongAlbumArgs, IAccessLiveEventAllSongAlbumReply> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventAllSongServiceMethods : DataModel
    {

        public static LiveEventAllSongServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
