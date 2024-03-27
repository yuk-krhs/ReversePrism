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
    // 018 SelectionSupportSkill                    000186720D60 ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer
    public partial class SelectProduceStrategyRewardArgs
    {
        public SelectionSupportSkillStatus?             SelectionSupportSkill                   { get; set; }

        public static SelectProduceStrategyRewardArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectProduceStrategyRewardArgs();

            value.SelectionSupportSkill                     = GetObject<SelectionSupportSkillStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SelectionSupportSkillStatus.FromPointer); // 0270D259F6F0 0x18 SelectionSupportSkill       ( 000186720D60 ModelClassType SelectionSupportSkillStatus SelectionSupportSkillStatus SelectionSupportSkillStatus Pointer )

            return value;
        }
    }
}
