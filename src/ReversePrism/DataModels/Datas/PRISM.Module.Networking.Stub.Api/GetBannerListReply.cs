using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetBannerListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BannerGenreListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_bannerGenreList_codec          FieldCodec`1<BannerGenreStatus> IL2CPP_TYPE_GENERICINST
    // 018 BannerGenreList                          ModelClassListType RepeatedField`1<BannerGenreStatus> RepeatedField`1<BannerGenreStatus> List<BannerGenreStatus> Pointer
    // 000 BannerListFieldNumber                    int IL2CPP_TYPE_I4
    // 010 _repeated_bannerList_codec               FieldCodec`1<BannerStatus> IL2CPP_TYPE_GENERICINST
    // 020 BannerList                               ModelClassListType RepeatedField`1<BannerStatus> RepeatedField`1<BannerStatus> List<BannerStatus> Pointer
    // 000 SeasonMissionBannerFieldNumber           int IL2CPP_TYPE_I4
    // 028 SeasonMissionBanner                      ModelClassType SeasonMissionBannerStatus SeasonMissionBannerStatus SeasonMissionBannerStatus Pointer
    // 000 SpecialMissionBannerListFieldNumber      int IL2CPP_TYPE_I4
    // 018 _repeated_specialMissionBannerList_codec FieldCodec`1<SpecialMissionBannerStatus> IL2CPP_TYPE_GENERICINST
    // 030 SpecialMissionBannerList                 ModelClassListType RepeatedField`1<SpecialMissionBannerStatus> RepeatedField`1<SpecialMissionBannerStatus> List<SpecialMissionBannerStatus> Pointer
    public partial class GetBannerListReply : DataModel
    {
        public List<BannerGenreStatus>?                 BannerGenreList                         { get; set; }
        public List<BannerStatus>?                      BannerList                              { get; set; }
        public SeasonMissionBannerStatus?               SeasonMissionBanner                     { get; set; }
        public List<SpecialMissionBannerStatus>?        SpecialMissionBannerList                { get; set; }

        public static GetBannerListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetBannerListReply() { Pointer= p0 };

            value.BannerGenreList                           = GetObjectList<BannerGenreStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.BannerGenreStatus.FromPointer); // 0x18 BannerGenreList             ( ModelClassListType RepeatedField`1<BannerGenreStatus> RepeatedField`1<BannerGenreStatus> List<BannerGenreStatus> Pointer )
            value.BannerList                                = GetObjectList<BannerStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.BannerStatus.FromPointer); // 0x20 BannerList                  ( ModelClassListType RepeatedField`1<BannerStatus> RepeatedField`1<BannerStatus> List<BannerStatus> Pointer )
            value.SeasonMissionBanner                       = GetObject<SeasonMissionBannerStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SeasonMissionBannerStatus.FromPointer); // 0x28 SeasonMissionBanner         ( ModelClassType SeasonMissionBannerStatus SeasonMissionBannerStatus SeasonMissionBannerStatus Pointer )
            value.SpecialMissionBannerList                  = GetObjectList<SpecialMissionBannerStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpecialMissionBannerStatus.FromPointer); // 0x30 SpecialMissionBannerList    ( ModelClassListType RepeatedField`1<SpecialMissionBannerStatus> RepeatedField`1<SpecialMissionBannerStatus> List<SpecialMissionBannerStatus> Pointer )

            return value;
        }
    }
}
