using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProducerSeasonInfoListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SeasonStatusListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_seasonStatusList_codec         FieldCodec`1<ProfileSeasonStatus> IL2CPP_TYPE_GENERICINST
    // 018 SeasonStatusList                         000185CED288 ModelClassListType RepeatedField`1<ProfileSeasonStatus> RepeatedField`1<ProfileSeasonStatus> List<ProfileSeasonStatus> Pointer
    public partial class GetProducerSeasonInfoListReply
    {
        public List<ProfileSeasonStatus>?               SeasonStatusList                        { get; set; }

        public static GetProducerSeasonInfoListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProducerSeasonInfoListReply();

            value.SeasonStatusList                          = GetObjectList<ProfileSeasonStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileSeasonStatus.FromPointer); // 0270D2704730 0x18 SeasonStatusList            ( 000185CED288 ModelClassListType RepeatedField`1<ProfileSeasonStatus> RepeatedField`1<ProfileSeasonStatus> List<ProfileSeasonStatus> Pointer )

            return value;
        }
    }
}
