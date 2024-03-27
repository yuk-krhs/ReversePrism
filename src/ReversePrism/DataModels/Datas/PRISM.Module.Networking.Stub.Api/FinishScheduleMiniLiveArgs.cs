using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishScheduleMiniLiveArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectProduceCardIdListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_selectProduceCardIdList_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 SelectProduceCardIdList                  000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 DeleteProduceCardIdListFieldNumber       int IL2CPP_TYPE_I4
    // 010 _repeated_deleteProduceCardIdList_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 DeleteProduceCardIdList                  000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class FinishScheduleMiniLiveArgs
    {
        public List<string>?                            SelectProduceCardIdList                 { get; set; }
        public List<string>?                            DeleteProduceCardIdList                 { get; set; }

        public static FinishScheduleMiniLiveArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishScheduleMiniLiveArgs();

            value.SelectProduceCardIdList                   = GetStringList(new IntPtr(p + 0x018)); // 0270D25470F0 0x18 SelectProduceCardIdList     ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.DeleteProduceCardIdList                   = GetStringList(new IntPtr(p + 0x020)); // 0270D2547150 0x20 DeleteProduceCardIdList     ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
