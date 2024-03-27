using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetSelfProfileArgs      Marshaller`1<GetSelfProfileArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetSelfProfileReply     Marshaller`1<GetSelfProfileReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetUserProfileArgs      Marshaller`1<GetUserProfileArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetUserProfileReply     Marshaller`1<GetUserProfileReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_SetSelfProfileArgs      Marshaller`1<SetSelfProfileArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_SetSelfProfileReply     Marshaller`1<SetSelfProfileReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetProducerInfoArgs     Marshaller`1<GetProducerInfoArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetProducerInfoReply    Marshaller`1<GetProducerInfoReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetUserProgressInfoArgs Marshaller`1<GetUserProgressInfoArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetUserProgressInfoReply Marshaller`1<GetUserProgressInfoReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetProducerSeasonInfoListArgs Marshaller`1<GetProducerSeasonInfoListArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetProducerSeasonInfoListReply Marshaller`1<GetProducerSeasonInfoListReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_GetProducerEventInfoListArgs Marshaller`1<GetProducerEventInfoListArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_GetProducerEventInfoListReply Marshaller`1<GetProducerEventInfoListReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_GetProducerEventInfoArgs Marshaller`1<GetProducerEventInfoArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_GetProducerEventInfoReply Marshaller`1<GetProducerEventInfoReply> IL2CPP_TYPE_GENERICINST
    // 088 __Marshaller_api_SetSelfProfileNameArgs  Marshaller`1<SetSelfProfileNameArgs> IL2CPP_TYPE_GENERICINST
    // 090 __Marshaller_api_SetSelfProfileNameReply Marshaller`1<SetSelfProfileNameReply> IL2CPP_TYPE_GENERICINST
    // 098 __Method_GetSelfProfile                  Method`2<GetSelfProfileArgs, GetSelfProfileReply> IL2CPP_TYPE_GENERICINST
    // 0A0 __Method_GetUserProfile                  Method`2<GetUserProfileArgs, GetUserProfileReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Method_SetSelfProfile                  Method`2<SetSelfProfileArgs, SetSelfProfileReply> IL2CPP_TYPE_GENERICINST
    // 0B0 __Method_GetProducerInfo                 Method`2<GetProducerInfoArgs, GetProducerInfoReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Method_GetUserProgressInfo             Method`2<GetUserProgressInfoArgs, GetUserProgressInfoReply> IL2CPP_TYPE_GENERICINST
    // 0C0 __Method_GetProducerSeasonInfoList       Method`2<GetProducerSeasonInfoListArgs, GetProducerSeasonInfoListReply> IL2CPP_TYPE_GENERICINST
    // 0C8 __Method_GetProducerEventInfoList        Method`2<GetProducerEventInfoListArgs, GetProducerEventInfoListReply> IL2CPP_TYPE_GENERICINST
    // 0D0 __Method_GetProducerEventInfo            Method`2<GetProducerEventInfoArgs, GetProducerEventInfoReply> IL2CPP_TYPE_GENERICINST
    // 0D8 __Method_SetSelfProfileName              Method`2<SetSelfProfileNameArgs, SetSelfProfileNameReply> IL2CPP_TYPE_GENERICINST
    public partial class ProfileService
    {

        public static ProfileService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileService();


            return value;
        }
    }
}
