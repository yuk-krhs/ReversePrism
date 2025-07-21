using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Edition
    {
        Unknown,
        Proto2,
        Proto3,
        _2023,
        _2024,
        _1TestOnly,
        _2TestOnly,
        _99997TestOnly,
        _99998TestOnly,
        _99999TestOnly,
        Max,
    }
}
