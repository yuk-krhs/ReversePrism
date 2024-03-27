using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishScheduleAdviceArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DeleteProduceCardIdListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_deleteProduceCardIdList_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 DeleteProduceCardIdList                  000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class FinishScheduleAdviceArgs
    {
        public List<string>?                            DeleteProduceCardIdList                 { get; set; }

        public static FinishScheduleAdviceArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishScheduleAdviceArgs();

            value.DeleteProduceCardIdList                   = GetStringList(new IntPtr(p + 0x018)); // 0270D25458E0 0x18 DeleteProduceCardIdList     ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
