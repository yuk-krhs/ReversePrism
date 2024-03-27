using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 errorInvalidHandle                       string IL2CPP_TYPE_STRING
    // 020 handle                                   <int> IL2CPP_TYPE_I
    // 028 InputReadStream                          00018664EA10 ModelClassType CriAudioReadStream CriAudioReadStream CriAudioReadStream Pointer
    public partial class CriAtomExAuxIn
    {
        public CriAudioReadStream?                      InputReadStream                         { get; set; }

        public static CriAtomExAuxIn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExAuxIn();

            value.InputReadStream                           = GetObject<CriAudioReadStream>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAudioReadStream.FromPointer); // 0270DAC73E28 0x28 InputReadStream             ( 00018664EA10 ModelClassType CriAudioReadStream CriAudioReadStream CriAudioReadStream Pointer )

            return value;
        }
    }
}
