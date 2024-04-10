using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishTutorialReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserFieldNumber                          int IL2CPP_TYPE_I4
    // 018 User                                     000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer
    public partial class FinishTutorialReply : DataModel
    {
        public SelfStatus?                              User                                    { get; set; }

        public static FinishTutorialReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishTutorialReply() { Pointer= p0 };

            value.User                                      = GetObject<SelfStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelfStatus.FromPointer); // 024662BDC158 0x18 User                        ( 000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer )

            return value;
        }
    }
}
