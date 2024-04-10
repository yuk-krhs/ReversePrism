using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsShowRetryBtn                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 IsRetryGasha                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Gasha                                    00018652A1B0 ModelClassType IGashaStatus IGashaStatus IGashaStatus Pointer
    // 020 HavingGroup                              0001865657C0 ModelClassType IHavingProductGroupStatus IHavingProductGroupStatus IHavingProductGroupStatus Pointer
    // 028 BonusProductList                         000185CE8088 ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer
    // 030 GaugeProductList                         000185CE8088 ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer
    // 038 DrawProductList                          000185CE4458 ModelClassListType List`1<IGashaRewardProductStatus> List`1<IGashaRewardProductStatus> List<IGashaRewardProductStatus> Pointer
    // 040 Effect                                   000186522C50 ModelClassType IGashaEffectStatus IGashaEffectStatus IGashaEffectStatus Pointer
    // 048 PrismGauge                               000186527050 ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer
    // 050 ExchangePoint                            000186524B40 ModelClassType IGashaExchangeStatus IGashaExchangeStatus IGashaExchangeStatus Pointer
    // 058 OldExChangePoint                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C OldPrismGaugePoint                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GashaResultData : DataModel
    {
        public bool                                     IsShowRetryBtn                          { get; set; }
        public bool                                     IsRetryGasha                            { get; set; }
        public IGashaStatus?                            Gasha                                   { get; set; }
        public IHavingProductGroupStatus?               HavingGroup                             { get; set; }
        public List<IRewardProductStatus>?              BonusProductList                        { get; set; }
        public List<IRewardProductStatus>?              GaugeProductList                        { get; set; }
        public List<IGashaRewardProductStatus>?         DrawProductList                         { get; set; }
        public IGashaEffectStatus?                      Effect                                  { get; set; }
        public IGashaPrismGaugeStatus?                  PrismGauge                              { get; set; }
        public IGashaExchangeStatus?                    ExchangePoint                           { get; set; }
        public int                                      OldExChangePoint                        { get; set; }
        public int                                      OldPrismGaugePoint                      { get; set; }

        public static GashaResultData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaResultData() { Pointer= p0 };

            value.IsShowRetryBtn                            = GetBool(new IntPtr(p + 0x010)); // 0246653E3750 0x10 IsShowRetryBtn              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsRetryGasha                              = GetBool(new IntPtr(p + 0x011)); // 0246653E3770 0x11 IsRetryGasha                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Gasha                                     = GetObject<IGashaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGashaStatus.FromPointer); // 0246653E3790 0x18 Gasha                       ( 00018652A1B0 ModelClassType IGashaStatus IGashaStatus IGashaStatus Pointer )
            value.HavingGroup                               = GetObject<IHavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHavingProductGroupStatus.FromPointer); // 0246653E37B0 0x20 HavingGroup                 ( 0001865657C0 ModelClassType IHavingProductGroupStatus IHavingProductGroupStatus IHavingProductGroupStatus Pointer )
            value.BonusProductList                          = GetObjectList<IRewardProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 0246653E37D0 0x28 BonusProductList            ( 000185CE8088 ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer )
            value.GaugeProductList                          = GetObjectList<IRewardProductStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 0246653E37F0 0x30 GaugeProductList            ( 000185CE8088 ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer )
            value.DrawProductList                           = GetObjectList<IGashaRewardProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGashaRewardProductStatus.FromPointer); // 0246653E3810 0x38 DrawProductList             ( 000185CE4458 ModelClassListType List`1<IGashaRewardProductStatus> List`1<IGashaRewardProductStatus> List<IGashaRewardProductStatus> Pointer )
            value.Effect                                    = GetObject<IGashaEffectStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGashaEffectStatus.FromPointer); // 0246653E3830 0x40 Effect                      ( 000186522C50 ModelClassType IGashaEffectStatus IGashaEffectStatus IGashaEffectStatus Pointer )
            value.PrismGauge                                = GetObject<IGashaPrismGaugeStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IGashaPrismGaugeStatus.FromPointer); // 0246653E3850 0x48 PrismGauge                  ( 000186527050 ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer )
            value.ExchangePoint                             = GetObject<IGashaExchangeStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IGashaExchangeStatus.FromPointer); // 0246653E3870 0x50 ExchangePoint               ( 000186524B40 ModelClassType IGashaExchangeStatus IGashaExchangeStatus IGashaExchangeStatus Pointer )
            value.OldExChangePoint                          = GetInt32(new IntPtr(p + 0x058)); // 0246653E3890 0x58 OldExChangePoint            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OldPrismGaugePoint                        = GetInt32(new IntPtr(p + 0x05C)); // 0246653E38B0 0x5C OldPrismGaugePoint          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
