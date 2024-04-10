using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Flags                                  000186636730 ModelEnumType Flags Flags Flags Int32
    // 018 M_LocalManager                           000186700A00 ModelClassType InputManager InputManager InputManager Pointer
    // 020 M_Subscribers                            000185CBE328 ModelClassListType Subscriber[] Subscriber[] List<Subscriber> Pointer
    // 028 M_Senders                                000185CBE228 ModelEnumListType RemoteSender[] RemoteSender[] List<RemoteSender> Pointer
    public partial class InputRemoting : DataModel
    {
        public Flags                                    M_Flags                                 { get; set; }
        public InputManager?                            M_LocalManager                          { get; set; }
        public List<Subscriber>?                        M_Subscribers                           { get; set; }
        public List<RemoteSender>?                      M_Senders                               { get; set; }

        public static InputRemoting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputRemoting() { Pointer= p0 };

            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x010)); // 0246677151F8 0x10 M_Flags                     ( 000186636730 ModelEnumType Flags Flags Flags Int32 )
            value.M_LocalManager                            = GetObject<InputManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputManager.FromPointer); // 024667715218 0x18 M_LocalManager              ( 000186700A00 ModelClassType InputManager InputManager InputManager Pointer )
            value.M_Subscribers                             = GetObjectList<Subscriber>(new IntPtr(p + 0x020), ReversePrism.DataModels.Subscriber.FromPointer); // 024667715238 0x20 M_Subscribers               ( 000185CBE328 ModelClassListType Subscriber[] Subscriber[] List<Subscriber> Pointer )
            value.M_Senders                                 = GetEnumList<RemoteSender>(new IntPtr(p + 0x028)); // 024667715258 0x28 M_Senders                   ( 000185CBE228 ModelEnumListType RemoteSender[] RemoteSender[] List<RemoteSender> Pointer )

            return value;
        }
    }
}
