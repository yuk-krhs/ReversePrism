using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BannerInfoList                           ModelClassListType List`1<BannerInfo> List`1<BannerInfo> List<BannerInfo> Pointer
    // 018 SeasonMissionBannerInfo                  ModelClassType ISeasonMissionBannerStatus ISeasonMissionBannerStatus ISeasonMissionBannerStatus Pointer
    // 020 SpecialMissionBannerInfoList             ModelClassListType IReadOnlyList`1<ISpecialMissionBannerStatus> IReadOnlyList`1<ISpecialMissionBannerStatus> List<ISpecialMissionBannerStatus> Pointer
    // 028 OurStreamBannerInfo                      ModelClassType BannerInfo BannerInfo BannerInfo Pointer
    public partial class HomeBannerModel : DataModel
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
            var value   = new HomeBannerModel() { Pointer= p0 };

            value.BannerInfoList                            = GetObjectList<BannerInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.BannerInfo.FromPointer); // 0x10 BannerInfoList              ( ModelClassListType List`1<BannerInfo> List`1<BannerInfo> List<BannerInfo> Pointer )
            value.SeasonMissionBannerInfo                   = GetObject<ISeasonMissionBannerStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISeasonMissionBannerStatus.FromPointer); // 0x18 SeasonMissionBannerInfo     ( ModelClassType ISeasonMissionBannerStatus ISeasonMissionBannerStatus ISeasonMissionBannerStatus Pointer )
            value.SpecialMissionBannerInfoList              = GetObjectList<ISpecialMissionBannerStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISpecialMissionBannerStatus.FromPointer); // 0x20 SpecialMissionBannerInfoList ( ModelClassListType IReadOnlyList`1<ISpecialMissionBannerStatus> IReadOnlyList`1<ISpecialMissionBannerStatus> List<ISpecialMissionBannerStatus> Pointer )
            value.OurStreamBannerInfo                       = GetObject<BannerInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.BannerInfo.FromPointer); // 0x28 OurStreamBannerInfo         ( ModelClassType BannerInfo BannerInfo BannerInfo Pointer )

            return value;
        }
    }
}
