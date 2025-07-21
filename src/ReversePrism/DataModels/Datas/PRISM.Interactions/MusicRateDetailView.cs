using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UserInfoView                             ModelClassType MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView Pointer
    // 030 TabGroup                                 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 038 RewardListView                           ModelClassType MusicRateRewardListView MusicRateRewardListView MusicRateRewardListView Pointer
    // 040 TargetMusicListView                      ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer
    // 048 IsRewardListInitialized                  ModelPrimitiveType bool bool bool Bool
    // 049 IsTargetMusicListInitialized             ModelPrimitiveType bool bool bool Bool
    // 050 playMusicSubject                         Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    public partial class MusicRateDetailView : DataModel
    {
        public MusicRateOverlayUserInfoView?            UserInfoView                            { get; set; }
        public UITabGroupEx?                            TabGroup                                { get; set; }
        public MusicRateRewardListView?                 RewardListView                          { get; set; }
        public MusicRateTargetMusicListView?            TargetMusicListView                     { get; set; }
        public bool                                     IsRewardListInitialized                 { get; set; }
        public bool                                     IsTargetMusicListInitialized            { get; set; }

        public static MusicRateDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateDetailView() { Pointer= p0 };

            value.UserInfoView                              = GetObject<MusicRateOverlayUserInfoView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateOverlayUserInfoView.FromPointer); // 0x28 UserInfoView                ( ModelClassType MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView Pointer )
            value.TabGroup                                  = GetObject<UITabGroupEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x30 TabGroup                    ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.RewardListView                            = GetObject<MusicRateRewardListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicRateRewardListView.FromPointer); // 0x38 RewardListView              ( ModelClassType MusicRateRewardListView MusicRateRewardListView MusicRateRewardListView Pointer )
            value.TargetMusicListView                       = GetObject<MusicRateTargetMusicListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicRateTargetMusicListView.FromPointer); // 0x40 TargetMusicListView         ( ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer )
            value.IsRewardListInitialized                   = GetBool(new IntPtr(p + 0x048)); // 0x48 IsRewardListInitialized     ( ModelPrimitiveType bool bool bool Bool )
            value.IsTargetMusicListInitialized              = GetBool(new IntPtr(p + 0x049)); // 0x49 IsTargetMusicListInitialized ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
