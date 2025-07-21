using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Resolution
    {
        Unknown,
        x256,
        x512,
        x1024,
        SameAsModelBuffer,
    }
}
