using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum HS
    {
        _err,
        Start,
        S400,
        S400_400,
        S400_X00,
        S400_X0,
        X00_DQ,
        S400_X00_X0,
        X0_DQ,
        X,
        X0,
        X00,
        S400_DQ,
        S400_400_DQ,
        S400_400_100,
        S9,
        X00_S9,
        S9_DQ,
        END,
    }
}
