using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Gasha                                    00018661E310 ModelClassType GashaStatus GashaStatus GashaStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_bonusProductList_codec         FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 028 BonusProductList                         000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 GaugeProductListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_gaugeProductList_codec         FieldCodec`1<RewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 030 GaugeProductList                         000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer
    // 000 PrismGaugeFieldNumber                    int IL2CPP_TYPE_I4
    // 038 PrismGauge                               000186610030 ModelClassType GashaPrismGaugeStatus GashaPrismGaugeStatus GashaPrismGaugeStatus Pointer
    // 000 ExchangePointFieldNumber                 int IL2CPP_TYPE_I4
    // 040 ExchangePoint                            000186602DE0 ModelClassType GashaExchangeStatus GashaExchangeStatus GashaExchangeStatus Pointer
    // 000 DrawProductListFieldNumber               int IL2CPP_TYPE_I4
    // 018 _repeated_drawProductList_codec          FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 048 DrawProductList                          000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    // 000 EffectFieldNumber                        int IL2CPP_TYPE_I4
    // 050 Effect                                   0001865FB780 ModelClassType GashaEffectStatus GashaEffectStatus GashaEffectStatus Pointer
    // 000 GashaStateFieldNumber                    int IL2CPP_TYPE_I4
    // 058 GashaState                               00018661DC20 ModelEnumType GashaState GashaState GashaState Int32
    public partial class GashaDrawReply
    {
        public GashaStatus?                             Gasha                                   { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public List<RewardProductStatus>?               BonusProductList                        { get; set; }
        public List<RewardProductStatus>?               GaugeProductList                        { get; set; }
        public GashaPrismGaugeStatus?                   PrismGauge                              { get; set; }
        public GashaExchangeStatus?                     ExchangePoint                           { get; set; }
        public List<GashaRewardProductStatus>?          DrawProductList                         { get; set; }
        public GashaEffectStatus?                       Effect                                  { get; set; }
        public GashaState                               GashaState                              { get; set; }

        public static GashaDrawReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDrawReply();

            value.Gasha                                     = GetObject<GashaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaStatus.FromPointer); // 0270D1A0D298 0x18 Gasha                       ( 00018661E310 ModelClassType GashaStatus GashaStatus GashaStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0270D1A0D2D8 0x20 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.BonusProductList                          = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D1A0D338 0x28 BonusProductList            ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.GaugeProductList                          = GetObjectList<RewardProductStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardProductStatus.FromPointer); // 0270D1A0D398 0x30 GaugeProductList            ( 000185CEEEA8 ModelClassListType RepeatedField`1<RewardProductStatus> RepeatedField`1<RewardProductStatus> List<RewardProductStatus> Pointer )
            value.PrismGauge                                = GetObject<GashaPrismGaugeStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaPrismGaugeStatus.FromPointer); // 0270D1A0D3D8 0x38 PrismGauge                  ( 000186610030 ModelClassType GashaPrismGaugeStatus GashaPrismGaugeStatus GashaPrismGaugeStatus Pointer )
            value.ExchangePoint                             = GetObject<GashaExchangeStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaExchangeStatus.FromPointer); // 0270D1A0D418 0x40 ExchangePoint               ( 000186602DE0 ModelClassType GashaExchangeStatus GashaExchangeStatus GashaExchangeStatus Pointer )
            value.DrawProductList                           = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0270D1A0D478 0x48 DrawProductList             ( 000185CDD198 ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )
            value.Effect                                    = GetObject<GashaEffectStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.GashaEffectStatus.FromPointer); // 0270D1A0D4B8 0x50 Effect                      ( 0001865FB780 ModelClassType GashaEffectStatus GashaEffectStatus GashaEffectStatus Pointer )
            value.GashaState                                = (GashaState)GetInt32(new IntPtr(p + 0x058)); // 0270D1A0D4F8 0x58 GashaState                  ( 00018661DC20 ModelEnumType GashaState GashaState GashaState Int32 )

            return value;
        }
    }
}
