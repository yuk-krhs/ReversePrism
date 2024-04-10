using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetStaminaListArgs      Marshaller`1<GetStaminaListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetStaminaListReply     Marshaller`1<GetStaminaListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_RecoverStaminaByInGameCurrencyArgs Marshaller`1<RecoverStaminaByInGameCurrencyArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_RecoverStaminaByInGameCurrencyReply Marshaller`1<RecoverStaminaByInGameCurrencyReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_RecoverStaminaByItemMultiArgs Marshaller`1<RecoverStaminaByItemMultiArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_RecoverStaminaByItemMultiReply Marshaller`1<RecoverStaminaByItemMultiReply> IL2CPP_TYPE_GENERICINST
    // 038 __Method_GetStaminaList                  Method`2<GetStaminaListArgs, GetStaminaListReply> IL2CPP_TYPE_GENERICINST
    // 040 __Method_RecoverStaminaByInGameCurrency  Method`2<RecoverStaminaByInGameCurrencyArgs, RecoverStaminaByInGameCurrencyReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_RecoverStaminaByItemMulti       Method`2<RecoverStaminaByItemMultiArgs, RecoverStaminaByItemMultiReply> IL2CPP_TYPE_GENERICINST
    public partial class StaminaService : DataModel
    {

        public static StaminaService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaService() { Pointer= p0 };


            return value;
        }
    }
}
