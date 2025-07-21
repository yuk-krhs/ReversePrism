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
    // 018 MstStreamProgramId                       ModelPrimitiveType int int int Int32
    // 000 StreamUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StreamUrl                                ModelPrimitiveType string string string String
    // 000 RoomIdFieldNumber                        int IL2CPP_TYPE_I4
    // 028 RoomId                                   ModelPrimitiveType string string string String
    public partial class GetStreamProgramURLReply : DataModel
    {
        public int                                      MstStreamProgramId                      { get; set; }
        public string                                   StreamUrl                               { get; set; }
        public string                                   RoomId                                  { get; set; }

        public static GetStreamProgramURLReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStreamProgramURLReply() { Pointer= p0 };

            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstStreamProgramId          ( ModelPrimitiveType int int int Int32 )
            value.StreamUrl                                 = GetString(new IntPtr(p + 0x020)); // 0x20 StreamUrl                   ( ModelPrimitiveType string string string String )
            value.RoomId                                    = GetString(new IntPtr(p + 0x028)); // 0x28 RoomId                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
