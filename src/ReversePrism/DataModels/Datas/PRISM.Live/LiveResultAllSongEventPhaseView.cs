using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BackgroundImage                          ModelClassType Image Image Image Pointer
    // 068 IdolViews                                ModelClassListType LiveResultAllSongEventIdolView[] LiveResultAllSongEventIdolView[] List<LiveResultAllSongEventIdolView> Pointer
    // 070 HowToPlayButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 078 HowToPlayPopupOpener                     ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer
    // 080 EventButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class LiveResultAllSongEventPhaseView : DataModel
    {
        public Image?                                   BackgroundImage                         { get; set; }
        public List<LiveResultAllSongEventIdolView>?    IdolViews                               { get; set; }
        public UIButton?                                HowToPlayButton                         { get; set; }
        public HowToPlayPopupOpener?                    HowToPlayPopupOpener                    { get; set; }
        public ButtonBase?                              EventButton                             { get; set; }

        public static LiveResultAllSongEventPhaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultAllSongEventPhaseView() { Pointer= p0 };

            value.BackgroundImage                           = GetObject<Image>(new IntPtr(p + 0x060), ReversePrism.DataModels.Image.FromPointer); // 0x60 BackgroundImage             ( ModelClassType Image Image Image Pointer )
            value.IdolViews                                 = GetObjectList<LiveResultAllSongEventIdolView>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultAllSongEventIdolView.FromPointer); // 0x68 IdolViews                   ( ModelClassListType LiveResultAllSongEventIdolView[] LiveResultAllSongEventIdolView[] List<LiveResultAllSongEventIdolView> Pointer )
            value.HowToPlayButton                           = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 HowToPlayButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HowToPlayPopupOpener                      = GetObject<HowToPlayPopupOpener>(new IntPtr(p + 0x078), ReversePrism.DataModels.HowToPlayPopupOpener.FromPointer); // 0x78 HowToPlayPopupOpener        ( ModelClassType HowToPlayPopupOpener HowToPlayPopupOpener HowToPlayPopupOpener Pointer )
            value.EventButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x80 EventButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
