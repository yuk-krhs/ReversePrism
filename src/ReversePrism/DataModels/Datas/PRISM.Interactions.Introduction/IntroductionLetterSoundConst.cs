using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <OpenLetterBgm>k__BackingField           SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 OpenLetterSe                             000186536970 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class IntroductionLetterSoundConst : DataModel
    {
        public SoundKey                                 OpenLetterSe                            { get; set; }

        public static IntroductionLetterSoundConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionLetterSoundConst() { Pointer= p0 };

            value.OpenLetterSe                              = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 02466BCDB418 0x10 OpenLetterSe                ( 000186536970 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
