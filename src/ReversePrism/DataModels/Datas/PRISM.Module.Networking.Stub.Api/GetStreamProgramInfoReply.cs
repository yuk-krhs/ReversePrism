using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStreamProgramInfoReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProgramFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Program                                  000186583E90 ModelClassType LiveStreamProgramStatus LiveStreamProgramStatus LiveStreamProgramStatus Pointer
    public partial class GetStreamProgramInfoReply
    {
        public LiveStreamProgramStatus?                 Program                                 { get; set; }

        public static GetStreamProgramInfoReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStreamProgramInfoReply();

            value.Program                                   = GetObject<LiveStreamProgramStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveStreamProgramStatus.FromPointer); // 0270D2AC0EB0 0x18 Program                     ( 000186583E90 ModelClassType LiveStreamProgramStatus LiveStreamProgramStatus LiveStreamProgramStatus Pointer )

            return value;
        }
    }
}
