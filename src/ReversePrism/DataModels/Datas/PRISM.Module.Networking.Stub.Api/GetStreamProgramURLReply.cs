using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStreamProgramURLReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStreamProgramIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstStreamProgramId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StreamUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StreamUrl                                000186671910 ModelPrimitiveType string string string String
    // 000 RoomIdFieldNumber                        int IL2CPP_TYPE_I4
    // 028 RoomId                                   000186671910 ModelPrimitiveType string string string String
    public partial class GetStreamProgramURLReply
    {
        public int                                      MstStreamProgramId                      { get; set; }
        public string                                   StreamUrl                               { get; set; }
        public string                                   RoomId                                  { get; set; }

        public static GetStreamProgramURLReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStreamProgramURLReply();

            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x018)); // 0270D2AC35F8 0x18 MstStreamProgramId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StreamUrl                                 = GetString(new IntPtr(p + 0x020)); // 0270D2AC3638 0x20 StreamUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.RoomId                                    = GetString(new IntPtr(p + 0x028)); // 0270D2AC3678 0x28 RoomId                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
