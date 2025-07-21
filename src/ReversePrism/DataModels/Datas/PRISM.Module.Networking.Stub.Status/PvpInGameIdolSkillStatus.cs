using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpInGameIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolSkillIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstIdolSkillId                           ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Level                                    ModelPrimitiveType int int int Int32
    // 000 InGameSkillFieldNumber                   int IL2CPP_TYPE_I4
    // 020 InGameSkill                              ModelClassType InGameSkillStatus InGameSkillStatus InGameSkillStatus Pointer
    // 000 StrengthScoreFieldNumber                 int IL2CPP_TYPE_I4
    // 028 StrengthScore                            ModelPrimitiveType int int int Int32
    public partial class PvpInGameIdolSkillStatus : DataModel
    {
        public int                                      MstIdolSkillId                          { get; set; }
        public int                                      Level                                   { get; set; }
        public InGameSkillStatus?                       InGameSkill                             { get; set; }
        public int                                      StrengthScore                           { get; set; }

        public static PvpInGameIdolSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameIdolSkillStatus() { Pointer= p0 };

            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolSkillId              ( ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Level                       ( ModelPrimitiveType int int int Int32 )
            value.InGameSkill                               = GetObject<InGameSkillStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGameSkillStatus.FromPointer); // 0x20 InGameSkill                 ( ModelClassType InGameSkillStatus InGameSkillStatus InGameSkillStatus Pointer )
            value.StrengthScore                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 StrengthScore               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
