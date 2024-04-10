using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 JacketIcon                               0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 MusicTypeIcon                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 MusicName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MusicLevel                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MusicLevelColors                         000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 048 FavoriteMark                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 NewMark                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ClearStatusLampView                      000186664330 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer
    // 060 ScoreRankParent                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 ScoreRankImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 070 NoScoreRankObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ComboRankImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 080 NoComboRankObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 ResourceConfig                           000186587F10 ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer
    // 090 HighScoreParent                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 HighScore                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 HighScoreRate                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 TechnicalScoreParent                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 TechnicalScore                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 TechnicalScoreRate                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 TechnicalScoreRateNormalColor            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0D0 TechnicalScoreRateMaxColor               0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0E0 SwitchableDisplays                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 0E8 CachedMusicData                          000186664B50 ModelClassType MusicData MusicData MusicData Pointer
    // 0F0 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class MusicListCellCommonView : DataModel
    {
        public UIRawImage?                              JacketIcon                              { get; set; }
        public UIRawImage?                              MusicTypeIcon                           { get; set; }
        public UITextMeshProUGUI?                       MusicName                               { get; set; }
        public UITextMeshProUGUI?                       MusicLevel                              { get; set; }
        public List<Color>?                             MusicLevelColors                        { get; set; }
        public GameObject?                              FavoriteMark                            { get; set; }
        public GameObject?                              NewMark                                 { get; set; }
        public MusicClearStatusLampView?                ClearStatusLampView                     { get; set; }
        public GameObject?                              ScoreRankParent                         { get; set; }
        public UIImage?                                 ScoreRankImage                          { get; set; }
        public GameObject?                              NoScoreRankObject                       { get; set; }
        public UIImage?                                 ComboRankImage                          { get; set; }
        public GameObject?                              NoComboRankObject                       { get; set; }
        public LiveUIResourceConfig?                    ResourceConfig                          { get; set; }
        public GameObject?                              HighScoreParent                         { get; set; }
        public UITextMeshProUGUI?                       HighScore                               { get; set; }
        public UITextMeshProUGUI?                       HighScoreRate                           { get; set; }
        public GameObject?                              TechnicalScoreParent                    { get; set; }
        public UITextMeshProUGUI?                       TechnicalScore                          { get; set; }
        public UITextMeshProUGUI?                       TechnicalScoreRate                      { get; set; }
        public Color                                    TechnicalScoreRateNormalColor           { get; set; }
        public Color                                    TechnicalScoreRateMaxColor              { get; set; }
        public List<GameObject>?                        SwitchableDisplays                      { get; set; }
        public MusicData?                               CachedMusicData                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static MusicListCellCommonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListCellCommonView() { Pointer= p0 };

            value.JacketIcon                                = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0246651FA380 0x20 JacketIcon                  ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicTypeIcon                             = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0246651FA3A0 0x28 MusicTypeIcon               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FA3C0 0x30 MusicName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicLevel                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FA3E0 0x38 MusicLevel                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicLevelColors                          = GetEnumList<Color>(new IntPtr(p + 0x040)); // 0246651FA400 0x40 MusicLevelColors            ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.FavoriteMark                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA420 0x48 FavoriteMark                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NewMark                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA440 0x50 NewMark                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStatusLampView                       = GetObject<MusicClearStatusLampView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicClearStatusLampView.FromPointer); // 0246651FA460 0x58 ClearStatusLampView         ( 000186664330 ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer )
            value.ScoreRankParent                           = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA480 0x60 ScoreRankParent             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreRankImage                            = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0246651FA4A0 0x68 ScoreRankImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NoScoreRankObject                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA4C0 0x70 NoScoreRankObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ComboRankImage                            = GetObject<UIImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIImage.FromPointer); // 0246651FA4E0 0x78 ComboRankImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NoComboRankObject                         = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA500 0x80 NoComboRankObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ResourceConfig                            = GetObject<LiveUIResourceConfig>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveUIResourceConfig.FromPointer); // 0246651FA520 0x88 ResourceConfig              ( 000186587F10 ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer )
            value.HighScoreParent                           = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA540 0x90 HighScoreParent             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.HighScore                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FA560 0x98 HighScore                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HighScoreRate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FA580 0xA0 HighScoreRate               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreParent                      = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA5A0 0xA8 TechnicalScoreParent        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TechnicalScore                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FA5C0 0xB0 TechnicalScore              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreRate                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651FA5E0 0xB8 TechnicalScoreRate          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreRateNormalColor             = (Color)GetInt32(new IntPtr(p + 0x0C0)); // 0246651FA600 0xC0 TechnicalScoreRateNormalColor ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.TechnicalScoreRateMaxColor                = (Color)GetInt32(new IntPtr(p + 0x0D0)); // 0246651FA620 0xD0 TechnicalScoreRateMaxColor  ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.SwitchableDisplays                        = GetObjectList<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0246651FA640 0xE0 SwitchableDisplays          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CachedMusicData                           = GetObject<MusicData>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.MusicData.FromPointer); // 0246651FA660 0xE8 CachedMusicData             ( 000186664B50 ModelClassType MusicData MusicData MusicData Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246651FA680 0xF0 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
