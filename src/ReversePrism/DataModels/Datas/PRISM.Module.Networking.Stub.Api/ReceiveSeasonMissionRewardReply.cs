using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveSeasonMissionRewardReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SeasonMissionFieldNumber                 int IL2CPP_TYPE_I4
    // 018 SeasonMission                            000186708430 ModelClassType SeasonMissionStatus SeasonMissionStatus SeasonMissionStatus Pointer
    public partial class ReceiveSeasonMissionRewardReply
    {
        public SeasonMissionStatus?                     SeasonMission                           { get; set; }

        public static ReceiveSeasonMissionRewardReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveSeasonMissionRewardReply();

            value.SeasonMission                             = GetObject<SeasonMissionStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonMissionStatus.FromPointer); // 0270D278C298 0x18 SeasonMission               ( 000186708430 ModelClassType SeasonMissionStatus SeasonMissionStatus SeasonMissionStatus Pointer )

            return value;
        }
    }
}
