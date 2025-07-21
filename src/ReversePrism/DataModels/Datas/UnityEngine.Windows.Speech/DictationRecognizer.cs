using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Recognizer                             <int> IL2CPP_TYPE_I
    // 018 DictationHypothesis                      ModelClassType DictationHypothesisDelegate DictationHypothesisDelegate DictationHypothesisDelegate Pointer
    // 020 DictationResult                          ModelClassType DictationResultDelegate DictationResultDelegate DictationResultDelegate Pointer
    // 028 DictationComplete                        ModelClassType DictationCompletedDelegate DictationCompletedDelegate DictationCompletedDelegate Pointer
    // 030 DictationError                           ModelClassType DictationErrorHandler DictationErrorHandler DictationErrorHandler Pointer
    public partial class DictationRecognizer : DataModel
    {
        public DictationHypothesisDelegate?             DictationHypothesis                     { get; set; }
        public DictationResultDelegate?                 DictationResult                         { get; set; }
        public DictationCompletedDelegate?              DictationComplete                       { get; set; }
        public DictationErrorHandler?                   DictationError                          { get; set; }

        public static DictationRecognizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DictationRecognizer() { Pointer= p0 };

            value.DictationHypothesis                       = GetObject<DictationHypothesisDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.DictationHypothesisDelegate.FromPointer); // 0x18 DictationHypothesis         ( ModelClassType DictationHypothesisDelegate DictationHypothesisDelegate DictationHypothesisDelegate Pointer )
            value.DictationResult                           = GetObject<DictationResultDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.DictationResultDelegate.FromPointer); // 0x20 DictationResult             ( ModelClassType DictationResultDelegate DictationResultDelegate DictationResultDelegate Pointer )
            value.DictationComplete                         = GetObject<DictationCompletedDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.DictationCompletedDelegate.FromPointer); // 0x28 DictationComplete           ( ModelClassType DictationCompletedDelegate DictationCompletedDelegate DictationCompletedDelegate Pointer )
            value.DictationError                            = GetObject<DictationErrorHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.DictationErrorHandler.FromPointer); // 0x30 DictationError              ( ModelClassType DictationErrorHandler DictationErrorHandler DictationErrorHandler Pointer )

            return value;
        }
    }
}
