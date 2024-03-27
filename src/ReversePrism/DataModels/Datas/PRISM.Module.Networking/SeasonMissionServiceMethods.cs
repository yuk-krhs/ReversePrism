using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetSeasonMission                         Method`2<IGetSeasonMissionArgs, IGetSeasonMissionReply> IL2CPP_TYPE_GENERICINST
    // 018 UpdateLastDisplayDate                    Method`2<IUpdateLastDisplayDateArgs, IUpdateLastDisplayDateReply> IL2CPP_TYPE_GENERICINST
    // 030 ReceiveSeasonMissionReward               Method`2<IReceiveSeasonMissionRewardArgs, IReceiveSeasonMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 048 ReceiveSeasonMissionRankReward           Method`2<IReceiveSeasonMissionRankRewardArgs, IReceiveSeasonMissionRankRewardReply> IL2CPP_TYPE_GENERICINST
    public partial class SeasonMissionServiceMethods
    {

        public static SeasonMissionServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionServiceMethods();


            return value;
        }
    }
}
