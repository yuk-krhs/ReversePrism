using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReadPhoneCallArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPhoneCallIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstPhoneCallId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReadPhoneCallArgs
    {
        public int                                      MstPhoneCallId                          { get; set; }

        public static ReadPhoneCallArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadPhoneCallArgs();

            value.MstPhoneCallId                            = GetInt32(new IntPtr(p + 0x018)); // 0270D22F7CF0 0x18 MstPhoneCallId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
