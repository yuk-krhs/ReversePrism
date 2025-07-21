using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UpdateLastDisplayDateReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MissionTabFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MissionTab                               ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer
    // 000 RankRewardTabFieldNumber                 int IL2CPP_TYPE_I4
    // 020 RankRewardTab                            ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer
    public partial class UpdateLastDisplayDateReply : DataModel
    {
        public SeasonMissionTabStatus?                  MissionTab                              { get; set; }
        public SeasonMissionTabStatus?                  RankRewardTab                           { get; set; }

        public static UpdateLastDisplayDateReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateLastDisplayDateReply() { Pointer= p0 };

            value.MissionTab                                = GetObject<SeasonMissionTabStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonMissionTabStatus.FromPointer); // 0x18 MissionTab                  ( ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer )
            value.RankRewardTab                             = GetObject<SeasonMissionTabStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SeasonMissionTabStatus.FromPointer); // 0x20 RankRewardTab               ( ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer )

            return value;
        }
    }
}
