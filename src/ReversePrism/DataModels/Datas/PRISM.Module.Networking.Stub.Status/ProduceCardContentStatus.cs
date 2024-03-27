using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealTypeList                           000185D18C38 ModelEnumListType IReadOnlyList`1<ProduceParameterType> IReadOnlyList`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 _parser                                  MessageParser`1<ProduceCardContentStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CardRankFieldNumber                      int IL2CPP_TYPE_I4
    // 020 CardRank                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceActionEffectListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_produceActionEffectList_codec  FieldCodec`1<ProduceActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceActionEffectList                  000185CE9EF8 ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Cost                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AppealTypeListFieldNumber                int IL2CPP_TYPE_I4
    // 010 _repeated_appealTypeList_codec           FieldCodec`1<ProduceParameterType> IL2CPP_TYPE_GENERICINST
    // 038 AppealTypeList                           000185CEC248 ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 StrengthScoreFieldNumber                 int IL2CPP_TYPE_I4
    // 040 StrengthScore                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstProduceActionConditionTypeIdFieldNumber int IL2CPP_TYPE_I4
    // 044 MstProduceActionConditionTypeId          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ConditionValueFieldNumber                int IL2CPP_TYPE_I4
    // 048 ConditionValue                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceCardContentStatus
    {
        public List<ProduceParameterType>?              AppealTypeList                          { get; set; }
        public int                                      CardRank                                { get; set; }
        public List<ProduceActionEffectStatus>?         ProduceActionEffectList                 { get; set; }
        public int                                      Cost                                    { get; set; }
        public int                                      StrengthScore                           { get; set; }
        public int                                      MstProduceActionConditionTypeId         { get; set; }
        public int                                      ConditionValue                          { get; set; }

        public static ProduceCardContentStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardContentStatus();

            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x038)); // 0270D1116F60 0x38 AppealTypeList              ( 000185CEC248 ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.CardRank                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D1116E60 0x20 CardRank                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceActionEffectList                   = GetObjectList<ProduceActionEffectStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceActionEffectStatus.FromPointer); // 0270D1116EC0 0x28 ProduceActionEffectList     ( 000185CE9EF8 ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x030)); // 0270D1116F00 0x30 Cost                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StrengthScore                             = GetInt32(new IntPtr(p + 0x040)); // 0270D1116FA0 0x40 StrengthScore               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstProduceActionConditionTypeId           = GetInt32(new IntPtr(p + 0x044)); // 0270D1116FE0 0x44 MstProduceActionConditionTypeId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x048)); // 0270D1117020 0x48 ConditionValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
