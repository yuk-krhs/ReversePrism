using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RivalSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstRivalSkillIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 MstRivalSkillId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InGameSkillFieldNumber                   int IL2CPP_TYPE_I4
    // 020 InGameSkill                              0001866DA480 ModelClassType InGameSkillStatus InGameSkillStatus InGameSkillStatus Pointer
    public partial class RivalSkillStatus
    {
        public int                                      MstRivalSkillId                         { get; set; }
        public InGameSkillStatus?                       InGameSkill                             { get; set; }

        public static RivalSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RivalSkillStatus();

            value.MstRivalSkillId                           = GetInt32(new IntPtr(p + 0x018)); // 0270D1131BD0 0x18 MstRivalSkillId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InGameSkill                               = GetObject<InGameSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameSkillStatus.FromPointer); // 0270D1131C10 0x20 InGameSkill                 ( 0001866DA480 ModelClassType InGameSkillStatus InGameSkillStatus InGameSkillStatus Pointer )

            return value;
        }
    }
}
