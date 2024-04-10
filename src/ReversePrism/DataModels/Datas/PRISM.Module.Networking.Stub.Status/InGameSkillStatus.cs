using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealTypeList                           000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 _parser                                  MessageParser`1<InGameSkillStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AppealTypeListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_appealTypeList_codec           FieldCodec`1<ProduceParameterType> IL2CPP_TYPE_GENERICINST
    // 020 AppealTypeList                           000185CEC248 ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Cost                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UsableCountFieldNumber                   int IL2CPP_TYPE_I4
    // 02C UsableCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceActionEffectListFieldNumber       int IL2CPP_TYPE_I4
    // 010 _repeated_produceActionEffectList_codec  FieldCodec`1<ProduceActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 030 ProduceActionEffectList                  000185CE9EF8 ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer
    // 000 ProduceActionConditionFieldNumber        int IL2CPP_TYPE_I4
    // 038 ProduceActionCondition                   000186526B70 ModelClassType ProduceActionConditionStatus ProduceActionConditionStatus ProduceActionConditionStatus Pointer
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

            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x020)); // 02466105F0D0 0x20 AppealTypeList              ( 000185CEC248 ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x028)); // 02466105F110 0x28 Cost                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UsableCount                               = GetInt32(new IntPtr(p + 0x02C)); // 02466105F150 0x2C UsableCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceActionEffectList                   = GetObjectList<ProduceActionEffectStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceActionEffectStatus.FromPointer); // 02466105F1B0 0x30 ProduceActionEffectList     ( 000185CE9EF8 ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer )
            value.ProduceActionCondition                    = GetObject<ProduceActionConditionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceActionConditionStatus.FromPointer); // 02466105F1F0 0x38 ProduceActionCondition      ( 000186526B70 ModelClassType ProduceActionConditionStatus ProduceActionConditionStatus ProduceActionConditionStatus Pointer )

            return value;
        }
    }
}
