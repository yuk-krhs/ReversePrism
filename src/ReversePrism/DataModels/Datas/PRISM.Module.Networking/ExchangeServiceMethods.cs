using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetExchangeGroupList                     Method`2<IGetExchangeGroupListArgs, IGetExchangeGroupListReply> IL2CPP_TYPE_GENERICINST
    // 018 PurchaseExchangeProduct                  Method`2<IPurchaseExchangeProductArgs, IPurchaseExchangeProductReply> IL2CPP_TYPE_GENERICINST
    // 030 GetExchangeSelectionTicketList           Method`2<IGetExchangeSelectionTicketListArgs, IGetExchangeSelectionTicketListReply> IL2CPP_TYPE_GENERICINST
    // 048 ExchangeSelectionTicket                  Method`2<IExchangeSelectionTicketArgs, IExchangeSelectionTicketReply> IL2CPP_TYPE_GENERICINST
    // 060 GetExchangePurchaseHistoryList           Method`2<IGetExchangePurchaseHistoryListArgs, IGetExchangePurchaseHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 078 GetExchangeShinyPartyTokenList           Method`2<IGetExchangeShinyPartyTokenListArgs, IGetExchangeShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    // 090 ExchangeShinyPartyToken                  Method`2<IExchangeShinyPartyTokenArgs, IExchangeShinyPartyTokenReply> IL2CPP_TYPE_GENERICINST
    // 0A8 GetExchangeAvailableShinyPartyTokenList  Method`2<IGetExchangeAvailableShinyPartyTokenListArgs, IGetExchangeAvailableShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeServiceMethods : DataModel
    {

        public static ExchangeServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
