using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStreamArchiveListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProgramListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_programList_codec              FieldCodec`1<ArchiveStreamProgramStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProgramList                              000185CCEB58 ModelClassListType RepeatedField`1<ArchiveStreamProgramStatus> RepeatedField`1<ArchiveStreamProgramStatus> List<ArchiveStreamProgramStatus> Pointer
    public partial class GetStreamArchiveListReply
    {
        public List<ArchiveStreamProgramStatus>?        ProgramList                             { get; set; }

        public static GetStreamArchiveListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStreamArchiveListReply();

            value.ProgramList                               = GetObjectList<ArchiveStreamProgramStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArchiveStreamProgramStatus.FromPointer); // 0270D2ABCC78 0x18 ProgramList                 ( 000185CCEB58 ModelClassListType RepeatedField`1<ArchiveStreamProgramStatus> RepeatedField`1<ArchiveStreamProgramStatus> List<ArchiveStreamProgramStatus> Pointer )

            return value;
        }
    }
}
