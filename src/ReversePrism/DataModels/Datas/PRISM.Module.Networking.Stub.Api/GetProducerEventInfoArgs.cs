using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProducerEventInfoArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 EventTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 018 EventType                                0001865B3340 ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 01C MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetProducerEventInfoArgs : DataModel
    {
        public ProfileEventType                         EventType                               { get; set; }
        public int                                      MstEventId                              { get; set; }

        public static GetProducerEventInfoArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProducerEventInfoArgs() { Pointer= p0 };

            value.EventType                                 = (ProfileEventType)GetInt32(new IntPtr(p + 0x018)); // 024662643758 0x18 EventType                   ( 0001865B3340 ModelEnumType ProfileEventType ProfileEventType ProfileEventType Int32 )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x01C)); // 024662643798 0x1C MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
