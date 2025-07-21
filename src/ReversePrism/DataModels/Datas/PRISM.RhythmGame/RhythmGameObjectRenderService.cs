using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer
    // 018 Option                                   ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 020 needPlayNoteLineEffectDic                Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 028 NoteLineContext                          ModelClassType Context Context Context Pointer
    public partial class RhythmGameObjectRenderService : DataModel
    {
        public RhythmGameView?                          View                                    { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public Context?                                 NoteLineContext                         { get; set; }

        public static RhythmGameObjectRenderService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameObjectRenderService() { Pointer= p0 };

            value.View                                      = GetObject<RhythmGameView>(new IntPtr(p + 0x010), ReversePrism.DataModels.RhythmGameView.FromPointer); // 0x10 View                        ( ModelClassType RhythmGameView RhythmGameView RhythmGameView Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x018), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0x18 Option                      ( ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.NoteLineContext                           = GetObject<Context>(new IntPtr(p + 0x028), ReversePrism.DataModels.Context.FromPointer); // 0x28 NoteLineContext             ( ModelClassType Context Context Context Pointer )

            return value;
        }
    }
}
