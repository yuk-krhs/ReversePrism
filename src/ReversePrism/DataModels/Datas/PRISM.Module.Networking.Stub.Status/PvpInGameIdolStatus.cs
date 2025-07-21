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
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 01C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Parameter                                ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 IdolSkillFieldNumber                     int IL2CPP_TYPE_I4
    // 028 IdolSkill                                ModelClassType PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus Pointer
    // 000 IdolBaseParameterFieldNumber             int IL2CPP_TYPE_I4
    // 030 IdolBaseParameter                        ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    public partial class PvpInGameIdolStatus : DataModel
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
            var value   = new PvpInGameIdolStatus() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x20 Parameter                   ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.IdolSkill                                 = GetObject<PvpInGameIdolSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpInGameIdolSkillStatus.FromPointer); // 0x28 IdolSkill                   ( ModelClassType PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus PvpInGameIdolSkillStatus Pointer )
            value.IdolBaseParameter                         = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x30 IdolBaseParameter           ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )

            return value;
        }
    }
}
