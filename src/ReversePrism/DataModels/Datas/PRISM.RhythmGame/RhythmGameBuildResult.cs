using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RhythmGameState                          00018668CDC0 ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer
    // 018 ObjectContainer                          000186684AD0 ModelClassType RhythmGameObjectContainer RhythmGameObjectContainer RhythmGameObjectContainer Pointer
    public partial class RhythmGameBuildResult
    {
        public RhythmGameState?                         RhythmGameState                         { get; set; }
        public RhythmGameObjectContainer?               ObjectContainer                         { get; set; }

        public static RhythmGameBuildResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameBuildResult();

            value.RhythmGameState                           = GetObject<RhythmGameState>(new IntPtr(p + 0x010), ReversePrism.DataModels.RhythmGameState.FromPointer); // 0270D4FB3978 0x10 RhythmGameState             ( 00018668CDC0 ModelClassType RhythmGameState RhythmGameState RhythmGameState Pointer )
            value.ObjectContainer                           = GetObject<RhythmGameObjectContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.RhythmGameObjectContainer.FromPointer); // 0270D4FB3998 0x18 ObjectContainer             ( 000186684AD0 ModelClassType RhythmGameObjectContainer RhythmGameObjectContainer RhythmGameObjectContainer Pointer )

            return value;
        }
    }
}
