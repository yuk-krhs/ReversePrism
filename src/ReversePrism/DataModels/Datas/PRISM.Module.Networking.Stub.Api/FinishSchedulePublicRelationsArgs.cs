using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishSchedulePublicRelationsArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectProduceCardIdListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_selectProduceCardIdList_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 SelectProduceCardIdList                  ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class FinishSchedulePublicRelationsArgs : DataModel
    {
        public List<string>?                            SelectProduceCardIdList                 { get; set; }

        public static FinishSchedulePublicRelationsArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishSchedulePublicRelationsArgs() { Pointer= p0 };

            value.SelectProduceCardIdList                   = GetStringList(new IntPtr(p + 0x018)); // 0x18 SelectProduceCardIdList     ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
