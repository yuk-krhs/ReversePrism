using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectInheritanceSkillArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectionSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 018 SelectionSupportSkill                    ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer
    // 000 SelectedSupportSkillListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_selectedSupportSkillList_codec FieldCodec`1<SelectionSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 020 SelectedSupportSkillList                 ModelClassListType RepeatedField`1<SelectionSupportSkillStatus> RepeatedField`1<SelectionSupportSkillStatus> List<SelectionSupportSkillStatus> Pointer
    public partial class SelectInheritanceSkillArgs : DataModel
    {
        public SelectionSupportSkillStatus?             SelectionSupportSkill                   { get; set; }
        public List<SelectionSupportSkillStatus>?       SelectedSupportSkillList                { get; set; }

        public static SelectInheritanceSkillArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectInheritanceSkillArgs() { Pointer= p0 };

            value.SelectionSupportSkill                     = GetObject<SelectionSupportSkillStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelectionSupportSkillStatus.FromPointer); // 0x18 SelectionSupportSkill       ( ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer )
            value.SelectedSupportSkillList                  = GetObjectList<SelectionSupportSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelectionSupportSkillStatus.FromPointer); // 0x20 SelectedSupportSkillList    ( ModelClassListType RepeatedField`1<SelectionSupportSkillStatus> RepeatedField`1<SelectionSupportSkillStatus> List<SelectionSupportSkillStatus> Pointer )

            return value;
        }
    }
}
