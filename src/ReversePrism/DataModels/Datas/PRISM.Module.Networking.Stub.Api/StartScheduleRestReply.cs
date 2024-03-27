using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartScheduleRestReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 VitalityVariationFieldNumber             int IL2CPP_TYPE_I4
    // 020 VitalityVariation                        00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer
    // 000 DisplayMstIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 028 DisplayMstIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ScheduleDetailTypeFieldNumber            int IL2CPP_TYPE_I4
    // 02C ScheduleDetailType                       0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstCharacterInfoIdList                   000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 ExertSupportEffectListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_exertSupportEffectList_codec   FieldCodec`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 038 ExertSupportEffectList                   000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer
    // 000 UnitParameterVariationFieldNumber        int IL2CPP_TYPE_I4
    // 040 UnitParameterVariation                   00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    public partial class StartScheduleRestReply
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public VitalityVariationStatus?                 VitalityVariation                       { get; set; }
        public int                                      DisplayMstIdolId                        { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public List<ExertSupportEffectStatus>?          ExertSupportEffectList                  { get; set; }
        public ParameterVariationStatus?                UnitParameterVariation                  { get; set; }

        public static StartScheduleRestReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartScheduleRestReply();

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0270D25BC750 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.VitalityVariation                         = GetObject<VitalityVariationStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.VitalityVariationStatus.FromPointer); // 0270D25BC790 0x20 VitalityVariation           ( 00018652F800 ModelClassType VitalityVariationStatus VitalityVariationStatus VitalityVariationStatus Pointer )
            value.DisplayMstIdolId                          = GetInt32(new IntPtr(p + 0x028)); // 0270D25BC7D0 0x28 DisplayMstIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x02C)); // 0270D25BC810 0x2C ScheduleDetailType          ( 0001866D43F0 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x030)); // 0270D25BC870 0x30 MstCharacterInfoIdList      ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.ExertSupportEffectList                    = GetObjectList<ExertSupportEffectStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExertSupportEffectStatus.FromPointer); // 0270D25BC8D0 0x38 ExertSupportEffectList      ( 000185CD6CF8 ModelClassListType RepeatedField`1<ExertSupportEffectStatus> RepeatedField`1<ExertSupportEffectStatus> List<ExertSupportEffectStatus> Pointer )
            value.UnitParameterVariation                    = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0270D25BC910 0x40 UnitParameterVariation      ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )

            return value;
        }
    }
}
