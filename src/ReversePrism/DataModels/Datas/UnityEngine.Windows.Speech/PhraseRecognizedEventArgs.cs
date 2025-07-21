using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Confidence                               ModelEnumType ConfidenceLevel ConfidenceLevel ConfidenceLevel Int32
    // 018 SemanticMeanings                         ModelEnumListType SemanticMeaning[] SemanticMeaning[] List<SemanticMeaning> Pointer
    // 020 Text                                     ModelPrimitiveType string string string String
    // 028 PhraseStartTime                          ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 030 PhraseDuration                           ModelEnumType TimeSpan TimeSpan TimeSpan Int32
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

            value.Confidence                                = (ConfidenceLevel)GetInt32(new IntPtr(p + 0x010)); // 0x10 Confidence                  ( ModelEnumType ConfidenceLevel ConfidenceLevel ConfidenceLevel Int32 )
            value.SemanticMeanings                          = GetEnumList<SemanticMeaning>(new IntPtr(p + 0x018)); // 0x18 SemanticMeanings            ( ModelEnumListType SemanticMeaning[] SemanticMeaning[] List<SemanticMeaning> Pointer )
            value.Text                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Text                        ( ModelPrimitiveType string string string String )
            value.PhraseStartTime                           = GetDateTime(new IntPtr(p + 0x028)); // 0x28 PhraseStartTime             ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PhraseDuration                            = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 0x30 PhraseDuration              ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}
