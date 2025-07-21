using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectProduceStrategyRewardArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectionSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 018 SelectionSupportSkill                    ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer
    public partial class SelectProduceStrategyRewardArgs : DataModel
    {
        public SelectionSupportSkillStatus?             SelectionSupportSkill                   { get; set; }

        public static SelectProduceStrategyRewardArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectProduceStrategyRewardArgs() { Pointer= p0 };

            value.SelectionSupportSkill                     = GetObject<SelectionSupportSkillStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelectionSupportSkillStatus.FromPointer); // 0x18 SelectionSupportSkill       ( ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer )

            return value;
        }
    }
}
