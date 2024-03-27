using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018668E5D0 ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer
    // 018 Option                                   000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 020 needPlayNoteLineEffectDic                Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    public partial class RhythmGameObjectRenderService
    {
        public RhythmGameView?                          View                                    { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }

        public static RhythmGameObjectRenderService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameObjectRenderService();

            value.View                                      = GetObject<RhythmGameView>(new IntPtr(p + 0x010), ReversePrism.DataModels.RhythmGameView.FromPointer); // 0270D500AB68 0x10 View                        ( 00018668E5D0 ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x018), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0270D500AB88 0x18 Option                      ( 000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )

            return value;
        }
    }
}
