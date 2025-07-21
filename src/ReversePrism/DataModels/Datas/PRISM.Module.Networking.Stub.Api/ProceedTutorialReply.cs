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
    // 018 Tutorial                                 ModelClassType TutorialStatus TutorialStatus TutorialStatus Pointer
    // 000 UserFieldNumber                          int IL2CPP_TYPE_I4
    // 020 User                                     ModelClassType SelfStatus SelfStatus SelfStatus Pointer
    public partial class ProceedTutorialReply : DataModel
    {
        public TutorialStatus?                          Tutorial                                { get; set; }
        public SelfStatus?                              User                                    { get; set; }

        public static ProceedTutorialReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProceedTutorialReply() { Pointer= p0 };

            value.Tutorial                                  = GetObject<TutorialStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.TutorialStatus.FromPointer); // 0x18 Tutorial                    ( ModelClassType TutorialStatus TutorialStatus TutorialStatus Pointer )
            value.User                                      = GetObject<SelfStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelfStatus.FromPointer); // 0x20 User                        ( ModelClassType SelfStatus SelfStatus SelfStatus Pointer )

            return value;
        }
    }
}
