using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClick                                  Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    // 028 HighScoreListView                        000186670730 ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer
    // 030 TechnicalRateListView                    000186670730 ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer
    // 038 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 040 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TabViews                                 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 SeasonNumber                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 TabIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class RankingTargetSongPopupView
    {
        public MusicRateTargetMusicListView?            HighScoreListView                       { get; set; }
        public MusicRateTargetMusicListView?            TechnicalRateListView                   { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public List<GameObject>?                        TabViews                                { get; set; }
        public int                                      SeasonNumber                            { get; set; }
        public int                                      TabIndex                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static RankingTargetSongPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingTargetSongPopupView();

            value.HighScoreListView                         = GetObject<MusicRateTargetMusicListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateTargetMusicListView.FromPointer); // 0270DB41E570 0x28 HighScoreListView           ( 000186670730 ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer )
            value.TechnicalRateListView                     = GetObject<MusicRateTargetMusicListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicRateTargetMusicListView.FromPointer); // 0270DB41E590 0x30 TechnicalRateListView       ( 000186670730 ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DB41E5B0 0x38 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB41E5D0 0x40 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TabViews                                  = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB41E5F0 0x48 TabViews                    ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SeasonNumber                              = GetInt32(new IntPtr(p + 0x050)); // 0270DB41E610 0x50 SeasonNumber                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x054)); // 0270DB41E630 0x54 TabIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB41E650 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
