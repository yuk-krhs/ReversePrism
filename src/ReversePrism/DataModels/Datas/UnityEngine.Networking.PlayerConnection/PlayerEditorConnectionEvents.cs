using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MessageTypeSubscribers                   000185D27B08 ModelClassListType List`1<MessageTypeSubscribers> List`1<MessageTypeSubscribers> List<MessageTypeSubscribers> Pointer
    // 018 ConnectionEvent                          00018657D7D0 ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer
    // 020 DisconnectionEvent                       00018657D7D0 ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer
    public partial class PlayerEditorConnectionEvents
    {
        public List<MessageTypeSubscribers>?            MessageTypeSubscribers                  { get; set; }
        public ConnectionChangeEvent?                   ConnectionEvent                         { get; set; }
        public ConnectionChangeEvent?                   DisconnectionEvent                      { get; set; }

        public static PlayerEditorConnectionEvents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerEditorConnectionEvents();

            value.MessageTypeSubscribers                    = GetObjectList<MessageTypeSubscribers>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessageTypeSubscribers.FromPointer); // 0270068C6DF8 0x10 MessageTypeSubscribers      ( 000185D27B08 ModelClassListType List`1<MessageTypeSubscribers> List`1<MessageTypeSubscribers> List<MessageTypeSubscribers> Pointer )
            value.ConnectionEvent                           = GetObject<ConnectionChangeEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.ConnectionChangeEvent.FromPointer); // 0270068C6E18 0x18 ConnectionEvent             ( 00018657D7D0 ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer )
            value.DisconnectionEvent                        = GetObject<ConnectionChangeEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ConnectionChangeEvent.FromPointer); // 0270068C6E38 0x20 DisconnectionEvent          ( 00018657D7D0 ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer )

            return value;
        }
    }
}
