using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishScheduleTalkShowArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectProduceCardIdListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_selectProduceCardIdList_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 SelectProduceCardIdList                  ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 DeleteProduceCardIdListFieldNumber       int IL2CPP_TYPE_I4
    // 010 _repeated_deleteProduceCardIdList_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 DeleteProduceCardIdList                  ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class FinishScheduleTalkShowArgs : DataModel
    {
        public List<string>?                            SelectProduceCardIdList                 { get; set; }
        public List<string>?                            DeleteProduceCardIdList                 { get; set; }

        public static FinishScheduleTalkShowArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishScheduleTalkShowArgs() { Pointer= p0 };

            value.SelectProduceCardIdList                   = GetStringList(new IntPtr(p + 0x018)); // 0x18 SelectProduceCardIdList     ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.DeleteProduceCardIdList                   = GetStringList(new IntPtr(p + 0x020)); // 0x20 DeleteProduceCardIdList     ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
