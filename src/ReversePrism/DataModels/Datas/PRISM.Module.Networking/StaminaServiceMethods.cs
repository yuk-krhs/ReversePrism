using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetStaminaList                           Method`2<IGetStaminaListArgs, IGetStaminaListReply> IL2CPP_TYPE_GENERICINST
    // 018 RecoverStaminaByInGameCurrency           Method`2<IRecoverStaminaByInGameCurrencyArgs, IRecoverStaminaByInGameCurrencyReply> IL2CPP_TYPE_GENERICINST
    // 030 RecoverStaminaByItemMulti                Method`2<IRecoverStaminaByItemMultiArgs, IRecoverStaminaByItemMultiReply> IL2CPP_TYPE_GENERICINST
    public partial class StaminaServiceMethods : DataModel
    {

        public static StaminaServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
