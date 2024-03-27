using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectScheduleReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TermFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Term                                     000186589270 ModelClassType ProduceTermStatus ProduceTermStatus ProduceTermStatus Pointer
    // 000 NextOrderFieldNumber                     int IL2CPP_TYPE_I4
    // 020 NextOrder                                00018655F880 ModelClassType ProduceNextOrderStatus ProduceNextOrderStatus ProduceNextOrderStatus Pointer
    public partial class SelectScheduleReply
    {
        public ProduceTermStatus?                       Term                                    { get; set; }
        public ProduceNextOrderStatus?                  NextOrder                               { get; set; }

        public static SelectScheduleReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectScheduleReply();

            value.Term                                      = GetObject<ProduceTermStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceTermStatus.FromPointer); // 0270D25A3F90 0x18 Term                        ( 000186589270 ModelClassType ProduceTermStatus ProduceTermStatus ProduceTermStatus Pointer )
            value.NextOrder                                 = GetObject<ProduceNextOrderStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceNextOrderStatus.FromPointer); // 0270D25A3FD0 0x20 NextOrder                   ( 00018655F880 ModelClassType ProduceNextOrderStatus ProduceNextOrderStatus ProduceNextOrderStatus Pointer )

            return value;
        }
    }
}
