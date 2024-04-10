using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetSpecialMissionList                    Method`2<IGetSpecialMissionListArgs, IGetSpecialMissionListReply> IL2CPP_TYPE_GENERICINST
    // 018 ReceiveSpecialMissionReward              Method`2<IReceiveSpecialMissionRewardArgs, IReceiveSpecialMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 030 ReceiveSpecialMissionCompleteReward      Method`2<IReceiveSpecialMissionCompleteRewardArgs, IReceiveSpecialMissionCompleteRewardReply> IL2CPP_TYPE_GENERICINST
    // 048 TouchSpecialMission                      Method`2<ITouchSpecialMissionArgs, ITouchSpecialMissionReply> IL2CPP_TYPE_GENERICINST
    public partial class SpecialMissionServiceMethods : DataModel
    {

        public static SpecialMissionServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
