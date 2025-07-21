using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealTypeList                           ModelEnumListType List<ProduceParameterType> List<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 _parser                                  MessageParser`1<InGameSkillStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AppealTypeListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_appealTypeList_codec           FieldCodec`1<ProduceParameterType> IL2CPP_TYPE_GENERICINST
    // 020 AppealTypeList                           ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Cost                                     ModelPrimitiveType int int int Int32
    // 000 UsableCountFieldNumber                   int IL2CPP_TYPE_I4
    // 02C UsableCount                              ModelPrimitiveType int int int Int32
    // 000 ProduceActionEffectListFieldNumber       int IL2CPP_TYPE_I4
    // 010 _repeated_produceActionEffectList_codec  FieldCodec`1<ProduceActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 030 ProduceActionEffectList                  ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer
    // 000 ProduceActionConditionFieldNumber        int IL2CPP_TYPE_I4
    // 038 ProduceActionCondition                   ModelClassType ProduceActionConditionStatus ProduceActionConditionStatus ProduceActionConditionStatus Pointer
    public partial class InGameSkillStatus : DataModel
    {
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }
        public int                                      Cost                                    { get; set; }
        public int                                      UsableCount                             { get; set; }
        public List<ProduceActionEffectStatus>?         ProduceActionEffectList                 { get; set; }
        public ProduceActionConditionStatus?            ProduceActionCondition                  { get; set; }

        public static InGameSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameSkillStatus() { Pointer= p0 };

            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x020)); // 0x20 AppealTypeList              ( ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.UsableCount                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C UsableCount                 ( ModelPrimitiveType int int int Int32 )
            value.ProduceActionEffectList                   = GetObjectList<ProduceActionEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceActionEffectStatus.FromPointer); // 0x30 ProduceActionEffectList     ( ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer )
            value.ProduceActionCondition                    = GetObject<ProduceActionConditionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceActionConditionStatus.FromPointer); // 0x38 ProduceActionCondition      ( ModelClassType ProduceActionConditionStatus ProduceActionConditionStatus ProduceActionConditionStatus Pointer )

            return value;
        }
    }
}
