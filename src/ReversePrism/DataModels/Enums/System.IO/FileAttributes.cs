using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FileAttributes
    {
        ReadOnly,
        Hidden,
        System,
        Directory,
        Archive,
        Device,
        Normal,
        Temporary,
        SparseFile,
        ReparsePoint,
        Compressed,
        Offline,
        NotContentIndexed,
        Encrypted,
        IntegrityStream,
        NoScrubData,
    }
}
