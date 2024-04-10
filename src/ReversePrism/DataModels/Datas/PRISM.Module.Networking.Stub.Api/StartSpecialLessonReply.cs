using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartSpecialLessonReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 TrainerFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Trainer                                  00018669F0D0 ModelClassType TrainerStatus TrainerStatus TrainerStatus Pointer
    // 000 OpponentFieldNumber                      int IL2CPP_TYPE_I4
    // 028 Opponent                                 0001866E5AB0 ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 030 ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 ScheduleLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 034 ScheduleLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 038 VitalityVariation                        00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 040 MstCharacterInfoIdList                   000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 IsSupportBonusFieldNumber                int IL2CPP_TYPE_I4
    // 048 IsSupportBonus                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StartSpecialLessonReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public TrainerStatus?                           Trainer                                 { get; set; }
        public OpponentStatus?                          Opponent                                { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public int                                      ScheduleLevel                           { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public bool                                     IsSupportBonus                          { get; set; }

        public static StartSpecialLessonReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartSpecialLessonReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0246625A09B0 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.Trainer                                   = GetObject<TrainerStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.TrainerStatus.FromPointer); // 0246625A09F0 0x20 Trainer                     ( 00018669F0D0 ModelClassType TrainerStatus TrainerStatus TrainerStatus Pointer )
            value.Opponent                                  = GetObject<OpponentStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.OpponentStatus.FromPointer); // 0246625A0A30 0x28 Opponent                    ( 0001866E5AB0 ModelClassType OpponentStatus OpponentStatus OpponentStatus Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x030)); // 0246625A0A70 0x30 ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ScheduleLevel                             = GetInt32(new IntPtr(p + 0x034)); // 0246625A0AB0 0x34 ScheduleLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0246625A0AF0 0x38 VitalityVariation           ( 00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x040)); // 0246625A0B50 0x40 MstCharacterInfoIdList      ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.IsSupportBonus                            = GetBool(new IntPtr(p + 0x048)); // 0246625A0B90 0x48 IsSupportBonus              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
