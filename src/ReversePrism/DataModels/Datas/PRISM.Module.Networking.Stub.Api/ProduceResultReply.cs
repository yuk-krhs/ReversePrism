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
    // 018 ProduceBaseInfo                          0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 020 FesUnit                                  00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer
    // 000 TotalParameterValueFieldNumber           int IL2CPP_TYPE_I4
    // 028 TotalParameterValue                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterVariationFieldNumber            int IL2CPP_TYPE_I4
    // 030 ParameterVariation                       00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 038 RewardList                               000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 CsidListFieldNumber                      int IL2CPP_TYPE_I4
    // 010 _repeated_csidList_codec                 FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 040 CsidList                                 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 IsArEffectFieldNumber                    int IL2CPP_TYPE_I4
    // 048 IsArEffect                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 EpisodeDifficultyClearCountFieldNumber   int IL2CPP_TYPE_I4
    // 04C EpisodeDifficultyClearCount              0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.ProduceBaseInfo                           = GetObject<ProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseInfoStatus.FromPointer); // 02466255A308 0x18 ProduceBaseInfo             ( 0001865332D0 ModelClassType ProduceBaseInfoStatus ProduceBaseInfoStatus ProduceBaseInfoStatus Pointer )
            value.FesUnit                                   = GetObject<FesUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.FesUnitStatus.FromPointer); // 02466255A348 0x20 FesUnit                     ( 00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer )
            value.TotalParameterValue                       = GetInt32(new IntPtr(p + 0x028)); // 02466255A388 0x28 TotalParameterValue         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParameterVariation                        = GetObject<ParameterVariationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParameterVariationStatus.FromPointer); // 02466255A3C8 0x30 ParameterVariation          ( 00018671DE80 ModelClassType ParameterVariationStatus ParameterVariationStatus ParameterVariationStatus Pointer )
            value.RewardList                                = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 02466255A428 0x38 RewardList                  ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.CsidList                                  = GetStringList(new IntPtr(p + 0x040)); // 02466255A488 0x40 CsidList                    ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.IsArEffect                                = GetBool(new IntPtr(p + 0x048)); // 02466255A4C8 0x48 IsArEffect                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EpisodeDifficultyClearCount               = GetInt32(new IntPtr(p + 0x04C)); // 02466255A508 0x4C EpisodeDifficultyClearCount ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
