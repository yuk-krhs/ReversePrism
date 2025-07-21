using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MessageTypeSubscribers                   ModelClassListType List`1<MessageTypeSubscribers> List`1<MessageTypeSubscribers> List<MessageTypeSubscribers> Pointer
    // 018 ConnectionEvent                          ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer
    // 020 DisconnectionEvent                       ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer
    public partial class PlayerEditorConnectionEvents : DataModel
    {
        public List<MessageTypeSubscribers>?            MessageTypeSubscribers                  { get; set; }
        public ConnectionChangeEvent?                   ConnectionEvent                         { get; set; }
        public ConnectionChangeEvent?                   DisconnectionEvent                      { get; set; }

        public static PlayerEditorConnectionEvents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerEditorConnectionEvents() { Pointer= p0 };

            value.MessageTypeSubscribers                    = GetObjectList<MessageTypeSubscribers>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessageTypeSubscribers.FromPointer); // 0x10 MessageTypeSubscribers      ( ModelClassListType List`1<MessageTypeSubscribers> List`1<MessageTypeSubscribers> List<MessageTypeSubscribers> Pointer )
            value.ConnectionEvent                           = GetObject<ConnectionChangeEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.ConnectionChangeEvent.FromPointer); // 0x18 ConnectionEvent             ( ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer )
            value.DisconnectionEvent                        = GetObject<ConnectionChangeEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ConnectionChangeEvent.FromPointer); // 0x20 DisconnectionEvent          ( ModelClassType ConnectionChangeEvent ConnectionChangeEvent ConnectionChangeEvent Pointer )

            return value;
        }
    }
}
