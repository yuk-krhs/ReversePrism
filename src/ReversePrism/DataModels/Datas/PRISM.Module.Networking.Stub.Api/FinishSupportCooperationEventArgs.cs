using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishSupportCooperationEventArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectProduceCardIdListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_selectProduceCardIdList_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 SelectProduceCardIdList                  000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 SelectionSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 020 SelectionSupportSkill                    000186720D60 ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer
    public partial class FinishSupportCooperationEventArgs : DataModel
    {
        public List<string>?                            SelectProduceCardIdList                 { get; set; }
        public SelectionSupportSkillStatus?             SelectionSupportSkill                   { get; set; }

        public static FinishSupportCooperationEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishSupportCooperationEventArgs() { Pointer= p0 };

            value.SelectProduceCardIdList                   = GetStringList(new IntPtr(p + 0x018)); // 024662533FB8 0x18 SelectProduceCardIdList     ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.SelectionSupportSkill                     = GetObject<SelectionSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelectionSupportSkillStatus.FromPointer); // 024662533FF8 0x20 SelectionSupportSkill       ( 000186720D60 ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer )

            return value;
        }
    }
}
