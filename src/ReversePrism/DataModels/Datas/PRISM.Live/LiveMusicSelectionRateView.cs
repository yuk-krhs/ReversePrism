using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HighScoreRateView                        ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 028 TechnicalScoreRateView                   ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 030 SwitchRateViewButton                     ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 SwitchRateViewIcon                       ModelClassType Image Image Image Pointer
    // 040 SwitchRateViewSprites                    ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 048 SlideAnimation                           ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    // 050 onClickRateView                          Subject`1<MusicRateType> IL2CPP_TYPE_GENERICINST
    // 058 onSwitchRateView                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class LiveMusicSelectionRateView : DataModel
    {
        public MusicRateView?                           HighScoreRateView                       { get; set; }
        public MusicRateView?                           TechnicalScoreRateView                  { get; set; }
        public ButtonBase?                              SwitchRateViewButton                    { get; set; }
        public Image?                                   SwitchRateViewIcon                      { get; set; }
        public List<Sprite>?                            SwitchRateViewSprites                   { get; set; }
        public SimpleSlideAnimation?                    SlideAnimation                          { get; set; }

        public static LiveMusicSelectionRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionRateView() { Pointer= p0 };

            value.HighScoreRateView                         = GetObject<MusicRateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicRateView.FromPointer); // 0x20 HighScoreRateView           ( ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.TechnicalScoreRateView                    = GetObject<MusicRateView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRateView.FromPointer); // 0x28 TechnicalScoreRateView      ( ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.SwitchRateViewButton                      = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 SwitchRateViewButton        ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SwitchRateViewIcon                        = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 SwitchRateViewIcon          ( ModelClassType Image Image Image Pointer )
            value.SwitchRateViewSprites                     = GetObjectList<Sprite>(new IntPtr(p + 0x040), ReversePrism.DataModels.Sprite.FromPointer); // 0x40 SwitchRateViewSprites       ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x048), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0x48 SlideAnimation              ( ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )

            return value;
        }
    }
}
