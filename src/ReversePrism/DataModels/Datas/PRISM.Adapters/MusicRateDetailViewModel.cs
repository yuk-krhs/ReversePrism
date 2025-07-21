using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserInfoData                             ModelClassType MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel Pointer
    // 018 RewardDataList                           ModelClassListType IReadOnlyList`1<MusicRateRewardListCellData> IReadOnlyList`1<MusicRateRewardListCellData> List<MusicRateRewardListCellData> Pointer
    // 020 TargetMusicDataList                      ModelClassListType IReadOnlyList`1<MusicRateTargetMusicListCellData> IReadOnlyList`1<MusicRateTargetMusicListCellData> List<MusicRateTargetMusicListCellData> Pointer
    // 028 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 030 CanSelectMusic                           ModelPrimitiveType bool bool bool Bool
    public partial class MusicRateDetailViewModel : DataModel
    {
        public MusicRateOverlayUserInfoViewModel?       UserInfoData                            { get; set; }
        public List<MusicRateRewardListCellData>?       RewardDataList                          { get; set; }
        public List<MusicRateTargetMusicListCellData>?  TargetMusicDataList                     { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public bool                                     CanSelectMusic                          { get; set; }

        public static MusicRateDetailViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateDetailViewModel() { Pointer= p0 };

            value.UserInfoData                              = GetObject<MusicRateOverlayUserInfoViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.MusicRateOverlayUserInfoViewModel.FromPointer); // 0x10 UserInfoData                ( ModelClassType MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel Pointer )
            value.RewardDataList                            = GetObjectList<MusicRateRewardListCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.MusicRateRewardListCellData.FromPointer); // 0x18 RewardDataList              ( ModelClassListType IReadOnlyList`1<MusicRateRewardListCellData> IReadOnlyList`1<MusicRateRewardListCellData> List<MusicRateRewardListCellData> Pointer )
            value.TargetMusicDataList                       = GetObjectList<MusicRateTargetMusicListCellData>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateTargetMusicListCellData.FromPointer); // 0x20 TargetMusicDataList         ( ModelClassListType IReadOnlyList`1<MusicRateTargetMusicListCellData> IReadOnlyList`1<MusicRateTargetMusicListCellData> List<MusicRateTargetMusicListCellData> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x28 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.CanSelectMusic                            = GetBool(new IntPtr(p + 0x030)); // 0x30 CanSelectMusic              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
