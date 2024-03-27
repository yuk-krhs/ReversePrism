using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetEventInfoForEventStoryReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EventPointFieldNumber                    int IL2CPP_TYPE_I4
    // 020 EventPoint                               0001865F7700 ModelPrimitiveType long long long Int64
    public partial class GetEventInfoForEventStoryReply
    {
        public int                                      MstEventId                              { get; set; }
        public long                                     EventPoint                              { get; set; }

        public static GetEventInfoForEventStoryReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetEventInfoForEventStoryReply();

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 0270D2A2BCB8 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EventPoint                                = GetInt64(new IntPtr(p + 0x020)); // 0270D2A2BCF8 0x20 EventPoint                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
