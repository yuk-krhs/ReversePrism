using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetSeasonMissionArgs    Marshaller`1<GetSeasonMissionArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetSeasonMissionReply   Marshaller`1<GetSeasonMissionReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_UpdateLastDisplayDateArgs Marshaller`1<UpdateLastDisplayDateArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_UpdateLastDisplayDateReply Marshaller`1<UpdateLastDisplayDateReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ReceiveSeasonMissionRewardArgs Marshaller`1<ReceiveSeasonMissionRewardArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ReceiveSeasonMissionRewardReply Marshaller`1<ReceiveSeasonMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_ReceiveSeasonMissionRankRewardArgs Marshaller`1<ReceiveSeasonMissionRankRewardArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_ReceiveSeasonMissionRankRewardReply Marshaller`1<ReceiveSeasonMissionRankRewardReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_GetSeasonMission                Method`2<GetSeasonMissionArgs, GetSeasonMissionReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_UpdateLastDisplayDate           Method`2<UpdateLastDisplayDateArgs, UpdateLastDisplayDateReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_ReceiveSeasonMissionReward      Method`2<ReceiveSeasonMissionRewardArgs, ReceiveSeasonMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_ReceiveSeasonMissionRankReward  Method`2<ReceiveSeasonMissionRankRewardArgs, ReceiveSeasonMissionRankRewardReply> IL2CPP_TYPE_GENERICINST
    public partial class SeasonMissionService : DataModel
    {

        public static SeasonMissionService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionService() { Pointer= p0 };


            return value;
        }
    }
}
