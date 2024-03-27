using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TutorialGashaId                          string IL2CPP_TYPE_STRING
    // 010 GashaService                             00018661AAC0 ModelClassType GashaService GashaService GashaService Pointer
    // 018 Gashas                                   000185CDD788 ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer
    // 020 PrismGauges                              000185CDE138 ModelClassListType List`1<GashaPrismGauge> List`1<GashaPrismGauge> List<GashaPrismGauge> Pointer
    // 028 GashaExchanges                           000185CDDC58 ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer
    // 030 ConvertExchangeIdList                    000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 038 RevertExchangeIdList                     000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 SelectedGashaId                          000186671910 ModelPrimitiveType string string string String
    // 048 SelectedPriceId                          000186671910 ModelPrimitiveType string string string String
    // 000 <IsEffectExec>k__BackingField            bool IL2CPP_TYPE_BOOLEAN
    public partial class GashaModel
    {
        public GashaService?                            GashaService                            { get; set; }
        public List<Gasha>?                             Gashas                                  { get; set; }
        public List<GashaPrismGauge>?                   PrismGauges                             { get; set; }
        public List<GashaExchange>?                     GashaExchanges                          { get; set; }
        public List<string>?                            ConvertExchangeIdList                   { get; set; }
        public List<string>?                            RevertExchangeIdList                    { get; set; }
        public string                                   SelectedGashaId                         { get; set; }
        public string                                   SelectedPriceId                         { get; set; }

        public static GashaModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaModel();

            value.GashaService                              = GetObject<GashaService>(new IntPtr(p + 0x010), ReversePrism.DataModels.GashaService.FromPointer); // 0270D34EBBE8 0x10 GashaService                ( 00018661AAC0 ModelClassType GashaService GashaService GashaService Pointer )
            value.Gashas                                    = GetObjectList<Gasha>(new IntPtr(p + 0x018), ReversePrism.DataModels.Gasha.FromPointer); // 0270D34EBC08 0x18 Gashas                      ( 000185CDD788 ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer )
            value.PrismGauges                               = GetObjectList<GashaPrismGauge>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaPrismGauge.FromPointer); // 0270D34EBC28 0x20 PrismGauges                 ( 000185CDE138 ModelClassListType List`1<GashaPrismGauge> List`1<GashaPrismGauge> List<GashaPrismGauge> Pointer )
            value.GashaExchanges                            = GetObjectList<GashaExchange>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaExchange.FromPointer); // 0270D34EBC48 0x28 GashaExchanges              ( 000185CDDC58 ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer )
            value.ConvertExchangeIdList                     = GetStringList(new IntPtr(p + 0x030)); // 0270D34EBC68 0x30 ConvertExchangeIdList       ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.RevertExchangeIdList                      = GetStringList(new IntPtr(p + 0x038)); // 0270D34EBC88 0x38 RevertExchangeIdList        ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SelectedGashaId                           = GetString(new IntPtr(p + 0x040)); // 0270D34EBCA8 0x40 SelectedGashaId             ( 000186671910 ModelPrimitiveType string string string String )
            value.SelectedPriceId                           = GetString(new IntPtr(p + 0x048)); // 0270D34EBCC8 0x48 SelectedPriceId             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
