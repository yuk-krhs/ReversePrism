using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ExtendedResult
    {
        IOErrorRead,
        IOErrorShortRead,
        IOErrorWrite,
        IOErrorFsync,
        IOErrorDirFSync,
        IOErrorTruncate,
        IOErrorFStat,
        IOErrorUnlock,
        IOErrorRdlock,
        IOErrorDelete,
        IOErrorBlocked,
        IOErrorNoMem,
        IOErrorAccess,
        IOErrorCheckReservedLock,
        IOErrorLock,
        IOErrorClose,
        IOErrorDirClose,
        IOErrorSHMOpen,
        IOErrorSHMSize,
        IOErrorSHMLock,
        IOErrorSHMMap,
        IOErrorSeek,
        IOErrorDeleteNoEnt,
        IOErrorMMap,
        LockedSharedcache,
        BusyRecovery,
        CannottOpenNoTempDir,
        CannotOpenIsDir,
        CannotOpenFullPath,
        CorruptVTab,
        ReadonlyRecovery,
        ReadonlyCannotLock,
        ReadonlyRollback,
        AbortRollback,
        ConstraintCheck,
        ConstraintCommitHook,
        ConstraintForeignKey,
        ConstraintFunction,
        ConstraintNotNull,
        ConstraintPrimaryKey,
        ConstraintTrigger,
        ConstraintUnique,
        ConstraintVTab,
        NoticeRecoverWAL,
        NoticeRecoverRollback,
    }
}
