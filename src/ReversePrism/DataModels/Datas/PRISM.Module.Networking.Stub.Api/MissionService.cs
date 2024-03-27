using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetMissionListArgs      Marshaller`1<GetMissionListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetMissionListReply     Marshaller`1<GetMissionListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_ReceiveMissionRewardArgs Marshaller`1<ReceiveMissionRewardArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_ReceiveMissionRewardReply Marshaller`1<ReceiveMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ReceiveMissionGaugeRewardArgs Marshaller`1<ReceiveMissionGaugeRewardArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ReceiveMissionGaugeRewardReply Marshaller`1<ReceiveMissionGaugeRewardReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_TouchMissionGroupArgs   Marshaller`1<TouchMissionGroupArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_TouchMissionGroupReply  Marshaller`1<TouchMissionGroupReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_JumpToLinkArgs          Marshaller`1<JumpToLinkArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_JumpToLinkReply         Marshaller`1<JumpToLinkReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetMissionList                  Method`2<GetMissionListArgs, GetMissionListReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_ReceiveMissionReward            Method`2<ReceiveMissionRewardArgs, ReceiveMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_ReceiveMissionGaugeReward       Method`2<ReceiveMissionGaugeRewardArgs, ReceiveMissionGaugeRewardReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_TouchMissionGroup               Method`2<TouchMissionGroupArgs, TouchMissionGroupReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_JumpToLink                      Method`2<JumpToLinkArgs, JumpToLinkReply> IL2CPP_TYPE_GENERICINST
    public partial class MissionService
    {

        public static MissionService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionService();


            return value;
        }
    }
}
