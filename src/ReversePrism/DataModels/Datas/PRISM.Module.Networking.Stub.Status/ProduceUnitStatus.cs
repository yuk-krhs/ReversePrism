using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceIdolList_codec          FieldCodec`1<InProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProduceIdolList                          000185CE0B08 ModelClassListType RepeatedField`1<InProduceIdolStatus> RepeatedField`1<InProduceIdolStatus> List<InProduceIdolStatus> Pointer
    // 000 VitalityFieldNumber                      int IL2CPP_TYPE_I4
    // 020 Vitality                                 00018652EBF0 ModelClassType VitalityStatus VitalityStatus VitalityStatus Pointer
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 SupportSkillFieldNumber                  int IL2CPP_TYPE_I4
    // 030 SupportSkill                             0001865F7560 ModelClassType SupportSkillStatus SupportSkillStatus SupportSkillStatus Pointer
    public partial class ProduceUnitStatus : DataModel
    {
        public List<InProduceIdolStatus>?               ProduceIdolList                         { get; set; }
        public VitalityStatus?                          Vitality                                { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public SupportSkillStatus?                      SupportSkill                            { get; set; }

        public static ProduceUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitStatus() { Pointer= p0 };

            value.ProduceIdolList                           = GetObjectList<InProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.InProduceIdolStatus.FromPointer); // 0246610A3B20 0x18 ProduceIdolList             ( 000185CE0B08 ModelClassListType RepeatedField`1<InProduceIdolStatus> RepeatedField`1<InProduceIdolStatus> List<InProduceIdolStatus> Pointer )
            value.Vitality                                  = GetObject<VitalityStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.VitalityStatus.FromPointer); // 0246610A3B60 0x20 Vitality                    ( 00018652EBF0 ModelClassType VitalityStatus VitalityStatus VitalityStatus Pointer )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0246610A3BA0 0x28 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.SupportSkill                              = GetObject<SupportSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportSkillStatus.FromPointer); // 0246610A3BE0 0x30 SupportSkill                ( 0001865F7560 ModelClassType SupportSkillStatus SupportSkillStatus SupportSkillStatus Pointer )

            return value;
        }
    }
}
