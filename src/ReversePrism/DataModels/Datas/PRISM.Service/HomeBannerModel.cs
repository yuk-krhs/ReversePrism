using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BannerInfoList                           000185CCE758 ModelClassListType List`1<BannerInfo> List`1<BannerInfo> List<BannerInfo> Pointer
    // 018 SeasonMissionBannerInfo                  00018662C230 ModelClassType ISeasonMissionBannerStatus ISeasonMissionBannerStatus ISeasonMissionBannerStatus Pointer
    // 020 SpecialMissionBannerInfoList             000185D0B888 ModelClassListType IReadOnlyList`1<ISpecialMissionBannerStatus> IReadOnlyList`1<ISpecialMissionBannerStatus> List<ISpecialMissionBannerStatus> Pointer
    // 028 OurStreamBannerInfo                      000186739820 ModelClassType BannerInfo BannerInfo BannerInfo Pointer
    public partial class HomeBannerModel
    {
        public List<BannerInfo>?                        BannerInfoList                          { get; set; }
        public ISeasonMissionBannerStatus?              SeasonMissionBannerInfo                 { get; set; }
        public List<ISpecialMissionBannerStatus>?       SpecialMissionBannerInfoList            { get; set; }
        public BannerInfo?                              OurStreamBannerInfo                     { get; set; }

        public static HomeBannerModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBannerModel();

            value.BannerInfoList                            = GetObjectList<BannerInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.BannerInfo.FromPointer); // 0270D322C6A0 0x10 BannerInfoList              ( 000185CCE758 ModelClassListType List`1<BannerInfo> List`1<BannerInfo> List<BannerInfo> Pointer )
            value.SeasonMissionBannerInfo                   = GetObject<ISeasonMissionBannerStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISeasonMissionBannerStatus.FromPointer); // 0270D322C6C0 0x18 SeasonMissionBannerInfo     ( 00018662C230 ModelClassType ISeasonMissionBannerStatus ISeasonMissionBannerStatus ISeasonMissionBannerStatus Pointer )
            value.SpecialMissionBannerInfoList              = GetObjectList<ISpecialMissionBannerStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISpecialMissionBannerStatus.FromPointer); // 0270D322C6E0 0x20 SpecialMissionBannerInfoList ( 000185D0B888 ModelClassListType IReadOnlyList`1<ISpecialMissionBannerStatus> IReadOnlyList`1<ISpecialMissionBannerStatus> List<ISpecialMissionBannerStatus> Pointer )
            value.OurStreamBannerInfo                       = GetObject<BannerInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.BannerInfo.FromPointer); // 0270D322C700 0x28 OurStreamBannerInfo         ( 000186739820 ModelClassType BannerInfo BannerInfo BannerInfo Pointer )

            return value;
        }
    }
}
