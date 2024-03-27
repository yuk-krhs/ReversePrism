using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetExchangeGroupListArgs Marshaller`1<GetExchangeGroupListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetExchangeGroupListReply Marshaller`1<GetExchangeGroupListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_PurchaseExchangeProductArgs Marshaller`1<PurchaseExchangeProductArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_PurchaseExchangeProductReply Marshaller`1<PurchaseExchangeProductReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetExchangeSelectionTicketListArgs Marshaller`1<GetExchangeSelectionTicketListArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetExchangeSelectionTicketListReply Marshaller`1<GetExchangeSelectionTicketListReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_ExchangeSelectionTicketArgs Marshaller`1<ExchangeSelectionTicketArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_ExchangeSelectionTicketReply Marshaller`1<ExchangeSelectionTicketReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetExchangePurchaseHistoryListArgs Marshaller`1<GetExchangePurchaseHistoryListArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetExchangePurchaseHistoryListReply Marshaller`1<GetExchangePurchaseHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_GetExchangeShinyPartyTokenListArgs Marshaller`1<GetExchangeShinyPartyTokenListArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_GetExchangeShinyPartyTokenListReply Marshaller`1<GetExchangeShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_ExchangeShinyPartyTokenArgs Marshaller`1<ExchangeShinyPartyTokenArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_ExchangeShinyPartyTokenReply Marshaller`1<ExchangeShinyPartyTokenReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_GetExchangeAvailableShinyPartyTokenListArgs Marshaller`1<GetExchangeAvailableShinyPartyTokenListArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_GetExchangeAvailableShinyPartyTokenListReply Marshaller`1<GetExchangeAvailableShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_GetExchangeGroupList            Method`2<GetExchangeGroupListArgs, GetExchangeGroupListReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_PurchaseExchangeProduct         Method`2<PurchaseExchangeProductArgs, PurchaseExchangeProductReply> IL2CPP_TYPE_GENERICINST
    // 098 __Method_GetExchangeSelectionTicketList  Method`2<GetExchangeSelectionTicketListArgs, GetExchangeSelectionTicketListReply> IL2CPP_TYPE_GENERICINST
    // 0A0 __Method_ExchangeSelectionTicket         Method`2<ExchangeSelectionTicketArgs, ExchangeSelectionTicketReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Method_GetExchangePurchaseHistoryList  Method`2<GetExchangePurchaseHistoryListArgs, GetExchangePurchaseHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 0B0 __Method_GetExchangeShinyPartyTokenList  Method`2<GetExchangeShinyPartyTokenListArgs, GetExchangeShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Method_ExchangeShinyPartyToken         Method`2<ExchangeShinyPartyTokenArgs, ExchangeShinyPartyTokenReply> IL2CPP_TYPE_GENERICINST
    // 0C0 __Method_GetExchangeAvailableShinyPartyTokenList Method`2<GetExchangeAvailableShinyPartyTokenListArgs, GetExchangeAvailableShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeService
    {

        public static ExchangeService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeService();


            return value;
        }
    }
}
