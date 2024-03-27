using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CreateDisposition
    {
        FILE_SUPERSEDE,
        FILE_OPEN,
        FILE_CREATE,
        FILE_OPEN_IF,
        FILE_OVERWRITE,
        FILE_OVERWRITE_IF,
    }
}
