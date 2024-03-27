using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetMissionList                           Method`2<IGetMissionListArgs, IGetMissionListReply> IL2CPP_TYPE_GENERICINST
    // 018 ReceiveMissionReward                     Method`2<IReceiveMissionRewardArgs, IReceiveMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 030 ReceiveMissionGaugeReward                Method`2<IReceiveMissionGaugeRewardArgs, IReceiveMissionGaugeRewardReply> IL2CPP_TYPE_GENERICINST
    // 048 TouchMissionGroup                        Method`2<ITouchMissionGroupArgs, ITouchMissionGroupReply> IL2CPP_TYPE_GENERICINST
    // 060 JumpToLink                               Method`2<IJumpToLinkArgs, IJumpToLinkReply> IL2CPP_TYPE_GENERICINST
    public partial class MissionServiceMethods
    {

        public static MissionServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionServiceMethods();


            return value;
        }
    }
}
