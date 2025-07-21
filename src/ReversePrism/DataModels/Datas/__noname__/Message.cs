using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ParticipantId                            ModelPrimitiveType int int int Int32
    // 014 Type                                     ModelEnumType MessageType MessageType MessageType Int32
    // 018 Data                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class Message : DataModel
    {
        public int                                      ParticipantId                           { get; set; }
        public MessageType                              Type                                    { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }

        public static Message? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Message() { Pointer= p0 };

            value.ParticipantId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 ParticipantId               ( ModelPrimitiveType int int int Int32 )
            value.Type                                      = (MessageType)GetInt32(new IntPtr(p + 0x014)); // 0x14 Type                        ( ModelEnumType MessageType MessageType MessageType Int32 )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Data                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
