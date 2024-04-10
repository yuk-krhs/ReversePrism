using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardButton                             000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 RankingButton                            000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 FavoriteToggleButton                     000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 038 JacketEmptyObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 JacketImage                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 JacketInfoButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 2DMVMark                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 VoiceSeparatedMark                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 FocusCameraMark                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 DifficultySelector                       000186665C80 ModelClassType MusicDifficultySelector MusicDifficultySelector MusicDifficultySelector Pointer
    // 070 SlideAnimation                           00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    // 078 JacketBaseImage                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 080 MusicTypeAllJacketBaseSprite             00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 088 MusicTypeExceptAllJacketBaseSprite       00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 090 ResourceConfig                           000186587F10 ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer
    // 098 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
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
        public GameObject?                              FocusCameraMark                         { get; set; }
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

            value.RewardButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246651CD1F8 0x20 RewardButton                ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.RankingButton                             = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246651CD218 0x28 RankingButton               ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.FavoriteToggleButton                      = GetObject<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0246651CD238 0x30 FavoriteToggleButton        ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.JacketEmptyObject                         = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246651CD258 0x38 JacketEmptyObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.JacketImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0246651CD278 0x40 JacketImage                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.JacketInfoButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246651CD298 0x48 JacketInfoButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.2DMVMark                                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0246651CD2B8 0x50 2DMVMark                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.VoiceSeparatedMark                        = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0246651CD2D8 0x58 VoiceSeparatedMark          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FocusCameraMark                           = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0246651CD2F8 0x60 FocusCameraMark             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DifficultySelector                        = GetObject<MusicDifficultySelector>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicDifficultySelector.FromPointer); // 0246651CD318 0x68 DifficultySelector          ( 000186665C80 ModelClassType MusicDifficultySelector MusicDifficultySelector MusicDifficultySelector Pointer )
            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x070), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0246651CD338 0x70 SlideAnimation              ( 00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )
            value.JacketBaseImage                           = GetObject<UIImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIImage.FromPointer); // 0246651CD358 0x78 JacketBaseImage             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.MusicTypeAllJacketBaseSprite              = GetObject<Sprite>(new IntPtr(p + 0x080), ReversePrism.DataModels.Sprite.FromPointer); // 0246651CD378 0x80 MusicTypeAllJacketBaseSprite ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.MusicTypeExceptAllJacketBaseSprite        = GetObject<Sprite>(new IntPtr(p + 0x088), ReversePrism.DataModels.Sprite.FromPointer); // 0246651CD398 0x88 MusicTypeExceptAllJacketBaseSprite ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.ResourceConfig                            = GetObject<LiveUIResourceConfig>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveUIResourceConfig.FromPointer); // 0246651CD3B8 0x90 ResourceConfig              ( 000186587F10 ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x098)); // 0246651CD3D8 0x98 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
