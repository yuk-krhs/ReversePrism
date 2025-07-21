using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SupportCooperationEventStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 BuildUpParameterFieldNumber              int IL2CPP_TYPE_I4
    // 020 BuildUpParameter                         ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer
    // 000 PotentialSupportSkillFieldNumber         int IL2CPP_TYPE_I4
    // 028 PotentialSupportSkill                    ModelClassType InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus Pointer
    // 000 ProduceCardFieldNumber                   int IL2CPP_TYPE_I4
    // 030 ProduceCard                              ModelClassType ProduceCardStatus ProduceCardStatus ProduceCardStatus Pointer
    // 000 VitalityFieldNumber                      int IL2CPP_TYPE_I4
    // 038 Vitality                                 ModelPrimitiveType int int int Int32
    public partial class SupportCooperationEventStatus : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public BuildUpParameterStatus?                  BuildUpParameter                        { get; set; }
        public InProducePotentialSupportSkillStatus?    PotentialSupportSkill                   { get; set; }
        public ProduceCardStatus?                       ProduceCard                             { get; set; }
        public int                                      Vitality                                { get; set; }

        public static SupportCooperationEventStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCooperationEventStatus() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.BuildUpParameter                          = GetObject<BuildUpParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.BuildUpParameterStatus.FromPointer); // 0x20 BuildUpParameter            ( ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer )
            value.PotentialSupportSkill                     = GetObject<InProducePotentialSupportSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.InProducePotentialSupportSkillStatus.FromPointer); // 0x28 PotentialSupportSkill       ( ModelClassType InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus InProducePotentialSupportSkillStatus Pointer )
            value.ProduceCard                               = GetObject<ProduceCardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceCardStatus.FromPointer); // 0x30 ProduceCard                 ( ModelClassType ProduceCardStatus ProduceCardStatus ProduceCardStatus Pointer )
            value.Vitality                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 Vitality                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
