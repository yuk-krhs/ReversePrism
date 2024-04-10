using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteIntroductionReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IntroductionListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_introductionList_codec         FieldCodec`1<IntroductionStatus> IL2CPP_TYPE_GENERICINST
    // 018 IntroductionList                         000185CE2138 ModelClassListType RepeatedField`1<IntroductionStatus> RepeatedField`1<IntroductionStatus> List<IntroductionStatus> Pointer
    public partial class ExecuteIntroductionReply : DataModel
    {
        public List<IntroductionStatus>?                IntroductionList                        { get; set; }

        public static ExecuteIntroductionReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteIntroductionReply() { Pointer= p0 };

            value.IntroductionList                          = GetObjectList<IntroductionStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionStatus.FromPointer); // 024662110218 0x18 IntroductionList            ( 000185CE2138 ModelClassListType RepeatedField`1<IntroductionStatus> RepeatedField`1<IntroductionStatus> List<IntroductionStatus> Pointer )

            return value;
        }
    }
}
