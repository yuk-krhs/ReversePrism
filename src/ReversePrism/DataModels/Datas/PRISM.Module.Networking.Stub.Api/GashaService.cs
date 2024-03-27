using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetGashaListArgs        Marshaller`1<GetGashaListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetGashaListReply       Marshaller`1<GetGashaListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GashaDrawArgs           Marshaller`1<GashaDrawArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GashaDrawReply          Marshaller`1<GashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetGashaDetailArgs      Marshaller`1<GetGashaDetailArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetGashaDetailReply     Marshaller`1<GetGashaDetailReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetGashaNotesArgs       Marshaller`1<GetGashaNotesArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetGashaNotesReply      Marshaller`1<GetGashaNotesReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetGashaRateArgs        Marshaller`1<GetGashaRateArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetGashaRateReply       Marshaller`1<GetGashaRateReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetGashaMemberArgs      Marshaller`1<GetGashaMemberArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetGashaMemberReply     Marshaller`1<GetGashaMemberReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_GetGashaBonusRateArgs   Marshaller`1<GetGashaBonusRateArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_GetGashaBonusRateReply  Marshaller`1<GetGashaBonusRateReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_GetGashaHistoryListArgs Marshaller`1<GetGashaHistoryListArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_GetGashaHistoryListReply Marshaller`1<GetGashaHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Marshaller_api_PurchaseGashaExchangeArgs Marshaller`1<PurchaseGashaExchangeArgs> IL2CPP_TYPE_GENERICINST
    // 090 __Marshaller_api_PurchaseGashaExchangeReply Marshaller`1<PurchaseGashaExchangeReply> IL2CPP_TYPE_GENERICINST
    // 098 __Marshaller_api_GetGashaExchangeInfoArgs Marshaller`1<GetGashaExchangeInfoArgs> IL2CPP_TYPE_GENERICINST
    // 0A0 __Marshaller_api_GetGashaExchangeInfoReply Marshaller`1<GetGashaExchangeInfoReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Marshaller_api_RetryGashaDrawArgs      Marshaller`1<RetryGashaDrawArgs> IL2CPP_TYPE_GENERICINST
    // 0B0 __Marshaller_api_RetryGashaDrawReply     Marshaller`1<RetryGashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Marshaller_api_RetryGashaCommitArgs    Marshaller`1<RetryGashaCommitArgs> IL2CPP_TYPE_GENERICINST
    // 0C0 __Marshaller_api_RetryGashaCommitReply   Marshaller`1<RetryGashaCommitReply> IL2CPP_TYPE_GENERICINST
    // 0C8 __Marshaller_api_GetPrismGaugeDetailArgs Marshaller`1<GetPrismGaugeDetailArgs> IL2CPP_TYPE_GENERICINST
    // 0D0 __Marshaller_api_GetPrismGaugeDetailReply Marshaller`1<GetPrismGaugeDetailReply> IL2CPP_TYPE_GENERICINST
    // 0D8 __Marshaller_api_GetGashaExchangePointListArgs Marshaller`1<GetGashaExchangePointListArgs> IL2CPP_TYPE_GENERICINST
    // 0E0 __Marshaller_api_GetGashaExchangePointListReply Marshaller`1<GetGashaExchangePointListReply> IL2CPP_TYPE_GENERICINST
    // 0E8 __Marshaller_api_ConvertGashaExchangePointArgs Marshaller`1<ConvertGashaExchangePointArgs> IL2CPP_TYPE_GENERICINST
    // 0F0 __Marshaller_api_ConvertGashaExchangePointReply Marshaller`1<ConvertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 0F8 __Marshaller_api_RevertGashaExchangePointArgs Marshaller`1<RevertGashaExchangePointArgs> IL2CPP_TYPE_GENERICINST
    // 100 __Marshaller_api_RevertGashaExchangePointReply Marshaller`1<RevertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 108 __Marshaller_api_CreateGashaSupportCharacterEffectArgs Marshaller`1<CreateGashaSupportCharacterEffectArgs> IL2CPP_TYPE_GENERICINST
    // 110 __Marshaller_api_CreateGashaSupportCharacterEffectReply Marshaller`1<CreateGashaSupportCharacterEffectReply> IL2CPP_TYPE_GENERICINST
    // 118 __Marshaller_api_CreateGashaProduceIdolEffectArgs Marshaller`1<CreateGashaProduceIdolEffectArgs> IL2CPP_TYPE_GENERICINST
    // 120 __Marshaller_api_CreateGashaProduceIdolEffectReply Marshaller`1<CreateGashaProduceIdolEffectReply> IL2CPP_TYPE_GENERICINST
    // 128 __Method_GetGashaList                    Method`2<GetGashaListArgs, GetGashaListReply> IL2CPP_TYPE_GENERICINST
    // 130 __Method_GashaDraw                       Method`2<GashaDrawArgs, GashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 138 __Method_GetGashaDetail                  Method`2<GetGashaDetailArgs, GetGashaDetailReply> IL2CPP_TYPE_GENERICINST
    // 140 __Method_GetGashaNotes                   Method`2<GetGashaNotesArgs, GetGashaNotesReply> IL2CPP_TYPE_GENERICINST
    // 148 __Method_GetGashaRate                    Method`2<GetGashaRateArgs, GetGashaRateReply> IL2CPP_TYPE_GENERICINST
    // 150 __Method_GetGashaMember                  Method`2<GetGashaMemberArgs, GetGashaMemberReply> IL2CPP_TYPE_GENERICINST
    // 158 __Method_GetGashaBonusRate               Method`2<GetGashaBonusRateArgs, GetGashaBonusRateReply> IL2CPP_TYPE_GENERICINST
    // 160 __Method_GetGashaHistoryList             Method`2<GetGashaHistoryListArgs, GetGashaHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 168 __Method_PurchaseGashaExchange           Method`2<PurchaseGashaExchangeArgs, PurchaseGashaExchangeReply> IL2CPP_TYPE_GENERICINST
    // 170 __Method_GetGashaExchangeInfo            Method`2<GetGashaExchangeInfoArgs, GetGashaExchangeInfoReply> IL2CPP_TYPE_GENERICINST
    // 178 __Method_RetryGashaDraw                  Method`2<RetryGashaDrawArgs, RetryGashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 180 __Method_RetryGashaCommit                Method`2<RetryGashaCommitArgs, RetryGashaCommitReply> IL2CPP_TYPE_GENERICINST
    // 188 __Method_GetPrismGaugeDetail             Method`2<GetPrismGaugeDetailArgs, GetPrismGaugeDetailReply> IL2CPP_TYPE_GENERICINST
    // 190 __Method_GetGashaExchangePointList       Method`2<GetGashaExchangePointListArgs, GetGashaExchangePointListReply> IL2CPP_TYPE_GENERICINST
    // 198 __Method_ConvertGashaExchangePoint       Method`2<ConvertGashaExchangePointArgs, ConvertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 1A0 __Method_RevertGashaExchangePoint        Method`2<RevertGashaExchangePointArgs, RevertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 1A8 __Method_CreateGashaSupportCharacterEffect Method`2<CreateGashaSupportCharacterEffectArgs, CreateGashaSupportCharacterEffectReply> IL2CPP_TYPE_GENERICINST
    // 1B0 __Method_CreateGashaProduceIdolEffect    Method`2<CreateGashaProduceIdolEffectArgs, CreateGashaProduceIdolEffectReply> IL2CPP_TYPE_GENERICINST
    public partial class GashaService
    {

        public static GashaService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaService();


            return value;
        }
    }
}
