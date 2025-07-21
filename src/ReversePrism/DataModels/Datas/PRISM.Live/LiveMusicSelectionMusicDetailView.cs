using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardButton                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 RankingButton                            ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 FavoriteToggleButton                     ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 038 JacketEmptyObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 040 JacketImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 JacketInfoButton                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 2DMVMark                                 ModelClassType GameObject GameObject GameObject Pointer
    // 058 VoiceSeparatedMark                       ModelClassType GameObject GameObject GameObject Pointer
    // 060 LimitedVocalSeparatedMark                ModelClassType GameObject GameObject GameObject Pointer
    // 068 FocusCameraMark                          ModelClassType GameObject GameObject GameObject Pointer
    // 070 HasLiveCutSceneMark                      ModelClassType GameObject GameObject GameObject Pointer
    // 078 DifficultySelector                       ModelClassType MusicDifficultySelector MusicDifficultySelector MusicDifficultySelector Pointer
    // 080 SlideAnimation                           ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    // 088 JacketBaseImage                          ModelClassType UIImage UIImage UIImage Pointer
    // 090 MusicTypeAllJacketBaseSprite             ModelClassType Sprite Sprite Sprite Pointer
    // 098 MusicTypeExceptAllJacketBaseSprite       ModelClassType Sprite Sprite Sprite Pointer
    // 0A0 ResourceConfig                           ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer
    // 0A8 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class LiveMusicSelectionMusicDetailView : DataModel
    {
        public ButtonBase?                              RewardButton                            { get; set; }
        public ButtonBase?                              RankingButton                           { get; set; }
        public ToggleButton?                            FavoriteToggleButton                    { get; set; }
        public GameObject?                              JacketEmptyObject                       { get; set; }
        public UIRawImage?                              JacketImage                             { get; set; }
        public ButtonBase?                              JacketInfoButton                        { get; set; }
        public GameObject?                              2DMVMark                                { get; set; }
        public GameObject?                              VoiceSeparatedMark                      { get; set; }
        public GameObject?                              LimitedVocalSeparatedMark               { get; set; }
        public GameObject?                              FocusCameraMark                         { get; set; }
        public GameObject?                              HasLiveCutSceneMark                     { get; set; }
        public MusicDifficultySelector?                 DifficultySelector                      { get; set; }
        public SimpleSlideAnimation?                    SlideAnimation                          { get; set; }
        public UIImage?                                 JacketBaseImage                         { get; set; }
        public Sprite?                                  MusicTypeAllJacketBaseSprite            { get; set; }
        public Sprite?                                  MusicTypeExceptAllJacketBaseSprite      { get; set; }
        public LiveUIResourceConfig?                    ResourceConfig                          { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveMusicSelectionMusicDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionMusicDetailView() { Pointer= p0 };

            value.RewardButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 RewardButton                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RankingButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 RankingButton               ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.FavoriteToggleButton                      = GetObject<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x30 FavoriteToggleButton        ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.JacketEmptyObject                         = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 JacketEmptyObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.JacketImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x40 JacketImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.JacketInfoButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 JacketInfoButton            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.2DMVMark                                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 2DMVMark                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.VoiceSeparatedMark                        = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 VoiceSeparatedMark          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LimitedVocalSeparatedMark                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 LimitedVocalSeparatedMark   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FocusCameraMark                           = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 FocusCameraMark             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HasLiveCutSceneMark                       = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 HasLiveCutSceneMark         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DifficultySelector                        = GetObject<MusicDifficultySelector>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicDifficultySelector.FromPointer); // 0x78 DifficultySelector          ( ModelClassType MusicDifficultySelector MusicDifficultySelector MusicDifficultySelector Pointer )
            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x080), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0x80 SlideAnimation              ( ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )
            value.JacketBaseImage                           = GetObject<UIImage>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIImage.FromPointer); // 0x88 JacketBaseImage             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.MusicTypeAllJacketBaseSprite              = GetObject<Sprite>(new IntPtr(p + 0x090), ReversePrism.DataModels.Sprite.FromPointer); // 0x90 MusicTypeAllJacketBaseSprite ( ModelClassType Sprite Sprite Sprite Pointer )
            value.MusicTypeExceptAllJacketBaseSprite        = GetObject<Sprite>(new IntPtr(p + 0x098), ReversePrism.DataModels.Sprite.FromPointer); // 0x98 MusicTypeExceptAllJacketBaseSprite ( ModelClassType Sprite Sprite Sprite Pointer )
            value.ResourceConfig                            = GetObject<LiveUIResourceConfig>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.LiveUIResourceConfig.FromPointer); // 0xA0 ResourceConfig              ( ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
