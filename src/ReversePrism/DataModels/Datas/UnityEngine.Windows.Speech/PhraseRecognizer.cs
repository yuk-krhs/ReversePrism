using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Recognizer                             <int> IL2CPP_TYPE_I
    // 018 OnPhraseRecognized                       ModelClassType PhraseRecognizedDelegate PhraseRecognizedDelegate PhraseRecognizedDelegate Pointer
    public partial class PhraseRecognizer : DataModel
    {
        public PhraseRecognizedDelegate?                OnPhraseRecognized                      { get; set; }

        public static PhraseRecognizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhraseRecognizer() { Pointer= p0 };

            value.OnPhraseRecognized                        = GetObject<PhraseRecognizedDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.PhraseRecognizedDelegate.FromPointer); // 0x18 OnPhraseRecognized          ( ModelClassType PhraseRecognizedDelegate PhraseRecognizedDelegate PhraseRecognizedDelegate Pointer )

            return value;
        }
    }
}
