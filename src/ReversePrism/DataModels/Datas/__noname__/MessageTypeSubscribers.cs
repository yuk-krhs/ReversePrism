using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_messageTypeId                          000186671910 ModelPrimitiveType string string string String
    // 018 SubscriberCount                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 MessageCallback                          00018657DC70 ModelClassType MessageEvent MessageEvent MessageEvent Pointer
    public partial class MessageTypeSubscribers : DataModel
    {
        public string                                   M_messageTypeId                         { get; set; }
        public int                                      SubscriberCount                         { get; set; }
        public MessageEvent?                            MessageCallback                         { get; set; }

        public static MessageTypeSubscribers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageTypeSubscribers() { Pointer= p0 };

            value.M_messageTypeId                           = GetString(new IntPtr(p + 0x010)); // 0245A688A010 0x10 M_messageTypeId             ( 000186671910 ModelPrimitiveType string string string String )
            value.SubscriberCount                           = GetInt32(new IntPtr(p + 0x018)); // 0245A688A030 0x18 SubscriberCount             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MessageCallback                           = GetObject<MessageEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.MessageEvent.FromPointer); // 0245A688A050 0x20 MessageCallback             ( 00018657DC70 ModelClassType MessageEvent MessageEvent MessageEvent Pointer )

            return value;
        }
    }
}
