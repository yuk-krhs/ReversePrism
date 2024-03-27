using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum HomeVoiceType
    {
        None,
        Normal,
        Inactive,
        CharacterBirthdaySelf,
        CharacterBirthdaySameUnit,
        ProducerBirthday,
        Casual,
        Season,
        SeasonalEvent,
        Num,
    }
}
