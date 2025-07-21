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
    // 018 IdolBase                                 ModelClassType InProduceIdolBaseStatus InProduceIdolBaseStatus InProduceIdolBaseStatus Pointer
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Parameter                                ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 IdolSkillFieldNumber                     int IL2CPP_TYPE_I4
    // 030 IdolSkill                                ModelClassType InProduceIdolSkillStatus InProduceIdolSkillStatus InProduceIdolSkillStatus Pointer
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Star                                     ModelPrimitiveType int int int Int32
    // 000 EvolutionLevelFieldNumber                int IL2CPP_TYPE_I4
    // 03C EvolutionLevel                           ModelPrimitiveType int int int Int32
    // 000 DressFieldNumber                         int IL2CPP_TYPE_I4
    // 040 Dress                                    ModelClassType DressStatus DressStatus DressStatus Pointer
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 048 InitialStar                              ModelPrimitiveType int int int Int32
    public partial class InProduceIdolStatus : DataModel
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
            var value   = new InProduceIdolStatus() { Pointer= p0 };

            value.IdolBase                                  = GetObject<InProduceIdolBaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.InProduceIdolBaseStatus.FromPointer); // 0x18 IdolBase                    ( ModelClassType InProduceIdolBaseStatus InProduceIdolBaseStatus InProduceIdolBaseStatus Pointer )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0x28 Parameter                   ( ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.IdolSkill                                 = GetObject<InProduceIdolSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.InProduceIdolSkillStatus.FromPointer); // 0x30 IdolSkill                   ( ModelClassType InProduceIdolSkillStatus InProduceIdolSkillStatus InProduceIdolSkillStatus Pointer )
            value.Star                                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 Star                        ( ModelPrimitiveType int int int Int32 )
            value.EvolutionLevel                            = GetInt32(new IntPtr(p + 0x03C)); // 0x3C EvolutionLevel              ( ModelPrimitiveType int int int Int32 )
            value.Dress                                     = GetObject<DressStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.DressStatus.FromPointer); // 0x40 Dress                       ( ModelClassType DressStatus DressStatus DressStatus Pointer )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 InitialStar                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
