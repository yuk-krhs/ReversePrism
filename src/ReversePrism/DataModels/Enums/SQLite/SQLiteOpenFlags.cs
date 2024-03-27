using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum SQLiteOpenFlags
    {
        ReadOnly,
        ReadWrite,
        Create,
        NoMutex,
        FullMutex,
        SharedCache,
        PrivateCache,
        ProtectionComplete,
        ProtectionCompleteUnlessOpen,
        ProtectionCompleteUntilFirstUserAuthentication,
        ProtectionNone,
    }
}
