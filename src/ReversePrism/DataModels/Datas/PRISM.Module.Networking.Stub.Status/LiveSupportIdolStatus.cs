using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveSupportIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesIdolId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 020 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SupportIdolTypeFieldNumber               int IL2CPP_TYPE_I4
    // 024 SupportIdolType                          000186585310 ModelEnumType LiveSupportIdolType LiveSupportIdolType LiveSupportIdolType Int32
    public partial class LiveSupportIdolStatus
    {
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public LiveSupportIdolType                      SupportIdolType                         { get; set; }

        public static LiveSupportIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSupportIdolStatus();

            value.FesIdolId                                 = GetString(new IntPtr(p + 0x018)); // 0270D135CAF8 0x18 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x020)); // 0270D135CB38 0x20 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SupportIdolType                           = (LiveSupportIdolType)GetInt32(new IntPtr(p + 0x024)); // 0270D135CB78 0x24 SupportIdolType             ( 000186585310 ModelEnumType LiveSupportIdolType LiveSupportIdolType LiveSupportIdolType Int32 )

            return value;
        }
    }
}
