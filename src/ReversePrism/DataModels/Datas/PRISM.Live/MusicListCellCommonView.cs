using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 JacketIcon                               ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 MusicTypeIcon                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 MusicName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MusicLevel                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MusicLevelColors                         ModelEnumListType Color[] Color[] List<Color> Pointer
    // 048 FavoriteMark                             ModelClassType GameObject GameObject GameObject Pointer
    // 050 NewMark                                  ModelClassType GameObject GameObject GameObject Pointer
    // 058 ClearStatusLampView                      ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer
    // 060 ScoreRankParent                          ModelClassType GameObject GameObject GameObject Pointer
    // 068 ScoreRankImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 070 NoScoreRankObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 078 ComboRankImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 080 NoComboRankObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 088 ResourceConfig                           ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer
    // 090 Combo                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 TotalNotes                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 HighScoreParent                          ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 HighScore                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 HighScoreRate                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 TechnicalScoreParent                     ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 TechnicalScore                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 TechnicalScoreRate                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 NormalColor                              ModelEnumType Color Color Color Int32
    // 0E0 MaxColor                                 ModelEnumType Color Color Color Int32
    // 0F0 ShinyColor                               ModelEnumType Color Color Color Int32
    // 100 SwitchableDisplays                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 108 CachedMusicData                          ModelClassType MusicData MusicData MusicData Pointer
    // 110 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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
        public UITextMeshProUGUI?                       Combo                                   { get; set; }
        public UITextMeshProUGUI?                       TotalNotes                              { get; set; }
        public GameObject?                              HighScoreParent                         { get; set; }
        public UITextMeshProUGUI?                       HighScore                               { get; set; }
        public UITextMeshProUGUI?                       HighScoreRate                           { get; set; }
        public GameObject?                              TechnicalScoreParent                    { get; set; }
        public UITextMeshProUGUI?                       TechnicalScore                          { get; set; }
        public UITextMeshProUGUI?                       TechnicalScoreRate                      { get; set; }
        public Color                                    NormalColor                             { get; set; }
        public Color                                    MaxColor                                { get; set; }
        public Color                                    ShinyColor                              { get; set; }
        public List<GameObject>?                        SwitchableDisplays                      { get; set; }
        public MusicData?                               CachedMusicData                         { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static MusicListCellCommonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListCellCommonView() { Pointer= p0 };

            value.JacketIcon                                = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 JacketIcon                  ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicTypeIcon                             = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 MusicTypeIcon               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 MusicName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicLevel                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 MusicLevel                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicLevelColors                          = GetEnumList<Color>(new IntPtr(p + 0x040)); // 0x40 MusicLevelColors            ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.FavoriteMark                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 FavoriteMark                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NewMark                                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 NewMark                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ClearStatusLampView                       = GetObject<MusicClearStatusLampView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicClearStatusLampView.FromPointer); // 0x58 ClearStatusLampView         ( ModelClassType MusicClearStatusLampView MusicClearStatusLampView MusicClearStatusLampView Pointer )
            value.ScoreRankParent                           = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 ScoreRankParent             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScoreRankImage                            = GetObject<UIImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIImage.FromPointer); // 0x68 ScoreRankImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NoScoreRankObject                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 NoScoreRankObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ComboRankImage                            = GetObject<UIImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIImage.FromPointer); // 0x78 ComboRankImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NoComboRankObject                         = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 NoComboRankObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ResourceConfig                            = GetObject<LiveUIResourceConfig>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveUIResourceConfig.FromPointer); // 0x88 ResourceConfig              ( ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer )
            value.Combo                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 Combo                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalNotes                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 TotalNotes                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HighScoreParent                           = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 HighScoreParent             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HighScore                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 HighScore                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HighScoreRate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 HighScoreRate               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreParent                      = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 TechnicalScoreParent        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TechnicalScore                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 TechnicalScore              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TechnicalScoreRate                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC8 TechnicalScoreRate          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NormalColor                               = (Color)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 NormalColor                 ( ModelEnumType Color Color Color Int32 )
            value.MaxColor                                  = (Color)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 MaxColor                    ( ModelEnumType Color Color Color Int32 )
            value.ShinyColor                                = (Color)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 ShinyColor                  ( ModelEnumType Color Color Color Int32 )
            value.SwitchableDisplays                        = GetObjectList<GameObject>(new IntPtr(p + 0x100), ReversePrism.DataModels.GameObject.FromPointer); // 0x100 SwitchableDisplays          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CachedMusicData                           = GetObject<MusicData>(new IntPtr(p + 0x108), ReversePrism.DataModels.MusicData.FromPointer); // 0x108 CachedMusicData             ( ModelClassType MusicData MusicData MusicData Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x110), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x110 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
