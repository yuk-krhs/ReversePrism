using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DrawDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GashaHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaHistoryIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 GashaHistoryId                           ModelPrimitiveType string string string String
    // 000 GashaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 030 GashaId                                  ModelPrimitiveType string string string String
    // 000 DrawDateFieldNumber                      int IL2CPP_TYPE_I4
    // 038 _DrawDate                                ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ProductListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_productList_codec              FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 040 ProductList                              ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_bonusProductList_codec         FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 048 BonusProductList                         ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 GaugeProductListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_gaugeProductList_codec         FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 050 GaugeProductList                         ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 DrawProductListFieldNumber               int IL2CPP_TYPE_I4
    // 020 _repeated_drawProductList_codec          FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 058 DrawProductList                          ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 060 ResourceId                               ModelPrimitiveType string string string String
    public partial class GashaHistoryStatus : DataModel
    {
        public DateTime                                 DrawDate                                { get; set; }
        public string                                   GashaHistoryId                          { get; set; }
        public string                                   GashaId                                 { get; set; }
        public Timestamp?                               _DrawDate                               { get; set; }
        public List<ProductWithAmountStatus>?           ProductList                             { get; set; }
        public List<RewardProductStatus>?               BonusProductList                        { get; set; }
        public List<RewardProductStatus>?               GaugeProductList                        { get; set; }
        public List<GashaRewardProductStatus>?          DrawProductList                         { get; set; }
        public string                                   ResourceId                              { get; set; }

        public static GashaHistoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHistoryStatus() { Pointer= p0 };

            value.DrawDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 DrawDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaHistoryId                            = GetString(new IntPtr(p + 0x028)); // 0x28 GashaHistoryId              ( ModelPrimitiveType string string string String )
            value.GashaId                                   = GetString(new IntPtr(p + 0x030)); // 0x30 GashaId                     ( ModelPrimitiveType string string string String )
            value._DrawDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _DrawDate                   ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ProductList                               = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x40 ProductList                 ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.BonusProductList                          = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0x48 BonusProductList            ( ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.GaugeProductList                          = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0x50 GaugeProductList            ( ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.DrawProductList                           = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0x58 DrawProductList             ( ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )
            value.ResourceId                                = GetString(new IntPtr(p + 0x060)); // 0x60 ResourceId                  ( ModelPrimitiveType string string string String )
            value.DrawDate                      = ToDateTime(value._DrawDate);

            return value;
        }
    }
}
