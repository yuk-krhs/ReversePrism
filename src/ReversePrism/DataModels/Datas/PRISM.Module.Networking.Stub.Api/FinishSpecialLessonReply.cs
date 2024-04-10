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
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 020 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 CardRankUpCountFieldNumber               int IL2CPP_TYPE_I4
    // 028 CardRankUpCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScheduleVariationFieldNumber             int IL2CPP_TYPE_I4
    // 030 ScheduleVariation                        0001866E49B0 ModelClassType ScheduleVariationStatus ScheduleVariationStatus ScheduleVariationStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 038 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 AppealPointFieldNumber                   int IL2CPP_TYPE_I4
    // 03C AppealPoint                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OpponentFieldNumber                      int IL2CPP_TYPE_I4
    // 040 Opponent                                 0001866E5AB0 ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 048 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
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

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 024662531ED8 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 024662531F18 0x20 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.CardRankUpCount                           = GetInt32(new IntPtr(p + 0x028)); // 024662531F58 0x28 CardRankUpCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleVariation                         = GetObject<ScheduleVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleVariationStatus.FromPointer); // 024662531F98 0x30 ScheduleVariation           ( 0001866E49B0 ModelClassType ScheduleVariationStatus ScheduleVariationStatus ScheduleVariationStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x038)); // 024662531FD8 0x38 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.AppealPoint                               = GetInt32(new IntPtr(p + 0x03C)); // 024662532018 0x3C AppealPoint                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Opponent                                  = GetObject<OpponentStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.OpponentStatus.FromPointer); // 024662532058 0x40 Opponent                    ( 0001866E5AB0 ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0246625320B8 0x48 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )

            return value;
        }
    }
}
