using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ParsingError
    {
        None,
        BadFormat,
        BadScheme,
        BadAuthority,
        EmptyUriString,
        LastRelativeUriOkErrIndex,
        SchemeLimit,
        SizeLimit,
        MustRootedPath,
        BadHostName,
        NonEmptyHost,
        BadPort,
        BadAuthorityTerminator,
        CannotCreateRelative,
    }
}
