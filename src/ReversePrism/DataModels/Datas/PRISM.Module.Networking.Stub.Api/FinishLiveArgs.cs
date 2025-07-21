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
    // 018 Score                                    ModelPrimitiveType int int int Int32
    // 000 ComboFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Combo                                    ModelPrimitiveType int int int Int32
    // 000 TimingJudgementFieldNumber               int IL2CPP_TYPE_I4
    // 020 TimingJudgement                          ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer
    // 000 BaseTimingJudgementFieldNumber           int IL2CPP_TYPE_I4
    // 028 BaseTimingJudgement                      ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer
    // 000 LifeFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Life                                     ModelPrimitiveType int int int Int32
    // 000 ActivatedSkillSlotListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_activatedSkillSlotList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 ActivatedSkillSlotList                   ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class FinishLiveArgs : DataModel
    {
        public int                                      Score                                   { get; set; }
        public int                                      Combo                                   { get; set; }
        public LiveTimingJudgementStatus?               TimingJudgement                         { get; set; }
        public LiveTimingJudgementStatus?               BaseTimingJudgement                     { get; set; }
        public int                                      Life                                    { get; set; }
        public List<int>?                               ActivatedSkillSlotList                  { get; set; }

        public static FinishLiveArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishLiveArgs() { Pointer= p0 };

            value.Score                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Score                       ( ModelPrimitiveType int int int Int32 )
            value.Combo                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Combo                       ( ModelPrimitiveType int int int Int32 )
            value.TimingJudgement                           = GetObject<LiveTimingJudgementStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveTimingJudgementStatus.FromPointer); // 0x20 TimingJudgement             ( ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer )
            value.BaseTimingJudgement                       = GetObject<LiveTimingJudgementStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveTimingJudgementStatus.FromPointer); // 0x28 BaseTimingJudgement         ( ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer )
            value.Life                                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 Life                        ( ModelPrimitiveType int int int Int32 )
            value.ActivatedSkillSlotList                    = GetInt32List(new IntPtr(p + 0x038)); // 0x38 ActivatedSkillSlotList      ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
