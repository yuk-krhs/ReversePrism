using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Playback                                 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 014 Volume                                   ModelPrimitiveType float float float Single
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

            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x010)); // 0x10 Playback                    ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x014)); // 0x14 Volume                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
