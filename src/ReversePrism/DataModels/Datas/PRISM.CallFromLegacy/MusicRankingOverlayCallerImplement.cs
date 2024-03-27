using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 factory                                  OverlayViewFactory`1<IMusicRankingOverlayView> IL2CPP_TYPE_GENERICINST
    // 028 Sequencer                                00018666AF00 ModelClassType MusicRankingOverlaySequencer MusicRankingOverlaySequencer MusicRankingOverlaySequencer Pointer
    public partial class MusicRankingOverlayCallerImplement
    {
        public MusicRankingOverlaySequencer?            Sequencer                               { get; set; }

        public static MusicRankingOverlayCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingOverlayCallerImplement();

            value.Sequencer                                 = GetObject<MusicRankingOverlaySequencer>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicRankingOverlaySequencer.FromPointer); // 0270DB9D2688 0x28 Sequencer                   ( 00018666AF00 ModelClassType MusicRankingOverlaySequencer MusicRankingOverlaySequencer MusicRankingOverlaySequencer Pointer )

            return value;
        }
    }
}
