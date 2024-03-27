using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetSpecialMissionListArgs Marshaller`1<GetSpecialMissionListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetSpecialMissionListReply Marshaller`1<GetSpecialMissionListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_ReceiveSpecialMissionRewardArgs Marshaller`1<ReceiveSpecialMissionRewardArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_ReceiveSpecialMissionRewardReply Marshaller`1<ReceiveSpecialMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_ReceiveSpecialMissionCompleteRewardArgs Marshaller`1<ReceiveSpecialMissionCompleteRewardArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_ReceiveSpecialMissionCompleteRewardReply Marshaller`1<ReceiveSpecialMissionCompleteRewardReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_TouchSpecialMissionArgs Marshaller`1<TouchSpecialMissionArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_TouchSpecialMissionReply Marshaller`1<TouchSpecialMissionReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_GetSpecialMissionList           Method`2<GetSpecialMissionListArgs, GetSpecialMissionListReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_ReceiveSpecialMissionReward     Method`2<ReceiveSpecialMissionRewardArgs, ReceiveSpecialMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_ReceiveSpecialMissionCompleteReward Method`2<ReceiveSpecialMissionCompleteRewardArgs, ReceiveSpecialMissionCompleteRewardReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_TouchSpecialMission             Method`2<TouchSpecialMissionArgs, TouchSpecialMissionReply> IL2CPP_TYPE_GENERICINST
    public partial class SpecialMissionService
    {

        public static SpecialMissionService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionService();


            return value;
        }
    }
}
