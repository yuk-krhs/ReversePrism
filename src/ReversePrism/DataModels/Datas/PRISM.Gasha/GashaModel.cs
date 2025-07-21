using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TutorialGashaId                          string IL2CPP_TYPE_STRING
    // 010 GashaService                             ModelClassType GashaService GashaService GashaService Pointer
    // 018 Gashas                                   ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer
    // 020 OpenGashas                               ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer
    // 028 ActiveGashas                             ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer
    // 030 PrismGauges                              ModelClassListType List`1<GashaPrismGauge> List`1<GashaPrismGauge> List<GashaPrismGauge> Pointer
    // 038 GashaExchanges                           ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer
    // 040 ConvertExchangeIdList                    ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 048 RevertExchangeIdList                     ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 050 SelectedGashaId                          ModelPrimitiveType string string string String
    // 058 SelectedPriceId                          ModelPrimitiveType string string string String
    // 000 <IsEffectExec>k__BackingField            bool IL2CPP_TYPE_BOOLEAN
    public partial class GashaModel : DataModel
    {
        public GashaService?                            GashaService                            { get; set; }
        public List<Gasha>?                             Gashas                                  { get; set; }
        public List<Gasha>?                             OpenGashas                              { get; set; }
        public List<Gasha>?                             ActiveGashas                            { get; set; }
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
            var value   = new GashaModel() { Pointer= p0 };

            value.GashaService                              = GetObject<GashaService>(new IntPtr(p + 0x010), ReversePrism.DataModels.GashaService.FromPointer); // 0x10 GashaService                ( ModelClassType GashaService GashaService GashaService Pointer )
            value.Gashas                                    = GetObjectList<Gasha>(new IntPtr(p + 0x018), ReversePrism.DataModels.Gasha.FromPointer); // 0x18 Gashas                      ( ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer )
            value.OpenGashas                                = GetObjectList<Gasha>(new IntPtr(p + 0x020), ReversePrism.DataModels.Gasha.FromPointer); // 0x20 OpenGashas                  ( ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer )
            value.ActiveGashas                              = GetObjectList<Gasha>(new IntPtr(p + 0x028), ReversePrism.DataModels.Gasha.FromPointer); // 0x28 ActiveGashas                ( ModelClassListType List`1<Gasha> List`1<Gasha> List<Gasha> Pointer )
            value.PrismGauges                               = GetObjectList<GashaPrismGauge>(new IntPtr(p + 0x030), ReversePrism.DataModels.GashaPrismGauge.FromPointer); // 0x30 PrismGauges                 ( ModelClassListType List`1<GashaPrismGauge> List`1<GashaPrismGauge> List<GashaPrismGauge> Pointer )
            value.GashaExchanges                            = GetObjectList<GashaExchange>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaExchange.FromPointer); // 0x38 GashaExchanges              ( ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer )
            value.ConvertExchangeIdList                     = GetStringList(new IntPtr(p + 0x040)); // 0x40 ConvertExchangeIdList       ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.RevertExchangeIdList                      = GetStringList(new IntPtr(p + 0x048)); // 0x48 RevertExchangeIdList        ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SelectedGashaId                           = GetString(new IntPtr(p + 0x050)); // 0x50 SelectedGashaId             ( ModelPrimitiveType string string string String )
            value.SelectedPriceId                           = GetString(new IntPtr(p + 0x058)); // 0x58 SelectedPriceId             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
