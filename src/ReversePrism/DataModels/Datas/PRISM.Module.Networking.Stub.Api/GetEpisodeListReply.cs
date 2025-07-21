using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetEpisodeListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 EpisodeListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_episodeList_codec              FieldCodec`1<EpisodeStatus> IL2CPP_TYPE_GENERICINST
    // 018 EpisodeList                              ModelClassListType RepeatedField`1<EpisodeStatus> RepeatedField`1<EpisodeStatus> List<EpisodeStatus> Pointer
    // 000 EpisodeEventMissionBannerListFieldNumber int IL2CPP_TYPE_I4
    // 010 _repeated_episodeEventMissionBannerList_codec FieldCodec`1<EpisodeEventMissionBannerStatus> IL2CPP_TYPE_GENERICINST
    // 020 EpisodeEventMissionBannerList            ModelClassListType RepeatedField`1<EpisodeEventMissionBannerStatus> RepeatedField`1<EpisodeEventMissionBannerStatus> List<EpisodeEventMissionBannerStatus> Pointer
    public partial class GetEpisodeListReply : DataModel
    {
        public List<EpisodeStatus>?                     EpisodeList                             { get; set; }
        public List<EpisodeEventMissionBannerStatus>?   EpisodeEventMissionBannerList           { get; set; }

        public static GetEpisodeListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetEpisodeListReply() { Pointer= p0 };

            value.EpisodeList                               = GetObjectList<EpisodeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.EpisodeStatus.FromPointer); // 0x18 EpisodeList                 ( ModelClassListType RepeatedField`1<EpisodeStatus> RepeatedField`1<EpisodeStatus> List<EpisodeStatus> Pointer )
            value.EpisodeEventMissionBannerList             = GetObjectList<EpisodeEventMissionBannerStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.EpisodeEventMissionBannerStatus.FromPointer); // 0x20 EpisodeEventMissionBannerList ( ModelClassListType RepeatedField`1<EpisodeEventMissionBannerStatus> RepeatedField`1<EpisodeEventMissionBannerStatus> List<EpisodeEventMissionBannerStatus> Pointer )

            return value;
        }
    }
}
