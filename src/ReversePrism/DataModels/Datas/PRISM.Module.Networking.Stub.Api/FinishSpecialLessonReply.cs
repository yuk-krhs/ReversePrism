using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 020 UnitParameterVariation                   ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 CardRankUpCountFieldNumber               int IL2CPP_TYPE_I4
    // 028 CardRankUpCount                          ModelPrimitiveType int int int Int32
    // 000 ScheduleVariationFieldNumber             int IL2CPP_TYPE_I4
    // 030 ScheduleVariation                        ModelClassType ScheduleVariationStatus ScheduleVariationStatus ScheduleVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 038 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 AppealPointFieldNumber                   int IL2CPP_TYPE_I4
    // 03C AppealPoint                              ModelPrimitiveType int int int Int32
    // 000 OpponentFieldNumber                      int IL2CPP_TYPE_I4
    // 040 Opponent                                 ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 048 ExertSupportEffectList                   ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    public partial class FinishSpecialLessonReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }
        public int                                      CardRankUpCount                         { get; set; }
        public ScheduleVariationStatus?                 ScheduleVariation                       { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      AppealPoint                             { get; set; }
        public OpponentStatus?                          Opponent                                { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }

        public static FinishSpecialLessonReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishSpecialLessonReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x20 UnitParameterVariation      ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.CardRankUpCount                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 CardRankUpCount             ( ModelPrimitiveType int int int Int32 )
            value.ScheduleVariation                         = GetObject<ScheduleVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleVariationStatus.FromPointer); // 0x30 ScheduleVariation           ( ModelClassType ScheduleVariationStatus ScheduleVariationStatus ScheduleVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x038)); // 0x38 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.AppealPoint                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C AppealPoint                 ( ModelPrimitiveType int int int Int32 )
            value.Opponent                                  = GetObject<OpponentStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.OpponentStatus.FromPointer); // 0x40 Opponent                    ( ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0x48 ExertSupportEffectList      ( ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
