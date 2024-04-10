using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProceedTutorialArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TutorialFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Tutorial                                 0001866BDDF0 ModelClassType TutorialStatus TutorialStatus TutorialStatus Pointer
    // 000 IsSkipFieldNumber                        int IL2CPP_TYPE_I4
    // 020 IsSkip                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProceedTutorialArgs : DataModel
    {
        public TutorialStatus?                          Tutorial                                { get; set; }
        public bool                                     IsSkip                                  { get; set; }

        public static ProceedTutorialArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProceedTutorialArgs() { Pointer= p0 };

            value.Tutorial                                  = GetObject<TutorialStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.TutorialStatus.FromPointer); // 024662BDE6B0 0x18 Tutorial                    ( 0001866BDDF0 ModelClassType TutorialStatus TutorialStatus TutorialStatus Pointer )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x020)); // 024662BDE6F0 0x20 IsSkip                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
