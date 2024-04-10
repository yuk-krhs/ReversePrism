using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Playback                                 000186648460 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 014 Volume                                   000186666050 ModelPrimitiveType float float float Single
    public partial class SoundPlayback : DataModel
    {
        public CriAtomExPlayback                        Playback                                { get; set; }
        public float                                    Volume                                  { get; set; }

        public static SoundPlayback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundPlayback() { Pointer= p0 };

            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x010)); // 0245A698D348 0x10 Playback                    ( 000186648460 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x014)); // 0245A698D368 0x14 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
