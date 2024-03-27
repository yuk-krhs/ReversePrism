using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum UriComponents
    {
        Scheme,
        UserInfo,
        Host,
        Port,
        Path,
        Query,
        Fragment,
        StrongPort,
        NormalizedHost,
        KeepDelimiter,
        SerializationInfoString,
        AbsoluteUri,
        HostAndPort,
        StrongAuthority,
        SchemeAndServer,
        HttpRequestUrl,
        PathAndQuery,
    }
}
