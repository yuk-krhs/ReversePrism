using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LoadingViewType
    {
        Common,
        CautionToTitle,
        HomeToCharacter,
        HomeToStory,
        HomeToProduce,
        HomeToLive,
        HomeToShop,
        HomeToGasha,
        SoftReset,
    }
}
