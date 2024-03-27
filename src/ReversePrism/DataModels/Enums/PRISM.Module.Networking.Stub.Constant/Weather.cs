using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Weather
    {
        None,
        ClearSky,
        Rain,
        HeavyRain,
        Clouds,
        Snow,
        FewClouds,
        ScatteredClouds,
        BrokenClouds,
        OvercastClouds,
        Num,
    }
}
