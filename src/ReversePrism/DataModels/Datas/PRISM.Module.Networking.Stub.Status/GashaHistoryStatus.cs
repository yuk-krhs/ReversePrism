using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DrawDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GashaHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaHistoryIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 GashaHistoryId                           000186671910 ModelPrimitiveType string string string String
    // 000 GashaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 030 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 000 DrawDateFieldNumber                      int IL2CPP_TYPE_I4
    // 038 _DrawDate                                000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ProductListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_productList_codec              FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 040 ProductList                              000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_bonusProductList_codec         FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 048 BonusProductList                         000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 GaugeProductListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_gaugeProductList_codec         FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 050 GaugeProductList                         000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 DrawProductListFieldNumber               int IL2CPP_TYPE_I4
    // 020 _repeated_drawProductList_codec          FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 058 DrawProductList                          000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 060 ResourceId                               000186671910 ModelPrimitiveType string string string String
    public partial class GashaHistoryStatus
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
            var value   = new GashaHistoryStatus();

            value.DrawDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0270D15913C8 0x10 DrawDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaHistoryId                            = GetString(new IntPtr(p + 0x028)); // 0270D1591448 0x28 GashaHistoryId              ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaId                                   = GetString(new IntPtr(p + 0x030)); // 0270D1591488 0x30 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value._DrawDate                                 = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D15914C8 0x38 _DrawDate                   ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ProductList                               = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1591528 0x40 ProductList                 ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.BonusProductList                          = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D1591588 0x48 BonusProductList            ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.GaugeProductList                          = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D15915E8 0x50 GaugeProductList            ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.DrawProductList                           = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0270D1591648 0x58 DrawProductList             ( 000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )
            value.ResourceId                                = GetString(new IntPtr(p + 0x060)); // 0270D1591688 0x60 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.DrawDate                      = ToDateTime(value._DrawDate);

            return value;
        }
    }
}
