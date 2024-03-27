using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ItemType
    {
        None,
        FreeInGameCurrency,
        MoneyToken,
        GashaTicket,
        RecoverVitality,
        EnhanceCharacterExp,
        EnhanceSkillExp,
        EnhanceEvolution,
        EnhanceLimit,
        PaidInGameCurrency,
        SkipTicket,
        GashaItem,
        GashaExchangeItem,
        InvokeLoginBonus,
        CharacterDedicatedEnhanceLimitExchangeItem,
        CharacterDedicatedEnhanceLimit,
        GashaCompensationTicket,
        Num,
    }
}
