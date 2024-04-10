using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TrainerStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstLessonTrainerIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstLessonTrainerId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceCardDeckFieldNumber               int IL2CPP_TYPE_I4
    // 020 ProduceCardDeck                          000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Parameter                                0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 RivalSkillFieldNumber                    int IL2CPP_TYPE_I4
    // 030 RivalSkill                               0001866909F0 ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer
    // 000 AppealCorrectionFieldNumber              int IL2CPP_TYPE_I4
    // 038 AppealCorrection                         0001866CC8F0 ModelClassType AppealCorrectionStatus AppealCorrectionStatus AppealCorrectionStatus Pointer
    // 000 IconIdFieldNumber                        int IL2CPP_TYPE_I4
    // 040 IconId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TrainerStatus : DataModel
    {
        public int                                      MstLessonTrainerId                      { get; set; }
        public ProduceCardDeckStatus?                   ProduceCardDeck                         { get; set; }
        public ProduceParameterStatus?                  Parameter                               { get; set; }
        public RivalSkillStatus?                        RivalSkill                              { get; set; }
        public AppealCorrectionStatus?                  AppealCorrection                        { get; set; }
        public int                                      IconId                                  { get; set; }

        public static TrainerStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrainerStatus() { Pointer= p0 };

            value.MstLessonTrainerId                        = GetInt32(new IntPtr(p + 0x018)); // 0246610C8860 0x18 MstLessonTrainerId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceCardDeck                           = GetObject<ProduceCardDeckStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardDeckStatus.FromPointer); // 0246610C88A0 0x20 ProduceCardDeck             ( 000186536800 ModelClassType ProduceCardDeckStatus ProduceCardDeckStatus ProduceCardDeckStatus Pointer )
            value.Parameter                                 = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 0246610C88E0 0x28 Parameter                   ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.RivalSkill                                = GetObject<RivalSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.RivalSkillStatus.FromPointer); // 0246610C8920 0x30 RivalSkill                  ( 0001866909F0 ModelClassType RivalSkillStatus RivalSkillStatus RivalSkillStatus Pointer )
            value.AppealCorrection                          = GetObject<AppealCorrectionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.AppealCorrectionStatus.FromPointer); // 0246610C8960 0x38 AppealCorrection            ( 0001866CC8F0 ModelClassType AppealCorrectionStatus AppealCorrectionStatus AppealCorrectionStatus Pointer )
            value.IconId                                    = GetInt32(new IntPtr(p + 0x040)); // 0246610C89A0 0x40 IconId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
