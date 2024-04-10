using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Confidence                               0001865FB510 ModelEnumType ConfidenceLevel ConfidenceLevel ConfidenceLevel Int32
    // 018 SemanticMeanings                         000185CA36D8 ModelEnumListType SemanticMeaning[] SemanticMeaning[] List<SemanticMeaning> Pointer
    // 020 Text                                     0001866736C0 ModelPrimitiveType string string string String
    // 028 PhraseStartTime                          0001865BA3F0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 PhraseDuration                           00018668B770 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class PhraseRecognizedEventArgs : DataModel
    {
        public ConfidenceLevel                          Confidence                              { get; set; }
        public List<SemanticMeaning>?                   SemanticMeanings                        { get; set; }
        public string                                   Text                                    { get; set; }
        public DateTime                                 PhraseStartTime                         { get; set; }
        public TimeSpan                                 PhraseDuration                          { get; set; }

        public static PhraseRecognizedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhraseRecognizedEventArgs() { Pointer= p0 };

            value.Confidence                                = (ConfidenceLevel)GetInt32(new IntPtr(p + 0x010)); // 0245A6883D00 0x10 Confidence                  ( 0001865FB510 ModelEnumType ConfidenceLevel ConfidenceLevel ConfidenceLevel Int32 )
            value.SemanticMeanings                          = GetEnumList<SemanticMeaning>(new IntPtr(p + 0x018)); // 0245A6883D20 0x18 SemanticMeanings            ( 000185CA36D8 ModelEnumListType SemanticMeaning[] SemanticMeaning[] List<SemanticMeaning> Pointer )
            value.Text                                      = GetString(new IntPtr(p + 0x020)); // 0245A6883D40 0x20 Text                        ( 0001866736C0 ModelPrimitiveType string string string String )
            value.PhraseStartTime                           = GetDateTime(new IntPtr(p + 0x028)); // 0245A6883D60 0x28 PhraseStartTime             ( 0001865BA3F0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PhraseDuration                            = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 0245A6883D80 0x30 PhraseDuration              ( 00018668B770 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}
