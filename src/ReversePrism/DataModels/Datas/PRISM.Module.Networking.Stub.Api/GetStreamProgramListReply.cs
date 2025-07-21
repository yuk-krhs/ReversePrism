using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStreamProgramListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProgramListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_programList_codec              FieldCodec`1<LiveStreamProgramStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProgramList                              ModelClassListType RepeatedField`1<LiveStreamProgramStatus> RepeatedField`1<LiveStreamProgramStatus> List<LiveStreamProgramStatus> Pointer
    public partial class GetStreamProgramListReply : DataModel
    {
        public List<LiveStreamProgramStatus>?           ProgramList                             { get; set; }

        public static GetStreamProgramListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStreamProgramListReply() { Pointer= p0 };

            value.ProgramList                               = GetObjectList<LiveStreamProgramStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveStreamProgramStatus.FromPointer); // 0x18 ProgramList                 ( ModelClassListType RepeatedField`1<LiveStreamProgramStatus> RepeatedField`1<LiveStreamProgramStatus> List<LiveStreamProgramStatus> Pointer )

            return value;
        }
    }
}
