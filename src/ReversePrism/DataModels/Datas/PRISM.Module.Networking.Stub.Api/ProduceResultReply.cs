using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceResultReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceBaseInfoFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceBaseInfo                          ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 020 FesUnit                                  ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer
    // 000 TotalParameterValueFieldNumber           int IL2CPP_TYPE_I4
    // 028 TotalParameterValue                      ModelPrimitiveType int int int Int32
    // 000 ParameterVariationFieldNumber            int IL2CPP_TYPE_I4
    // 030 ParameterVariation                       ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 038 RewardList                               ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 CsidListFieldNumber                      int IL2CPP_TYPE_I4
    // 010 _repeated_csidList_codec                 FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 040 CsidList                                 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 IsArEffectFieldNumber                    int IL2CPP_TYPE_I4
    // 048 IsArEffect                               ModelPrimitiveType bool bool bool Bool
    // 000 EpisodeDifficultyClearCountFieldNumber   int IL2CPP_TYPE_I4
    // 04C EpisodeDifficultyClearCount              ModelPrimitiveType int int int Int32
    public partial class ProduceResultReply : DataModel
    {
        public ProduceBaseInfoStatus?                   ProduceBaseInfo                         { get; set; }
        public FesUnitStatus?                           FesUnit                                 { get; set; }
        public int                                      TotalParameterValue                     { get; set; }
        public ParameterVariationStatus?                ParameterVariation                      { get; set; }
        public List<ProductWithAmountStatus>?           RewardList                              { get; set; }
        public List<string>?                            CsidList                                { get; set; }
        public bool                                     IsArEffect                              { get; set; }
        public int                                      EpisodeDifficultyClearCount             { get; set; }

        public static ProduceResultReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultReply() { Pointer= p0 };

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.FesUnit                                   = GetObject<FesUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.FesUnitStatus.FromPointer); // 0x20 FesUnit                     ( ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer )
            value.TotalParameterValue                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 TotalParameterValue         ( ModelPrimitiveType int int int Int32 )
            value.ParameterVariation                        = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 0x30 ParameterVariation          ( ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x38 RewardList                  ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.CsidList                                  = GetStringList(new IntPtr(p + 0x040)); // 0x40 CsidList                    ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.IsArEffect                                = GetBool(new IntPtr(p + 0x048)); // 0x48 IsArEffect                  ( ModelPrimitiveType bool bool bool Bool )
            value.EpisodeDifficultyClearCount               = GetInt32(new IntPtr(p + 0x04C)); // 0x4C EpisodeDifficultyClearCount ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
