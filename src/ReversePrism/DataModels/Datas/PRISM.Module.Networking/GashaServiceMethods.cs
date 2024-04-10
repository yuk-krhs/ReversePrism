using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetGashaList                             Method`2<IGetGashaListArgs, IGetGashaListReply> IL2CPP_TYPE_GENERICINST
    // 018 GashaDraw                                Method`2<IGashaDrawArgs, IGashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 030 GetGashaDetail                           Method`2<IGetGashaDetailArgs, IGetGashaDetailReply> IL2CPP_TYPE_GENERICINST
    // 048 GetGashaNotes                            Method`2<IGetGashaNotesArgs, IGetGashaNotesReply> IL2CPP_TYPE_GENERICINST
    // 060 GetGashaRate                             Method`2<IGetGashaRateArgs, IGetGashaRateReply> IL2CPP_TYPE_GENERICINST
    // 078 GetGashaMember                           Method`2<IGetGashaMemberArgs, IGetGashaMemberReply> IL2CPP_TYPE_GENERICINST
    // 090 GetGashaBonusRate                        Method`2<IGetGashaBonusRateArgs, IGetGashaBonusRateReply> IL2CPP_TYPE_GENERICINST
    // 0A8 GetGashaHistoryList                      Method`2<IGetGashaHistoryListArgs, IGetGashaHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 0C0 PurchaseGashaExchange                    Method`2<IPurchaseGashaExchangeArgs, IPurchaseGashaExchangeReply> IL2CPP_TYPE_GENERICINST
    // 0D8 GetGashaExchangeInfo                     Method`2<IGetGashaExchangeInfoArgs, IGetGashaExchangeInfoReply> IL2CPP_TYPE_GENERICINST
    // 0F0 RetryGashaDraw                           Method`2<IRetryGashaDrawArgs, IRetryGashaDrawReply> IL2CPP_TYPE_GENERICINST
    // 108 RetryGashaCommit                         Method`2<IRetryGashaCommitArgs, IRetryGashaCommitReply> IL2CPP_TYPE_GENERICINST
    // 120 GetPrismGaugeDetail                      Method`2<IGetPrismGaugeDetailArgs, IGetPrismGaugeDetailReply> IL2CPP_TYPE_GENERICINST
    // 138 GetGashaExchangePointList                Method`2<IGetGashaExchangePointListArgs, IGetGashaExchangePointListReply> IL2CPP_TYPE_GENERICINST
    // 150 ConvertGashaExchangePoint                Method`2<IConvertGashaExchangePointArgs, IConvertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 168 RevertGashaExchangePoint                 Method`2<IRevertGashaExchangePointArgs, IRevertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 180 CreateGashaSupportCharacterEffect        Method`2<ICreateGashaSupportCharacterEffectArgs, ICreateGashaSupportCharacterEffectReply> IL2CPP_TYPE_GENERICINST
    // 198 CreateGashaProduceIdolEffect             Method`2<ICreateGashaProduceIdolEffectArgs, ICreateGashaProduceIdolEffectReply> IL2CPP_TYPE_GENERICINST
    public partial class GashaServiceMethods : DataModel
    {

        public static GashaServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
