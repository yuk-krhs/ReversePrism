using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum GeneralNameType
    {
        OtherName,
        Rfc822Name,
        Email,
        DnsName,
        X400Address,
        DirectoryName,
        EdiPartyName,
        UniformResourceIdentifier,
        IPAddress,
        RegisteredId,
    }
}
