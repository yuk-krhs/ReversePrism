using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserInfoData                             00018666E7A0 ModelClassType MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel Pointer
    // 018 RewardDataList                           000185D13648 ModelClassListType IReadOnlyList`1<MusicRateRewardListCellData> IReadOnlyList`1<MusicRateRewardListCellData> List<MusicRateRewardListCellData> Pointer
    // 020 TargetMusicDataList                      000185D13898 ModelClassListType IReadOnlyList`1<MusicRateTargetMusicListCellData> IReadOnlyList`1<MusicRateTargetMusicListCellData> List<MusicRateTargetMusicListCellData> Pointer
    public partial class MusicRateDetailViewModel : DataModel
    {
        public MusicRateOverlayUserInfoViewModel?       UserInfoData                            { get; set; }
        public List<MusicRateRewardListCellData>?       RewardDataList                          { get; set; }
        public List<MusicRateTargetMusicListCellData>?  TargetMusicDataList                     { get; set; }

        public static MusicRateDetailViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateDetailViewModel() { Pointer= p0 };

            value.UserInfoData                              = GetObject<MusicRateOverlayUserInfoViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.MusicRateOverlayUserInfoViewModel.FromPointer); // 0246664439C0 0x10 UserInfoData                ( 00018666E7A0 ModelClassType MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel MusicRateOverlayUserInfoViewModel Pointer )
            value.RewardDataList                            = GetObjectList<MusicRateRewardListCellData>(new IntPtr(p + 0x018), ReversePrism.DataModels.MusicRateRewardListCellData.FromPointer); // 0246664439E0 0x18 RewardDataList              ( 000185D13648 ModelClassListType IReadOnlyList`1<MusicRateRewardListCellData> IReadOnlyList`1<MusicRateRewardListCellData> List<MusicRateRewardListCellData> Pointer )
            value.TargetMusicDataList                       = GetObjectList<MusicRateTargetMusicListCellData>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateTargetMusicListCellData.FromPointer); // 024666443A00 0x20 TargetMusicDataList         ( 000185D13898 ModelClassListType IReadOnlyList`1<MusicRateTargetMusicListCellData> IReadOnlyList`1<MusicRateTargetMusicListCellData> List<MusicRateTargetMusicListCellData> Pointer )

            return value;
        }
    }
}
