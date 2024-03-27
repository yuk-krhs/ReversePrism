using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpInGameIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 01C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 IdolSkillFieldNumber                     int IL2CPP_TYPE_I4
    // 028 IdolSkill                                0001865E50C0 ModelClassType PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus Pointer
    // 000 IdolBaseParameterFieldNumber             int IL2CPP_TYPE_I4
    // 030 IdolBaseParameter                        0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    public partial class PvpInGameIdolStatus
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public PvpInGameIdolSkillStatus?                IdolSkill                               { get; set; }
        public ProduceParameterStatus?                  IdolBaseParameter                       { get; set; }

        public static PvpInGameIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpInGameIdolStatus();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D1421598 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D14215D8 0x1C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0270D1421618 0x20 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.IdolSkill                                 = GetObject<PvpInGameIdolSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpInGameIdolSkillStatus.FromPointer); // 0270D1421658 0x28 IdolSkill                   ( 0001865E50C0 ModelClassType PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus Pointer )
            value.IdolBaseParameter                         = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0270D1421698 0x30 IdolBaseParameter           ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )

            return value;
        }
    }
}
