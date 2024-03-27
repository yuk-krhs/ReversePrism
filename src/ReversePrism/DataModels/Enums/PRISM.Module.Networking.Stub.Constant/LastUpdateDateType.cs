using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LastUpdateDateType
    {
        None,
        Present,
        Mission,
        Gasha,
        Announce,
        Friend,
        Story,
        Quest,
        DirectMessage,
        PanelMission,
        Num,
    }
}
