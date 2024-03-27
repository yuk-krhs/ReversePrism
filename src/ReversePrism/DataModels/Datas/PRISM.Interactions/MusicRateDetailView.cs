using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UserInfoView                             00018666E2D0 ModelClassType MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView Pointer
    // 030 TabGroup                                 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 038 RewardListView                           00018666FD80 ModelClassType MusicRateRewardListView MusicRateRewardListView MusicRateRewardListView Pointer
    // 040 TargetMusicListView                      000186670730 ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer
    // 048 IsTargetMusicListInitialized             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 playMusicSubject                         Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    public partial class MusicRateDetailView
    {
        public MusicRateOverlayUserInfoView?            UserInfoView                            { get; set; }
        public UITabGroupEx?                            TabGroup                                { get; set; }
        public MusicRateRewardListView?                 RewardListView                          { get; set; }
        public MusicRateTargetMusicListView?            TargetMusicListView                     { get; set; }
        public bool                                     IsTargetMusicListInitialized            { get; set; }

        public static MusicRateDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateDetailView();

            value.UserInfoView                              = GetObject<MusicRateOverlayUserInfoView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateOverlayUserInfoView.FromPointer); // 0270DB3EAF38 0x28 UserInfoView                ( 00018666E2D0 ModelClassType MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView MusicRateOverlayUserInfoView Pointer )
            value.TabGroup                                  = GetObject<UITabGroupEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270DB3EAF58 0x30 TabGroup                    ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.RewardListView                            = GetObject<MusicRateRewardListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicRateRewardListView.FromPointer); // 0270DB3EAF78 0x38 RewardListView              ( 00018666FD80 ModelClassType MusicRateRewardListView MusicRateRewardListView MusicRateRewardListView Pointer )
            value.TargetMusicListView                       = GetObject<MusicRateTargetMusicListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.MusicRateTargetMusicListView.FromPointer); // 0270DB3EAF98 0x40 TargetMusicListView         ( 000186670730 ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer )
            value.IsTargetMusicListInitialized              = GetBool(new IntPtr(p + 0x048)); // 0270DB3EAFB8 0x48 IsTargetMusicListInitialized ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
