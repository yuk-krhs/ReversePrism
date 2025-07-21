using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ToggleArchiveFavoriteReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProgramFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Program                                  ModelClassType ArchiveStreamProgramStatus ArchiveStreamProgramStatus ArchiveStreamProgramStatus Pointer
    public partial class ToggleArchiveFavoriteReply : DataModel
    {
        public ArchiveStreamProgramStatus?              Program                                 { get; set; }

        public static ToggleArchiveFavoriteReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleArchiveFavoriteReply() { Pointer= p0 };

            value.Program                                   = GetObject<ArchiveStreamProgramStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArchiveStreamProgramStatus.FromPointer); // 0x18 Program                     ( ModelClassType ArchiveStreamProgramStatus ArchiveStreamProgramStatus ArchiveStreamProgramStatus Pointer )

            return value;
        }
    }
}
