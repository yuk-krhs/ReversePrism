using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClick                                  Subject`1<ValueTuple`2<int, SongDifficultyLevel>> IL2CPP_TYPE_GENERICINST
    // 028 HighScoreListView                        ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer
    // 030 TechnicalRateListView                    ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer
    // 038 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 040 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TabViews                                 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 SeasonNumber                             ModelPrimitiveType int int int Int32
    // 054 TabIndex                                 ModelPrimitiveType int int int Int32
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class RankingTargetSongPopupView : DataModel
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
            var value   = new RankingTargetSongPopupView() { Pointer= p0 };

            value.HighScoreListView                         = GetObject<MusicRateTargetMusicListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateTargetMusicListView.FromPointer); // 0x28 HighScoreListView           ( ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer )
            value.TechnicalRateListView                     = GetObject<MusicRateTargetMusicListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicRateTargetMusicListView.FromPointer); // 0x30 TechnicalRateListView       ( ModelClassType MusicRateTargetMusicListView MusicRateTargetMusicListView MusicRateTargetMusicListView Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x38 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TabViews                                  = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 TabViews                    ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SeasonNumber                              = GetInt32(new IntPtr(p + 0x050)); // 0x50 SeasonNumber                ( ModelPrimitiveType int int int Int32 )
            value.TabIndex                                  = GetInt32(new IntPtr(p + 0x054)); // 0x54 TabIndex                    ( ModelPrimitiveType int int int Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
