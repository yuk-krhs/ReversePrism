using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetLiveEventAllSongTopPageArgs Marshaller`1<GetLiveEventAllSongTopPageArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetLiveEventAllSongTopPageReply Marshaller`1<GetLiveEventAllSongTopPageReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetLiveEventAllSongRewardListArgs Marshaller`1<GetLiveEventAllSongRewardListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetLiveEventAllSongRewardListReply Marshaller`1<GetLiveEventAllSongRewardListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetLiveEventAllSongBreakTimeArgs Marshaller`1<GetLiveEventAllSongBreakTimeArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetLiveEventAllSongBreakTimeReply Marshaller`1<GetLiveEventAllSongBreakTimeReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_SetLiveEventAllSongBreakTimeArgs Marshaller`1<SetLiveEventAllSongBreakTimeArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_SetLiveEventAllSongBreakTimeReply Marshaller`1<SetLiveEventAllSongBreakTimeReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_AccessLiveEventAllSongAlbumArgs Marshaller`1<AccessLiveEventAllSongAlbumArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_AccessLiveEventAllSongAlbumReply Marshaller`1<AccessLiveEventAllSongAlbumReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetLiveEventAllSongTopPage      Method`2<GetLiveEventAllSongTopPageArgs, GetLiveEventAllSongTopPageReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_GetLiveEventAllSongRewardList   Method`2<GetLiveEventAllSongRewardListArgs, GetLiveEventAllSongRewardListReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_GetLiveEventAllSongBreakTime    Method`2<GetLiveEventAllSongBreakTimeArgs, GetLiveEventAllSongBreakTimeReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_SetLiveEventAllSongBreakTime    Method`2<SetLiveEventAllSongBreakTimeArgs, SetLiveEventAllSongBreakTimeReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_AccessLiveEventAllSongAlbum     Method`2<AccessLiveEventAllSongAlbumArgs, AccessLiveEventAllSongAlbumReply> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventAllSongService : DataModel
    {

        public static LiveEventAllSongService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongService() { Pointer= p0 };


            return value;
        }
    }
}
