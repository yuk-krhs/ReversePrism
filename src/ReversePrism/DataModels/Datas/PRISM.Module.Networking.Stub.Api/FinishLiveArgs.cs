using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishLiveArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScoreFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Score                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ComboFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Combo                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TimingJudgementFieldNumber               int IL2CPP_TYPE_I4
    // 020 TimingJudgement                          000186586D00 ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer
    // 000 BaseTimingJudgementFieldNumber           int IL2CPP_TYPE_I4
    // 028 BaseTimingJudgement                      000186586D00 ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer
    // 000 ActivatedSkillListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_activatedSkillList_codec       FieldCodec`1<LiveActivatedSkillStatus> IL2CPP_TYPE_GENERICINST
    // 030 ActivatedSkillList                       000185CE2BF8 ModelClassListType RepeatedField`1<LiveActivatedSkillStatus> RepeatedField`1<LiveActivatedSkillStatus> List<LiveActivatedSkillStatus> Pointer
    // 000 LifeFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Life                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LiveTokenFieldNumber                     int IL2CPP_TYPE_I4
    // 040 LiveToken                                000186671910 ModelPrimitiveType string string string String
    public partial class FinishLiveArgs
    {
        public int                                      Score                                   { get; set; }
        public int                                      Combo                                   { get; set; }
        public LiveTimingJudgementStatus?               TimingJudgement                         { get; set; }
        public LiveTimingJudgementStatus?               BaseTimingJudgement                     { get; set; }
        public List<LiveActivatedSkillStatus>?          ActivatedSkillList                      { get; set; }
        public int                                      Life                                    { get; set; }
        public string                                   LiveToken                               { get; set; }

        public static FinishLiveArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishLiveArgs();

            value.Score                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D21C8EE8 0x18 Score                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Combo                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D21C8F28 0x1C Combo                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TimingJudgement                           = GetObject<LiveTimingJudgementStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveTimingJudgementStatus.FromPointer); // 0270D21C8F68 0x20 TimingJudgement             ( 000186586D00 ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer )
            value.BaseTimingJudgement                       = GetObject<LiveTimingJudgementStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveTimingJudgementStatus.FromPointer); // 0270D21C8FA8 0x28 BaseTimingJudgement         ( 000186586D00 ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer )
            value.ActivatedSkillList                        = GetObjectList<LiveActivatedSkillStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveActivatedSkillStatus.FromPointer); // 0270D21C9008 0x30 ActivatedSkillList          ( 000185CE2BF8 ModelClassListType RepeatedField`1<LiveActivatedSkillStatus> RepeatedField`1<LiveActivatedSkillStatus> List<LiveActivatedSkillStatus> Pointer )
            value.Life                                      = GetInt32(new IntPtr(p + 0x038)); // 0270D21C9048 0x38 Life                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LiveToken                                 = GetString(new IntPtr(p + 0x040)); // 0270D21C9088 0x40 LiveToken                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
