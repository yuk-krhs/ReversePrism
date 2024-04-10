using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 SelectedMusicView                        000186667C70 ModelClassType MusicListSelectedMusicView MusicListSelectedMusicView MusicListSelectedMusicView Pointer
    // 090 SlideAnimation                           00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer
    public partial class MusicListCarousel : DataModel
    {
        public MusicListSelectedMusicView?              SelectedMusicView                       { get; set; }
        public SimpleSlideAnimation?                    SlideAnimation                          { get; set; }

        public static MusicListCarousel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListCarousel() { Pointer= p0 };

            value.SelectedMusicView                         = GetObject<MusicListSelectedMusicView>(new IntPtr(p + 0x088), ReversePrism.DataModels.MusicListSelectedMusicView.FromPointer); // 0246651E50A8 0x88 SelectedMusicView           ( 000186667C70 ModelClassType MusicListSelectedMusicView MusicListSelectedMusicView MusicListSelectedMusicView Pointer )
            value.SlideAnimation                            = GetObject<SimpleSlideAnimation>(new IntPtr(p + 0x090), ReversePrism.DataModels.SimpleSlideAnimation.FromPointer); // 0246651E50C8 0x90 SlideAnimation              ( 00018650BB70 ModelClassType SimpleSlideAnimation SimpleSlideAnimation SimpleSlideAnimation Pointer )

            return value;
        }
    }
}
