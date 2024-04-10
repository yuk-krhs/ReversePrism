using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GettablePotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PotentialSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 018 PotentialSupportSkill                    0001866DBF40 ModelClassType InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus Pointer
    public partial class GettablePotentialSupportSkillStatus : DataModel
    {
        public InProducePotentialSupportSkillStatus?    PotentialSupportSkill                   { get; set; }

        public static GettablePotentialSupportSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GettablePotentialSupportSkillStatus() { Pointer= p0 };

            value.PotentialSupportSkill                     = GetObject<InProducePotentialSupportSkillStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.InProducePotentialSupportSkillStatus.FromPointer); // 024661054398 0x18 PotentialSupportSkill       ( 0001866DBF40 ModelClassType InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus Pointer )

            return value;
        }
    }
}
