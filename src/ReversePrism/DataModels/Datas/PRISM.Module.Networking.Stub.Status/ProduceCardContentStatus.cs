using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppealTypeList                           ModelEnumListType List<ProduceParameterType> List<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 _parser                                  MessageParser`1<ProduceCardContentStatus> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CardRankFieldNumber                      int IL2CPP_TYPE_I4
    // 020 CardRank                                 ModelPrimitiveType int int int Int32
    // 000 ProduceActionEffectListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_produceActionEffectList_codec  FieldCodec`1<ProduceActionEffectStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProduceActionEffectList                  ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer
    // 000 CostFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Cost                                     ModelPrimitiveType int int int Int32
    // 000 AppealTypeListFieldNumber                int IL2CPP_TYPE_I4
    // 010 _repeated_appealTypeList_codec           FieldCodec`1<ProduceParameterType> IL2CPP_TYPE_GENERICINST
    // 038 AppealTypeList                           ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 000 StrengthScoreFieldNumber                 int IL2CPP_TYPE_I4
    // 040 StrengthScore                            ModelPrimitiveType int int int Int32
    // 000 MstProduceActionConditionTypeIdFieldNumber int IL2CPP_TYPE_I4
    // 044 MstProduceActionConditionTypeId          ModelPrimitiveType int int int Int32
    // 000 ConditionValueFieldNumber                int IL2CPP_TYPE_I4
    // 048 ConditionValue                           ModelPrimitiveType int int int Int32
    public partial class ProduceCardContentStatus : DataModel
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
            var value   = new ProduceCardContentStatus() { Pointer= p0 };

            value.AppealTypeList                            = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x038)); // 0x38 AppealTypeList              ( ModelEnumListType RepeatedField`1<ProduceParameterType> RepeatedField`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.CardRank                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 CardRank                    ( ModelPrimitiveType int int int Int32 )
            value.ProduceActionEffectList                   = GetObjectList<ProduceActionEffectStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceActionEffectStatus.FromPointer); // 0x28 ProduceActionEffectList     ( ModelClassListType RepeatedField`1<ProduceActionEffectStatus> RepeatedField`1<ProduceActionEffectStatus> List<ProduceActionEffectStatus> Pointer )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x030)); // 0x30 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.StrengthScore                             = GetInt32(new IntPtr(p + 0x040)); // 0x40 StrengthScore               ( ModelPrimitiveType int int int Int32 )
            value.MstProduceActionConditionTypeId           = GetInt32(new IntPtr(p + 0x044)); // 0x44 MstProduceActionConditionTypeId ( ModelPrimitiveType int int int Int32 )
            value.ConditionValue                            = GetInt32(new IntPtr(p + 0x048)); // 0x48 ConditionValue              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
