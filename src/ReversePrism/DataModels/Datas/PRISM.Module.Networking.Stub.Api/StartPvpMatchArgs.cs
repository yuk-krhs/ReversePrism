using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StartPvpMatchArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OpponentUserIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 OpponentUserId                           000186671910 ModelPrimitiveType string string string String
    // 000 DeviceTokenFieldNumber                   int IL2CPP_TYPE_I4
    // 020 DeviceToken                              000186671910 ModelPrimitiveType string string string String
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 028 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StartPvpMatchArgs
    {
        public string                                   OpponentUserId                          { get; set; }
        public string                                   DeviceToken                             { get; set; }
        public int                                      MstEventId                              { get; set; }

        public static StartPvpMatchArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartPvpMatchArgs();

            value.OpponentUserId                            = GetString(new IntPtr(p + 0x018)); // 0270D274E268 0x18 OpponentUserId              ( 000186671910 ModelPrimitiveType string string string String )
            value.DeviceToken                               = GetString(new IntPtr(p + 0x020)); // 0270D274E2A8 0x20 DeviceToken                 ( 000186671910 ModelPrimitiveType string string string String )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x028)); // 0270D274E2E8 0x28 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
