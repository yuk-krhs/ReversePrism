using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DataType
    {
        None,
        Number,
        Integer,
        Length,
        Percentage,
        Color,
        Resource,
        Url,
        Time,
        Angle,
        CustomIdent,
    }
}
