using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum HttpRequestHeader
    {
        CacheControl,
        Connection,
        Date,
        KeepAlive,
        Pragma,
        Trailer,
        TransferEncoding,
        Upgrade,
        Via,
        Warning,
        Allow,
        ContentLength,
        ContentType,
        ContentEncoding,
        ContentLanguage,
        ContentLocation,
        ContentMd5,
        ContentRange,
        Expires,
        LastModified,
        Accept,
        AcceptCharset,
        AcceptEncoding,
        AcceptLanguage,
        Authorization,
        Cookie,
        Expect,
        From,
        Host,
        IfMatch,
        IfModifiedSince,
        IfNoneMatch,
        IfRange,
        IfUnmodifiedSince,
        MaxForwards,
        ProxyAuthorization,
        Referer,
        Range,
        Te,
        Translate,
        UserAgent,
    }
}
