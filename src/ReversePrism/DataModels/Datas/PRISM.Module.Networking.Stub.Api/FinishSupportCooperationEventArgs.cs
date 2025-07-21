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
    // 018 SelectProduceCardIdList                  ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 SelectionSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 020 SelectionSupportSkill                    ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer
    // 000 SelectedSupportSkillListFieldNumber      int IL2CPP_TYPE_I4
    // 010 _repeated_selectedSupportSkillList_codec FieldCodec`1<SelectionSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 028 SelectedSupportSkillList                 ModelClassListType RepeatedField`1<SelectionSupportSkillStatus> RepeatedField`1<SelectionSupportSkillStatus> List<SelectionSupportSkillStatus> Pointer
    public partial class FinishSupportCooperationEventArgs : DataModel
    {
        public List<string>?                            SelectProduceCardIdList                 { get; set; }
        public SelectionSupportSkillStatus?             SelectionSupportSkill                   { get; set; }
        public List<SelectionSupportSkillStatus>?       SelectedSupportSkillList                { get; set; }

        public static FinishSupportCooperationEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishSupportCooperationEventArgs() { Pointer= p0 };

            value.SelectProduceCardIdList                   = GetStringList(new IntPtr(p + 0x018)); // 0x18 SelectProduceCardIdList     ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.SelectionSupportSkill                     = GetObject<SelectionSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelectionSupportSkillStatus.FromPointer); // 0x20 SelectionSupportSkill       ( ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer )
            value.SelectedSupportSkillList                  = GetObjectList<SelectionSupportSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SelectionSupportSkillStatus.FromPointer); // 0x28 SelectedSupportSkillList    ( ModelClassListType RepeatedField`1<SelectionSupportSkillStatus> RepeatedField`1<SelectionSupportSkillStatus> List<SelectionSupportSkillStatus> Pointer )

            return value;
        }
    }
}
