using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProceedTutorialReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TutorialFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Tutorial                                 0001866BDDF0 ModelClassType TutorialStatus TutorialStatus TutorialStatus Pointer
    // 000 UserFieldNumber                          int IL2CPP_TYPE_I4
    // 020 User                                     000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer
    public partial class ProceedTutorialReply
    {
        public TutorialStatus?                          Tutorial                                { get; set; }
        public SelfStatus?                              User                                    { get; set; }

        public static ProceedTutorialReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProceedTutorialReply();

            value.Tutorial                                  = GetObject<TutorialStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.TutorialStatus.FromPointer); // 0270D2C509F8 0x18 Tutorial                    ( 0001866BDDF0 ModelClassType TutorialStatus TutorialStatus TutorialStatus Pointer )
            value.User                                      = GetObject<SelfStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelfStatus.FromPointer); // 0270D2C50A38 0x20 User                        ( 000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer )

            return value;
        }
    }
}
