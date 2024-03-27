using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PaddingMode
    {
        None,
        PKCS7,
        Zeros,
        ANSIX923,
        ISO10126,
    }
}
