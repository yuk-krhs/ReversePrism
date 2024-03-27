using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum UriSyntaxFlags
    {
        None,
        MustHaveAuthority,
        OptionalAuthority,
        MayHaveUserInfo,
        MayHavePort,
        MayHavePath,
        MayHaveQuery,
        MayHaveFragment,
        AllowEmptyHost,
        AllowUncHost,
        AllowDnsHost,
        AllowIPv4Host,
        AllowIPv6Host,
        AllowAnInternetHost,
        AllowAnyOtherHost,
        FileLikeUri,
        MailToLikeUri,
        V1_UnknownUri,
        SimpleUserSyntax,
        BuiltInSyntax,
        ParserSchemeOnly,
        AllowDOSPath,
        PathIsRooted,
        ConvertPathSlashes,
        CompressPath,
        CanonicalizeAsFilePath,
        UnEscapeDotsAndSlashes,
        AllowIdn,
        AllowIriParsing,
    }
}
