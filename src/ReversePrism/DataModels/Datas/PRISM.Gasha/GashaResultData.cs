using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsShowRetryBtn                           ModelPrimitiveType bool bool bool Bool
    // 011 IsRetryGasha                             ModelPrimitiveType bool bool bool Bool
    // 018 Gasha                                    ModelClassType IGashaStatus IGashaStatus IGashaStatus Pointer
    // 020 HavingGroup                              ModelClassType IHavingProductGroupStatus IHavingProductGroupStatus IHavingProductGroupStatus Pointer
    // 028 BonusProductList                         ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer
    // 030 GaugeProductList                         ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer
    // 038 DrawProductList                          ModelClassListType List`1<IGashaRewardProductStatus> List`1<IGashaRewardProductStatus> List<IGashaRewardProductStatus> Pointer
    // 040 Effect                                   ModelClassType IGashaEffectStatus IGashaEffectStatus IGashaEffectStatus Pointer
    // 048 PrismGauge                               ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer
    // 050 ExchangePoint                            ModelClassType IGashaExchangeStatus IGashaExchangeStatus IGashaExchangeStatus Pointer
    // 058 OldExChangePoint                         ModelPrimitiveType int int int Int32
    // 05C OldPrismGaugePoint                       ModelPrimitiveType int int int Int32
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

            value.IsShowRetryBtn                            = GetBool(new IntPtr(p + 0x010)); // 0x10 IsShowRetryBtn              ( ModelPrimitiveType bool bool bool Bool )
            value.IsRetryGasha                              = GetBool(new IntPtr(p + 0x011)); // 0x11 IsRetryGasha                ( ModelPrimitiveType bool bool bool Bool )
            value.Gasha                                     = GetObject<IGashaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGashaStatus.FromPointer); // 0x18 Gasha                       ( ModelClassType IGashaStatus IGashaStatus IGashaStatus Pointer )
            value.HavingGroup                               = GetObject<IHavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHavingProductGroupStatus.FromPointer); // 0x20 HavingGroup                 ( ModelClassType IHavingProductGroupStatus IHavingProductGroupStatus IHavingProductGroupStatus Pointer )
            value.BonusProductList                          = GetObjectList<IRewardProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 0x28 BonusProductList            ( ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer )
            value.GaugeProductList                          = GetObjectList<IRewardProductStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 0x30 GaugeProductList            ( ModelClassListType List`1<IRewardProductStatus> List`1<IRewardProductStatus> List<IRewardProductStatus> Pointer )
            value.DrawProductList                           = GetObjectList<IGashaRewardProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IGashaRewardProductStatus.FromPointer); // 0x38 DrawProductList             ( ModelClassListType List`1<IGashaRewardProductStatus> List`1<IGashaRewardProductStatus> List<IGashaRewardProductStatus> Pointer )
            value.Effect                                    = GetObject<IGashaEffectStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGashaEffectStatus.FromPointer); // 0x40 Effect                      ( ModelClassType IGashaEffectStatus IGashaEffectStatus IGashaEffectStatus Pointer )
            value.PrismGauge                                = GetObject<IGashaPrismGaugeStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IGashaPrismGaugeStatus.FromPointer); // 0x48 PrismGauge                  ( ModelClassType IGashaPrismGaugeStatus IGashaPrismGaugeStatus IGashaPrismGaugeStatus Pointer )
            value.ExchangePoint                             = GetObject<IGashaExchangeStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IGashaExchangeStatus.FromPointer); // 0x50 ExchangePoint               ( ModelClassType IGashaExchangeStatus IGashaExchangeStatus IGashaExchangeStatus Pointer )
            value.OldExChangePoint                          = GetInt32(new IntPtr(p + 0x058)); // 0x58 OldExChangePoint            ( ModelPrimitiveType int int int Int32 )
            value.OldPrismGaugePoint                        = GetInt32(new IntPtr(p + 0x05C)); // 0x5C OldPrismGaugePoint          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
