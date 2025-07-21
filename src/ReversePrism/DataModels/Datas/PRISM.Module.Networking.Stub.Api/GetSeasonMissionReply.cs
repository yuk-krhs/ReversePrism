using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSeasonMissionReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SeasonMissionFieldNumber                 int IL2CPP_TYPE_I4
    // 018 SeasonMission                            ModelClassType SeasonMissionStatus SeasonMissionStatus SeasonMissionStatus Pointer
    public partial class GetSeasonMissionReply : DataModel
    {
        public SeasonMissionStatus?                     SeasonMission                           { get; set; }

        public static GetSeasonMissionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSeasonMissionReply() { Pointer= p0 };

            value.SeasonMission                             = GetObject<SeasonMissionStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonMissionStatus.FromPointer); // 0x18 SeasonMission               ( ModelClassType SeasonMissionStatus SeasonMissionStatus SeasonMissionStatus Pointer )

            return value;
        }
    }
}
