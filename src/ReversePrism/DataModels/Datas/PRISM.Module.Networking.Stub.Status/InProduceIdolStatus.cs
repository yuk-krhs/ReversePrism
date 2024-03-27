using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdolBaseFieldNumber                      int IL2CPP_TYPE_I4
    // 018 IdolBase                                 0001866DABD0 ModelClassType InProduceIdolBaseStatus InProduceIdolBaseStatus InProduceIdolBaseStatus Pointer
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 IdolSkillFieldNumber                     int IL2CPP_TYPE_I4
    // 030 IdolSkill                                0001866DB320 ModelClassType InProduceIdolSkillStatus InProduceIdolSkillStatus InProduceIdolSkillStatus Pointer
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EvolutionLevelFieldNumber                int IL2CPP_TYPE_I4
    // 03C EvolutionLevel                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DressFieldNumber                         int IL2CPP_TYPE_I4
    // 040 Dress                                    0001866FC540 ModelClassType DressStatus DressStatus DressStatus Pointer
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 048 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class InProduceIdolStatus
    {
        public InProduceIdolBaseStatus?                 IdolBase                                { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public InProduceIdolSkillStatus?                IdolSkill                               { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      EvolutionLevel                          { get; set; }
        public DressStatus?                             Dress                                   { get; set; }
        public int                                      InitialStar                             { get; set; }

        public static InProduceIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceIdolStatus();

            value.IdolBase                                  = GetObject<InProduceIdolBaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.InProduceIdolBaseStatus.FromPointer); // 0270D10D8028 0x18 IdolBase                    ( 0001866DABD0 ModelClassType InProduceIdolBaseStatus InProduceIdolBaseStatus InProduceIdolBaseStatus Pointer )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0270D10D8068 0x20 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0270D10D80A8 0x28 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.IdolSkill                                 = GetObject<InProduceIdolSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.InProduceIdolSkillStatus.FromPointer); // 0270D10D80E8 0x30 IdolSkill                   ( 0001866DB320 ModelClassType InProduceIdolSkillStatus InProduceIdolSkillStatus InProduceIdolSkillStatus Pointer )
            value.Star                                      = GetInt32(new IntPtr(p + 0x038)); // 0270D10D8128 0x38 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EvolutionLevel                            = GetInt32(new IntPtr(p + 0x03C)); // 0270D10D8168 0x3C EvolutionLevel              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Dress                                     = GetObject<DressStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.DressStatus.FromPointer); // 0270D10D81A8 0x40 Dress                       ( 0001866FC540 ModelClassType DressStatus DressStatus DressStatus Pointer )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x048)); // 0270D10D81E8 0x48 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
